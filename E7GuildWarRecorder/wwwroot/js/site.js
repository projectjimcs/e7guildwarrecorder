// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const url = window.location.pathname;

$('.navbar-nav li a').each(function () {
    if (url.includes($(this).data('pageReference'))) {
        $(this).parent().addClass('active');
        $(this).removeClass('text-dark').addClass('text-light');

    } else if (url === '/') { // !!! This looks kinda iffy, probably changing it...
        $('.navbar-nav li a[data-page-reference="Dashboard"]').parent().addClass('active');
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