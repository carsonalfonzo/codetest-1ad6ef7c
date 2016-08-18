

$(document).ready(function () {


    $('#buttonGenerator').click(function () {
        $("#outputSection").empty();
        var number = "<b>The 10-Substring</b>";
        var uri = 'api/TenSubstringGenerator/GetNumbers/' + $('#inputNumber').val();
        // Send an AJAX request
        $.ajax({
            url: uri,
            type: 'GET',
            dataType: 'xml',
            contentType: 'application/xml; charset=utf-8',
            success: function (data) {

                $(data).find('ArrayOfint int').each(function () {
                    number = number + ' ' + $(this).text();
                });

                $("#outputSection").append(number);
            },
            error: function (x, y, z) {
                $("#outputSection").append("An unexpected error has occurred");
            }
        });
    });
   
});

function clearResult() {
    $("#outputSection").empty();
}