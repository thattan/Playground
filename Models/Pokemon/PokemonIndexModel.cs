using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PokeApiNet;

namespace Playground.Models.Pokemon
{
    public class PokemonIndexModel
    {
        public List<PokeApiNet.Pokemon> pokemonList { get; set; }

        public int? activeGeneration {get; set;}

        public int? pageNumber { get; set; }

        public decimal pages { get; set; }

        public string search { get; set; }

        public List<GenerationList> generations { get; set; } = new List<GenerationList>()
        {
            new GenerationList() { startId = 1, endId = 151},
            new GenerationList() { startId = 152, endId = 251},
            new GenerationList() { startId = 252, endId = 386},
            new GenerationList() { startId = 387, endId = 493},
            new GenerationList() { startId = 494, endId = 649},
            new GenerationList() { startId = 650, endId = 721},
            new GenerationList() { startId = 722, endId = 809},
            new GenerationList() { startId = 810, endId = 898}
        };
    }
}
