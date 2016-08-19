

$(document).ready(function () {


    $('#buttonGenerator').click(function () {
        $("#outputSection").empty();
        $("#outputSection").append('<span class="help-block" id="infoPanel">Generating Substrings</span>');
        var number = "<b>Results:</b>";
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
                $("#outputSection").empty();
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