// Write your JavaScript code.
function RetornarPlano() {
    $.ajax({
        type: "GET",
        url: 'RetornarPlano?Id=',
        success: function (data) {
            var parsed = JSON.parse(data);
            var arr = [];
            for (var x in parsed) {
                arr.push(parsed[x]);
            }
            $("#decIteId").empty();
            $("#decIteId").append("<option value='0'>Selecione</option>");
            $.each(arr, function (i, v) {
                $("#decIteId").append("<option value='" + v.decIteId + "'>" + v.strIteDescricao + "</option>")
            });
        }
    })
}
