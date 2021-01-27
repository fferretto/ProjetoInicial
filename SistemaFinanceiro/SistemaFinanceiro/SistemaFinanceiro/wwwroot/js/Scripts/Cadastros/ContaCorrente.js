function carregaPagina() {

    if ($("#acessoAdmin").val() == 'True') {
        $("#FiltroEmpresa").show();
    }

    if ($('#bBoleto').val() == "True") {
        $("#btnBolSim").click();
        $("#liBolNao").removeClass('active');
        $("#liBolSim").addClass('active');
    }
    if ($('#bPagamento').val() == "True") {
        $("#btnPagSim").click();
        $("#liPagNao").removeClass('active');
        $("#liPagSim").addClass('active');
    }

    if ($('#acessoAdmin').val() == "False") {
        $('.codEmpresa').prop('disabled', true);
    }

    if ($('#CodBanco').val() != "104") {
        $('#codOperacaoCC').prop('disabled', true);
        $('#ParamTransCaixa').hide();
    }

    if ($('#codContaCorrente').val() == '' || $('#codContaCorrente').val() == '0') {
        $("#btnDesativar").attr('disabled', 'disabled');
        $("#btnHomologacao").attr('disabled', 'disabled');
        
    }

    if ($('#formaTransmissaoPG').val() == "MANUAL") {
        $("#btnManualPGTO").click();
        $("#liAPIPGTO").removeClass('active');
        $("#liVanBancariaPGTO").removeClass('active');
        $("#liManualPGTO").addClass('active');
    }
    if ($('#formaTransmissaoPG').val() == "API") {
        $("#btnAPIPGTO").click();
        $("#liVanBancariaPGTO").removeClass('active');
        $("#liManualPGTO").removeClass('active');
        $("#liAPIPGTO").addClass('active');
    }
    if ($('#formaTransmissaoPG').val() == "VAN") {
        $("#btnVanBancariaPGTO").click();
        $("#liAPIPGTO").removeClass('active');
        $("#liManualPGTO").removeClass('active');
        $("#liVanBancariaPGTO").addClass('active');
    }


    if ($('#formaTransmissaoBol').val() == "MANUAL") {
        $("#btnManualBOL").click();
        $("#liAPIBOL").removeClass('active');
        $("#liVanBancariaBOL").removeClass('active');
        $("#liManualBOL").addClass('active');
    }
    if ($('#formaTransmissaoBol').val() == "API") {
        $("#btnAPIBOL").click();
        $("#liVanBancariaBOL").removeClass('active');
        $("#liManualBOL").removeClass('active');
        $("#liAPIBOL").addClass('active');
    }
    if ($('#formaTransmissaoBol').val() == "VAN") {
        $("#btnVanBancariaBOL").click();
        $("#liAPIBOL").removeClass('active');
        $("#liManualBOL").removeClass('active');
        $("#liVanBancariaBOL").addClass('active');
    }
}
$(window).load(carregaPagina);


$('#CpfCnpj').focusout(function () {

    var CNPJ = $('#CpfCnpj').val();

    if (CNPJ != "") {
        CNPJ = CNPJ.replace('/', '').replace('.', '').replace('-', '')
        if (!validarCNPJ(CNPJ)) {
            $('#CpfCnpj').addClass("borderError");
            addErros("CpfCnpj", "CNPJ Inválido!")
        }
        else {
            //$('#CpfCnpj').val(cpf_mask(CNPJ))
            $('#CpfCnpj').removeClass("borderError");
            $("span[data-valmsg-for='CpfCnpj']").hide();
        }
    }
})


$(".CodBanco").change(function () {
    $("#CodBanco").val($('.CodBanco option:selected').val());

    if ($('#CodBanco').val() == "104") {
        $('#codOperacaoCC').prop('disabled', false);
        $('#ParamTransCaixa').show();
    }
    else {
        $('#codOperacaoCC').val('');
        $('#ParamTransCaixa').val('');
        $('#codOperacaoCC').prop('disabled', true);
        $('#ParamTransCaixa').hide();
    }
});

$(".codEmpresa").change(function () {
    $("#codEmpresa").val($('.codEmpresa option:selected').val());

});

