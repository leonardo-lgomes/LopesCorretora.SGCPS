// Write your JavaScript code.
function fctPreencheComboItem() {
    $.ajax({
        type: "GET",
        url: '/PessoaFisica/RetornarPlano?Id=' + $("#Plano").val(),
        data: "{}",
        cache: false,
        dataType: "html",
        assync: true,
        success: function (data) {
            var parsed = JSON.parse(data);
            document.getElementById('TelefoneDoPlano').value = parsed.telefoneDoPlano;
        }
    })
}
