using Microsoft.AspNetCore.Mvc;
using Playground.Data;
using Playground.Models;
using Playground.Models.Pokemon;
using PokeApiNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace Playground.Controllers
{
    public class PokemonController : Controller
    {
        PokeApiClient pokeClient;
        private readonly ApplicationDbContext _context;

        public PokemonController(ApplicationDbContext context)
        {
            pokeClient = new PokeApiClient();
            _context = context;
        }

        public async Task<IActionResult> Index(int id = 1)
        {
            var date = DateTime.Now;
            _context.Students.Add(new Student() {
                EnrollmentDate = date,
                LastName = "TEST Tyler",
                FirstMidName = "TEST"
            });

            var students = _context.Students.Where(x => x.LastName == "TEST Tyler");

            _context.SaveChanges();
            try
            {
                Generation gen = await pokeClient.GetResourceAsync<Generation>(id);


                var list = new PokemonIndexModel()
                {
                    activeGeneration = id,
                    pageNumber = 1
                };
                return View("Index", list);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View("/Home/Index");
            }

        }

        public async Task<IActionResult> LoadPokemon(int id)
        {
            Pokemon pokemon = await pokeClient.GetResourceAsync<Pokemon>(id);
            return PartialView("_pokemon-modal", pokemon);
        }

        public async Task<IActionResult> LoadPokeList(PokemonIndexModel model)
        {
            try
            {
                int generation = model.activeGeneration.Value - 1;

                int pageRem;
                int speciesCount = model.generations[generation].endId - model.generations[generation].startId;
                int pageCount = Math.DivRem(speciesCount, 12, out pageRem);

                int pages = pageRem > 0 ? (speciesCount / 12) + 1 : pageCount;

                var pageIndexEnd = model.pageNumber * 12;
                var pageIndexStart = pageIndexEnd - 12;

                model.pages = pages;

                List<PokeApiNet.NamedApiResource<PokemonSpecies>> searchList = new List<NamedApiResource<PokemonSpecies>>();
                if (model.search != null && model.search != "")
                {
                    Generation gen = await pokeClient.GetResourceAsync<Generation>(model.activeGeneration.Value);
                    searchList = gen.PokemonSpecies.Where(x => x.Name.Contains(model.search, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                var start = model.generations[generation].startId;
                var end = model.generations[generation].endId;
                if (searchList?.Count > 0) //if searching
                {
                    start = 1;
                    end = searchList.Count;
                }

                List<Pokemon> pokemonList = new List<Pokemon>();
                for (int i = start; i <= end; i++)
                {
                    try
                    {
                        Pokemon pokemon = null;
                        if (searchList?.Count > 0)
                        {
                            pokemon = await pokeClient.GetResourceAsync<Pokemon>(searchList[i - 1].Name);
                        } else
                        {
                            pokemon = await pokeClient.GetResourceAsync<Pokemon>(i);
                        }

                        if (pokemon != null)
                        {
                            pokemonList.Add(pokemon);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                //pokemonList = pokemonList.OrderBy(x => x.Id).ToList();

                var rangeCount = 12;
                if (model.pageNumber == pages)
                {
                    if (pageRem > 0)
                    {
                        rangeCount = pageRem;
                    }
                }

                if (searchList?.Count > 0)
                {
                    model.pokemonList = pokemonList;
                } else
                {
                    pokemonList = pokemonList.GetRange(pageIndexStart.Value, rangeCount);

                    model.pokemonList = pokemonList;
                }

                return PartialView("_pokemon-list", model);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View("/Home/Index");
            }

        }
    }
}
