// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Po załadowaniu strony
$(document).ready(function () {
    // Po najechaniu na area
    $('area').mouseover(function () {
        $(this).addClass('highlighted');
    });

    // Po opuszczeniu area
    $('area').mouseout(function () {
        $(this).removeClass('highlighted');
    });
});