function CarregaGrid() {

    $("#codEmpresa").val($('.codEmpresa option:selected').val());

    var url = montaUrl("/Cadastros/ContaCorrente/ConsultaContaCorrente/")
    url += ("&codEmpresa=" + $("#codEmpresa").val());

    $("#modal").load(url);
    $("#Localizar").modal();
}

function GeraArquivoHomologacao() {

    var url = montaUrl("/Cadastros/ContaCorrente/ProcessoHomologacaoConta/")
    url += "&codigoContaCorrente=" + $("#codContaCorrente").val();

    $("#modal").load(url);
    $("#Localizar").modal();

}
function formaTransmissaoPG(tipo) {
    if (tipo == 'MANUAL') {
        $("#formaTransmissaoPG").val('MANUAL');
        $("#loginTransmissaoPG").val('');
        $("#senhaTransmissaoPG").val('');
        $("#caminhoRemessaPG").val('');
        $("#caminhoRetornoPG").val('');
    }
    else if (tipo == 'API') {
        $("#formaTransmissaoPG").val('API');
        $("#caminhoRemessaPG").val('');
        $("#caminhoRetornoPG").val('');
    }
    else if (tipo == 'VAN') {
        $("#formaTransmissaoPG").val('VAN');
        $("#loginTransmissaoPG").val('');
        $("#senhaTransmissaoPG").val('');
    }
};

function formaTransmissaoBOL(tipo) {
    if (tipo == 'MANUAL') {
        $("#formaTransmissaoBOL").val('MANUAL');
        $("#loginTransmissaoBOL").val('');
        $("#senhaTransmissaoBOL").val('');
        $("#caminhoRemessaBOL").val('');
        $("#caminhoRetornoBOL").val('');
    }
    else if (tipo == 'API') {
        $("#formaTransmissaoBOL").val('API');
        $("#caminhoRemessaBOL").val('');
        $("#caminhoRetornoBOL").val('');
    }
    else if (tipo == 'VAN') {
        $("#formaTransmissaoBOL").val('VAN');
        $("#loginTransmissaoBOL").val('');
        $("#senhaTransmissaoBOL").val('');
    }
};

$("#btnPagSim").click(function () {
    $("#bPagamento").val('True');
    formaTransmissaoPG('MANUAL');
})
$("#btnPagNao").click(function () {
    $("#bPagamento").val('False');
    $("#CodConvenioPag").val('');
    $("#ParametroTransmissaoPag").val('');
    $("#valTED").val('');
    $("#ValMinPGTO").val('');
    $("#ValMinTED").val('');
})
$("#btnBolSim").click(function () {
    formaTransmissaoBOL('MANUAL');
    $("#bBoleto").val('True');
})
$("#btnBolNao").click(function () {
    $("#bBoleto").val('False');
    $("#CodConvenioBol").val('');
    $("#CodTrasmissao240").val('');
    $("#CodTransmissao400").val('');
    $("#CarteiraRemessa").val('');
    $("#CarteiraBol").val('');
})
$("#btnManualPGTO").click(function () {
    formaTransmissaoPG('MANUAL');
});
$("#btnAPIPGTO").click(function () {
    formaTransmissaoPG('API');
});
$("#btnVanBancariaPGTO").click(function () {
    formaTransmissaoPG('VAN');
});

$("#btnManualBOL").click(function () {
    formaTransmissaoBOL('MANUAL');
});
$("#btnAPIBOL").click(function () {
    formaTransmissaoBOL('API');
});
$("#btnVanBancariaBOL").click(function () {
    formaTransmissaoBOL('VAN');
});

function ConfirmaSalvar() {
    var validado = true;

    if ($("#CodBanco").val() == "" || $("#CodBanco").val() == "0") {
        validado = false;
        msgAviso("Banco não Informado!")
    }

    var CNPJ = $('#CpfCnpj').val();
    if (!validarCNPJ(CNPJ)) {
        validado = false;
        $('#CpfCnpj').addClass("borderError");
        addErros("CpfCnpj", "CNPJ Inválido!")
    }


    var form = $('form', '#page-inner');

    var url = montaUrl("/Cadastros/ContaCorrente/Salvar/");

    if (validado) {
        $.blockUI({ message: '<div class="ModalCarregando"></dic>' });
        form.attr('action', url);
        form.submit();
    }
}
function NovaContaCorrente() {

    var form = $('form', '#page-inner');

    var url = montaUrl("/Cadastros/ContaCorrente/Index/");

    form.attr('action', url);
    form.submit();
}
function ConfirmaDesativar() {
    var form = $('form', '#page-inner');

    var url = montaUrl("/Cadastros/ContaCorrente/Desativar/");
    $.blockUI({ message: '<div class="ModalCarregando"></dic>' });

    form.attr('action', url);
    form.submit();
}

