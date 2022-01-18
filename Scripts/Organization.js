$(function () {
    loadTable();

    function loadTable() {
        $('#OrganizationTable').DataTable({
            "processing": true,
            "serverSide": true,
            "ajax": {
                "url": "OrganizationList",
                "type": "POST"
            },
            "columns": [
                { "data": "test1", "name": "test1", "autoWidth": true },
                { "data": "test2", "name": "test2", "autoWidth": true },
                { "data": "test3", "name": "test3", "autoWidth": true }
            ]
        });
    };
});