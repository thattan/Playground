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
            "language": {
                "emptyTable": "No record found.",
                "processing":
                    '<i class="fa fa-spinner fa-spin fa-3x fa-fw" style="color:#2a2b2b;"></i><span class="sr-only">Loading...</span> '
            },
            "columns": [
                { "data": "id", "autoWidth": true },
                { "data": "name", "autoWidth": true },
                { "data": "mission", "autoWidth": true },
                {
                    "data": "createdDate", "autoWidth": true, "render": function (data) {
                        var date = new Date(data);
                        var month = date.getMonth() + 1;
                        var day = date.getDate();
                        return date.getFullYear() + "/"
                            + (month.length > 1 ? month : "0" + month) + "/"
                            + ("0" + day).slice(-2);
                        //return date format like 2000/01/01;
                    }
                }
            ]
        });
    };
});