//--------------------------Geração de arquivos para homologação----------------------
function LocalizaFavorecido() {
    $("#codEmpresa").val($('.codEmpresa option:selected').val());
    var url = montaUrl("/Cadastros/ContaCorrente/ConsultaFavorecido")
    url += "&codigoEmpresa=" + $("#codEmpresa").val();


    $("#modal2").load(url);
    $("#Localizar2").modal();
}
function SelecionaFavorecido(CODFAVORECIDO) {

    if (CODFAVORECIDO != "") {

        var url = montaUrl('/Cadastros/ContaCorrente/BuscaFavorecido/?filtroFavorecido=' + CODFAVORECIDO);
        url += '&codigoEmpresa=' + $("#codEmpresa").val();

        $.ajax({
            type: 'get',
            url: url,
            dataType: 'json',
            success: function (data) {
                $("#Localizar2 .close").click();
                if (data.length > 0) {
                    PreencheFavorecido(data);

                } else {
                    addErros("nomeFavorecido", "Favorecido não encontrado");
                }
            },
            error: function (xhr, ajaxOptions, thrownError) {
                addErros("nomeFavorecido", "Erro interno. Tente novamente mais tarde.");
            }
        });
    }
    else {
        $("#filtroFavorecido").val('');
        $("#nomeFavorecido").val('');
    }

}
function PreencheFavorecido(data) {
    var arr = data.split("/");

    $("#filtroFavorecido").val(arr[0]);
    $("#nomeFavorecido").val(arr[1]);
    $("#codigoFavorecido").val(arr[0])
};
function GeraArquivoRemessa(TipoArquivo) {

    $("#codEmpresa").val($('.codEmpresa option:selected').val());

    var data = "codigoEmpresa=" + $("#codEmpresa").val()
        + "&CodigoContaCorrente=" + $("#codContaCorrente").val()
        + "&codigoFavorecido=" + + $("#codigoFavorecido").val()
        + "&TipoArquivo=" + TipoArquivo;


    var _url = montaUrl("/Cadastros/ContaCorrente/GeraArquivo")
    $.blockUI({ message: '<div class="ModalCarregando"></dic>' });


    // Submit form data via ajax
    $.ajax({
        type: "Post",
        url: _url,
        data: data,
        success: function (data) {
            $.unblockUI();

            if (data.success) {
                var caminho = montaUrl("/Cadastros/ContaCorrente/DownloadArquivoRemessa/");
                caminho += "&id=" + data.responseText;
                caminho += "&codigoEmpresa=" + $("#codEmpresa").val();
                caminho += "&TipoArquivo=" + TipoArquivo;
                var TransmissaoManual = false;
                if (TipoArquivo == 'PAG') {
                    if ($('#formaTransmissaoPG').val() == "MANUAL")
                        TransmissaoManual = true;
                    else
                        TransmissaoManual = false;
                }
                else {
                    if ($('#formaTransmissaoBol').val() == "MANUAL")
                        TransmissaoManual = true;
                    else
                        TransmissaoManual = false;
                }


                $("#btnDownloadBolPDF").attr('disabled', false);
                if (TransmissaoManual) {
                    window.location.href = caminho;
                }
                else {
                    msgSucesso("Arquivo gerado e enviado para o banco com sucesso!")
                }
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

};
function DownloadBoleto() {

    $("#codEmpresa").val($('.codEmpresa option:selected').val());

    var _url = montaUrl("/Cadastros/ContaCorrente/DownloadBoleto");
    _url += "&codigoEmpresa=" + $("#codEmpresa").val();
    _url += "&CodigoContaCorrente=" + $("#codContaCorrente").val();

    window.location.href = _url;

};
