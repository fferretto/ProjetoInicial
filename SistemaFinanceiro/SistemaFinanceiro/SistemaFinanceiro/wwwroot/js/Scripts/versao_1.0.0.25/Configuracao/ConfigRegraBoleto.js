
function carregaPagina() {

    if ($("#CODREGRA").val() == '0') {
        $("#DesativarRegra").prop('disabled', true);
    }

    if ($("#acessoAdmin").val() == 'True') {
        $("#FiltroEmpresa").show();
    }

    if ($('#COBRAMULTA').val() == "True") {
        $("#btnMultaSim").click();

        if ($('#VLMULTADIAATRASO').val() != " 0,00") {
            console.log($('#VLMULTADIAATRASO').val())
            $("#btnMultaValor").click();
            $("#liMultaValor").addClass('active');
        }
        else if ($('#PERCMULTA').val() != " 0,00"){
            $("#btnMultaPerc").click();
            $("#liMultaPerc").addClass('active');
        }
    }

    if ($('#AgruparCobranca').val() == "True") {
        $("#btnAgruparCobrancaSim").click();
        $("#liAgruparCobrancaNao").removeClass('active');
        $("#liAgruparCobrancaSim").addClass('active');
    }


    if ($('#COBRAJUROS').val() == "True") {
        $("#btnJurosSim").click();

        if ($('#VLJUROSDIAATRASO').val() != " 0,00") {
            $("#btnJurosValor").click();
            $("#liJurosValor").addClass('active');
        }
        else if ($('#PERCJUROS').val() != " 0,00") {
            $("#btnJurosPerc").click();
            $("#liJurosPerc").addClass('active');
        }
    }

}

$(window).load(carregaPagina());


$("#btnAgruparCobrancaNao").click(function () {
    $("#AgruparCobranca").val('false');
})

$("#btnAgruparCobrancaSim").click(function () {
    $("#AgruparCobranca").val('true');
})

$("#btnMultaNao").click(function () {
    $("#VLMULTADIAATRASO").val('');
    $("#PERCMULTA").val('');
    $("#COBRAMULTA").val('false');
})

$("#btnMultaSim").click(function () {
    $("#COBRAMULTA").val('true');
})
$("#btnMultaValor").click(function () {
    $("#PERCMULTA").val('');
    $("#liMultaValor").removeClass('active');
    $("#liMultaPerc").removeClass('active');
    $("#liMultaValor").addClass('active');
})

$("#btnMultaPerc").click(function () {
    $("#VLMULTADIAATRASO").val('');
})

$("#btnJurosNao").click(function () {
    $("#VLJUROSDIAATRASO").val('');
    $("#PERCJUROS").val('');
    $("#COBRAJUROS").val('false');
})

$("#btnJurosSim").click(function () {
    $("#COBRAJUROS").val('true');
})


$("#btnJurosValor").click(function () {
    $("#PERCJUROS").val('');
})

$("#btnJurosPerc").click(function () {
    $("#VLJUROSDIAATRASO").val('');
})

$(".CODEMPRESA").change(function () {
    $("#CODEMPRESA").val($('.CODEMPRESA option:selected').val());
});

$(".CODPRIMEIRAINSTCOBRA").change(function () {
    $("#CODPRIMEIRAINSTCOBRA").val($('.CODPRIMEIRAINSTCOBRA option:selected').val());

});


$(".CODSEGUNDAINSTCOBRA").change(function () {
    $("#CODSEGUNDAINSTCOBRA").val($('.CODSEGUNDAINSTCOBRA option:selected').val());

});

function JustificativaDesativarRegra() {
    
    var url = montaUrl("/Configuracao/ConfigRegraBoleto/Justificativa")

    $("#modalJustificativa").load(url);
    $("#Justificativa").modal();

}

function SalvarRegra() {
    var Valido = true;


    if (Valido) {
        var form = $('form', '#page-inner');

        var url = montaUrl("/Configuracao/ConfigRegraBoleto/SalvaRegra/");

        $.blockUI({ message: '<div class="ModalCarregando"></dic>' });

        form.attr('action', url);
        form.submit();
    }

}
function ConfirmaDesativarRegra() {

    var codJustificativa = $('.codJustificativa option:selected').val()
    var descJustificativa = $('.codJustificativa').find("option:selected").text();

    if (codJustificativa == "-1" || codJustificativa == "NAOINFORMADO") {
        msgAviso("Obrigatório justificar o motivo.");
        return false;
    }


    var data = "CODREGRA=" + $("#CODREGRA").val()
        + "&codJustificativa=" + codJustificativa
        + "&descJustificativa=" + descJustificativa
        + "&DescJustOutros=" + $("#DescJustOutros").val()
    
    var url = montaUrl("/Configuracao/ConfigRegraBoleto/DesativarRegra");

    $.blockUI({ message: '<div class="ModalCarregando"></dic>' });

    // Submit form data via ajax
    $.ajax({
        type: "Post",
        url: url,
        data: data,
        success: function (data) {
            $.unblockUI();

            if (data.success) {

                $("#Justificativa .close").click();
                msgSucessoWithLoad(data.responseText);

            }
            else {
                msgErro(data.responseText)
            }
        },
        error: function (data) {

            $.unblockUI();
            msgErro('Ocorreu uma falha durante o processo. favor contactar o suporte técnico!');
        }
    });

}
