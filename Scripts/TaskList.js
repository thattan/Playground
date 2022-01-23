$(function () {
    feather.replace();
    loadList();

    $('#plus').on('click', function (e) {
        e.preventDefault();
        var message = $('#task-message').val();
        if (message) {
            $.ajax({
                type: 'POST',
                url: '/Home/AddTask/',
                data: {
                    data: message
                },
                success: function (data) {
                    $('#task-message').val('');
                    loadList();
                }
            });
        } else {
            toastr.error('Message Required');
        }

    });

    $('#save').on('click', function (e) {
        e.preventDefault();
        var list = [];
        $(".list-group-item").each(function (index) {
            index++;
            var taskId = $(this).data("task-id");
            var message = $(this).find('.list-message').html();

            list.push({
                Id: taskId,
                Text: message,
                Order: index,
                Completed: false
            });
        });

        $.ajax({
            type: 'POST',
            url: '/Home/SaveTasks/',
            data: {
                list: list
            },
            success: function (data) {
                toastr.success('Saved List');
            }
        });

    });

    $('#delete').on('click', function (e) {
        e.preventDefault();
        var list = [];
        $(".list-check").each(function (index) {
            var check = $(this).is(':checked');
            if (check) {
                var taskId = $(this).parent().parent().data("task-id");
                var message = $(this).parent().find('.list-message').html();

                list.push({
                    Id: taskId,
                    Text: message,
                    Order: index++,
                    Complete: true
                });
            }
        });

        $.ajax({
            type: 'POST',
            url: '/Home/SaveTasks/',
            data: {
                list: list
            },
            success: function (data) {
                toastr.success('Completed Tasks');
                loadList();
            }
        });
    });

    function loadList() {
        $('#task-list').html('');
        $('#task-list').load('/Home/TaskList', function () {
            Sortable.create(simpleList, {
                animation: 150,
                ghostClass: 'blue-background-class'
            });
        });
    }
});

$(document).on('dblclick', '.list-group-item', function (e) {
    if ($(e.target).hasClass("form-control list-input")) {
        return;
    }

    var message = $(this).find('.list-message').html();
    var child = $(this).children(0);

    var inputDiv = '<input class="form-control list-input" value="' + message + '"style = "width: 100%;" >';

    child.html('');
    child.html(inputDiv);
    $('.list-input').focus();

    $('.list-input').keypress(function (e) {
        if (e.which === 13) {
            buildListDiv();
        }
    });

    $('.list-input').focusout(function () {
        buildListDiv();
    });

    function listString(message) {
        return '<div class="list-message" style="max-width: 80%; float: left;">' + message + '</div>' +
            '<input class="form-check-input list-check" type = "checkbox" value = "" style = "right: 3%;">';
    }

    function buildListDiv() {
        var newMessage = $('.list-input').val();
        var listDiv = '';
        if (newMessage) {
            listDiv = listString(newMessage);
        } else {
            toastr.error('Text Required');
            listDiv = listString(message);
        }
        child.html('');
        child.html(listDiv);
    }
});