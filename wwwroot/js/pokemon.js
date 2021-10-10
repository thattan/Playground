$("document").ready(function () {
    loadData();

    function loadData() {
        loadList();

        function loadList() {
            let activeGeneration = $('#activeGeneration').val();
            let pageNumber = $('#pageNumber').val();

            let model = {
                activeGeneration: activeGeneration,
                pageNumber: pageNumber
            }

            $.ajax({
                type: 'POST',
                url: '/Pokemon/LoadPokeList/',
                data: model,
                success: function (data) {
                    $('#loading').hide();
                    $('#pokemon-list').empty();
                    $('#pokemon-list').html(data);
                }
            });
        }

        $('#pokemon-list').on('click', '.page-link', function (e) {
            e.preventDefault();
            $('#pokemon-list').empty();
            $('#loading').show();
            let newPageNumber = $(this).data("id");
            $('#pageNumber').val(newPageNumber);
            loadList();
        })

        $('#pokemon-list').on('click', '.view-pokemon', function () {
            let id = $(this).parent().data("id");
            $('#pokemon-modal-content').load('/Pokemon/LoadPokemon/' + id, function () {
                $('#pokemon-modal').modal('show');
            });            
        })

        $('.search-pokemon').on('click', function () {
            let activeGeneration = $('#activeGeneration').val();
            let pageNumber = $('#pageNumber').val();
            let search = $('#search').val();

            let model = {
                activeGeneration: activeGeneration,
                pageNumber: pageNumber,
                search: search
            }

            $('#pokemon-list').empty();
            $('#loading').show();

            $.ajax({
                type: 'POST',
                url: '/Pokemon/LoadPokeList/',
                data: model,
                success: function (data) {
                    $('#loading').hide();
                    $('#pokemon-list').html(data);
                }
            });
        })
    }

})