//Criando uma div que ocupa toda tela, com o formulario
//(function ($) {
//    var search_button = $('.fa-address-card'),
//        close_button = $('.close'),
//        form = $('.cadForm');
//    search_button.on('click', function () {
//        $(this).parent().addClass('open');
//        close_button.fadeIn(500);
//        form.fadeIn(1000);
//    });

//removendo a div que contem todo o formulario
//    close_button.on('click', function () {
//        form.hide(300)
//        search_button.parent().removeClass('open');
//        close_button.fadeOut(500);
//        form.fadeOut(0);
//    });
//})(jQuery);

//criando uma div "label" para cpf e cnpj
//$(document).ready(function () {
//    $(".divCpf").children("label").remove();
//    $(".divCpf").prepend("<div class='d-lg-inline-flex' style='align-items: baseline;margin-bottom: 6px;'><div class='btnCpf_cnpj p-2' id ='btnCpf'>CPF</div><div class='btnCpf_cnpj p-2' id='btnCnpj'>CNPJ</div></div")
//})


$(document).ready(function () {
    var cpf_cnpj = $('.btnCpf_cnpj'),
        cpf = $('#btnCpf'),
        cnpj = $('#btnCnpj');
    $(cpf_cnpj).click(function (e) {
        if (e.target.id == 'btnCpf') {
            cpf.css('background-color', '#252c34');
            cpf.css('color', '#fff');

            cnpj.css('background-color', '#fff');
            cnpj.css('color', '#252c34');
        }
        if (e.target.id == 'btnCnpj'){
            cnpj.css('background-color', '#252c34');
            cnpj.css('color', '#fff');
            
            cpf.css('background-color', '#fff');
            cpf.css('color', '#252c34');
        }
        cpf_cnpj.css('border-radius', '5px');
    })
})

$("input").focus(function (e) {
    $("label[for='" + e.target.id + "']").addClass('labelFocus')
}).blur(function () {
    $("label").removeClass('labelFocus')
})




















