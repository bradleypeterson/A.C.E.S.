// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

function Select(element, singleSelect) {
    if (element.classList.contains("selected"))
        return;
    if (singleSelect) {
        var selected = document.getElementsByClassName("selected")
        console.log(selected);
        for (var i = 0; i < selected.length; i++) {
            console.log(selected[i]);
            selected[i].classList.remove("selected");
        }
    }
    element.classList.add("selected");
}

$(document).ready(function () {
    $('.accordion-content').hide();
    $(".accordion-header").click(function () {
        $(this).next().slideToggle();
        $(this).toggleClass('expanded');
        //$(this).next().slideToggle(function () {
        //    if ($(this).is(':visible'))
        //        $(this).css('display', 'flex');
        //});
    });
});