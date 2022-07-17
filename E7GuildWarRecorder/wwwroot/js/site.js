// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$.fn.pageMe = function (opts) {
    $this = this;

    defaults = {
        perPage: 10,
        showPrevNext: false,
        hidePageNumbers: false
    },
    settings = $.extend(defaults, opts);

    const listElement = $this;
    const perPage = settings.perPage;
    const children = listElement.children();
    let pager = $('.pager');

    if (typeof settings.childSelector != 'undefined') {
        children = listElement.find(settings.childSelector);
    }

    if (typeof settings.pagerSelector != 'undefined') {
        pager = $(settings.pagerSelector);
    }

    const numItems = children.length;
    const numPages = Math.ceil(numItems / perPage);

    pager.attr('data-curr', 0);

    if (settings.showPrevNext) {
        $('<li><a href="#" class="prev-link page-link">«</a></li>').appendTo(pager);
    }

    let curr = 0;
    while (numPages > curr && (settings.hidePageNumbers == false)) {
        $('<li id="pg' + (curr + 1) + '" class="pg page-item"><a href="#" class="page-link single-page-link">' + (curr + 1) + '</a></li>').appendTo(pager);
        curr++;
    }

    if (settings.showPrevNext) {
        $('<li><a href="#" class="next-link page-link">»</a></li>').appendTo(pager);
    }

    pager.find('.single-page-link:first').addClass('active');
    pager.find('.prev-link').hide();
    if (numPages <= 1) {
        pager.find('.next-link').hide();
    }
    pager.children().eq(1).addClass("active");

    children.hide();
    children.slice(0, perPage).show();
    if (numPages > 3) {
        $('.pg').hide();
        $('#pg1,#pg2,#pg3').show();
        $("#pg3").after($("<li class='ell'>").html("<span>...</span>"));
    }

    pager.find('li .single-page-link').click(function () {
        const clickedPage = $(this).html().valueOf() - 1;
        goTo(clickedPage, perPage);
        return false;
    });
    pager.find('li .prev-link').click(function () {
        previous();
        return false;
    });
    pager.find('li .next-link').click(function () {
        next();
        return false;
    });

    function previous() {
        let goToPage = parseInt(pager.attr('data-curr')) - 1;

        if (goToPage < 0) {
            goToPage = 0;
        }

        goTo(goToPage);
    }

    function next() {
        const goToPage = parseInt(pager.attr('data-curr')) + 1;

        goTo(goToPage);
    }

    function goTo(page) {
        var startAt = page * perPage,
            endOn = startAt + perPage;

        $('.pg').hide();
        $(".ell").remove();
        var prevpg = $("#pg" + page).show();
        var currpg = $("#pg" + (page + 1)).show();
        var nextpg = $("#pg" + (page + 2)).show();
        if (prevpg.length == 0) nextpg = $("#pg" + (page + 3)).show();
        if (prevpg.length == 1 && nextpg.length == 0) {
            prevpg = $("#pg" + (page - 1)).show();
        }
        $("#pg1").show()
        if (curr > 3) {
            if (page > 1) prevpg.before($("<li class='ell'>").html("<span>...</span>"));
            if (page < curr - 2) nextpg.after($("<li class='ell'>").html("<span>...</span>"));
        }

        if (page <= numPages - 3) {
            $("#pg" + numPages.toString()).show();
        }
        currpg.addClass("active").siblings().removeClass("active");

        children.css('display', 'none').slice(startAt, endOn).show();

        if (page >= 1) {
            pager.find('.prev-link').show();
        } else {
            pager.find('.prev-link').hide();
        }

        if (page < (numPages - 1)) {
            pager.find('.next-link').show();
        } else {
            pager.find('.next-link').hide();
        }

        pager.attr('data-curr', page);
    }
};

const url = window.location.pathname;

$(document).ready(function () {
    $('.navbar-nav li a').each(function () {
        if (url.includes($(this).data('pageReference'))) {
            $(this).parent().addClass('active-nav');
            $(this).removeClass('text-dark').addClass('text-light');

        } else if (url === '/') { // !!! This looks kinda iffy, probably changing it...
            $('.navbar-nav li a[data-page-reference="Dashboard"]').parent().addClass('active-nav');
            $('.navbar-nav li a[data-page-reference="Dashboard"]').removeClass('text-dark').addClass('text-light');
        }
    });

    $('#add-edit-submit').on('click', function (e) {
        e.preventDefault();

        if (isValidEntry()) {
            $('#add-edit-form').submit();
        } else {
            $('#validation-modal').modal('show');
        }
    });

    function isValidEntry() {
        const defense1Id = $('#defense1Id').val();
        const defense2Id = $('#defense2Id').val();
        const defense3Id = $('#defense3Id').val();

        const offense1Id = $('#offense1Id').val();
        const offense2Id = $('#offense2Id').val();
        const offense3Id = $('#offense3Id').val();

        if (
            (!defense1Id && !defense2Id && !defense3Id)
            || (!offense1Id && !offense2Id && !offense3Id)
        ) {
            return false;
        }

        return true;
    }

    $('#matchTable').pageMe({
        pagerSelector: '#matchPagination',
        showPrevNext: true,
        hidePageNumbers: false,
        perPage: 5
    });
});