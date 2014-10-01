$(function () {
    var url = $("#url").val();
    var promise = $.ajax({
        url: url
    });

    promise.success(function (lista) {
        $("#estado").autocomplete({
            source: lista
        });
    });
})