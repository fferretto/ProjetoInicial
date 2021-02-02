(function ($) {
    var search_button = $('.fa-address-card'),
        close_button = $('.close'),
        form = $('.cadForm');
    search_button.on('click', function () {
        $(this).parent().addClass('open');
        close_button.fadeIn(500);
        form.fadeIn(500);
    });

    close_button.on('click', function () {
        form.hide(300)
        search_button.parent().removeClass('open');
        close_button.fadeOut(500);
        form.fadeOut(500);
    });
})(jQuery);

