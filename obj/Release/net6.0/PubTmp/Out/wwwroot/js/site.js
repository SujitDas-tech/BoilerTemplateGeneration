
$(function () {

    var placeholderElement = $('#Placeholder');
    $('button[data-toggle="ajax-modal"]').click(function (event) {
        var url = $(this).data('url');
        $.get(url).done(function (data) {

            placeholderElement.html(data);
            placeholderElement.find('.modal').modal('show');
        })



    })

    placeholderElement.on('click', '[data-dismiss="modal"]', function (event) {
        /* var form = $(this).parents('.modal').find('form');
         var actionUrl = form.attr('action');
         var sendData = form.serialize();
         $.post(actionUrl, sendData).done(function(data){*/
        placeholderElement.find('.modal').modal('hide');
        // })

    })

});



$(function () {
    var placeholderElement = $('#SelectFields');
    $('button[data-toggle="ajax-modal-1"]').click(function (event) {
        var url = $(this).data('url');
        $.get(url).done(function (data) {

            placeholderElement.html(data);
            placeholderElement.find('.modal').modal('show');
        })



    })

    placeholderElement.on('click', '[data-dismiss="modal"]', function (event) {
        /* var form = $(this).parents('.modal').find('form');
         var actionUrl = form.attr('action');
         var sendData = form.serialize();
         $.post(actionUrl, sendData).done(function(data){*/
        placeholderElement.find('.modal').modal('hide');
    })
});


function retainfunction() {
    $('body').removeClass('preload')
    $('#loading').removeClass('loader-wrapper');
    $('#loading1').removeClass('loader');
    $('#loading2').removeClass('loader-inner');
}

const mobileScreen = window.matchMedia("(max-width: 990px )");
$(document).ready(function () {
    $(".dashboard-nav-dropdown-toggle").click(function () {
        $(this).closest(".dashboard-nav-dropdown")
            .toggleClass("show")
            .find(".dashboard-nav-dropdown")
            .removeClass("show");
        $(this).parent()
            .siblings()
            .removeClass("show");
    });
    $(".menu-toggle").click(function () {
        if (mobileScreen.matches) {
            $(".dashboard-nav").toggleClass("mobile-show");
        } else {
            $(".dashboard").toggleClass("dashboard-compact");
        }
    });
});