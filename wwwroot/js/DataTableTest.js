

$(function () {
    loadTable();
    

    $("#test-btn").on("click", function () {
        alert("test 2");
    });

    function loadTable() {
        $('#example').DataTable({
            "processing": true,
            "serverSide": true,
            "ajax": {
                "url": "home/DataTableCall/",
                "type": "POST"
            },
            "columns": [
                { "data": "header1" },
                { "data": "header2" },
                { "data": "header3" }
            ]
        });
    };
});