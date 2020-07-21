﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

function Select(element, singleSelect) {
    if (element.classList.contains('selected'))
        return;
    if (singleSelect) {
        var selected = document.getElementsByClassName('selected')
        console.log(selected);
        for (var i = 0; i < selected.length; i++) {
            console.log(selected[i]);
            selected[i].classList.remove('selected');
        }
    }
    element.classList.add('selected');
}

function ToggleMenu() {
    var nav = $('#app-nav');
    if (nav.is(":hidden")) {
        $('#app-header').animate({ marginLeft: 210 });
        if ($(window).outerWidth() >= 900) {
            $('#app-main').animate({ marginLeft: 210 });
        }
    }
    else {
        $('#app-header').animate({ marginLeft: 10 });
        if ($(window).outerWidth() >= 900) {
            $('#app-main').animate({ marginLeft: 10 });
        }
    }
    $('#app-nav').animate({ width: 'toggle' });
}

function ShowMenu() {
    $('#app-header').css('margin-left', 210);
    $('#app-main').css('margin-left', 200);
    $('#app-nav').show();
}

function HideMenu() {
    $('#app-header').css('margin-left', 10);
    $('#app-main').css('margin-left', 0);
    $('#app-nav').hide();
}

function GetData(table, id, success, fail) {
    $.ajax({
        type: "GET",
        url: `/API/${table}/Get`,
        data: {
            id: id
        },
        contentType: "application/json",
        dataType: "json"
    }).done(success).fail(fail);
}

function ArchiveData(table, id, archive, success, fail) {
    $.ajax({
        type: 'get',
        url: `/api/${table}/archive`,
        data: {
            id: id,
            archive: archive
        },
        contenttype: "application/json",
        datatype: "json"
    }).done(success).fail(fail);
}

$(document).ready(function () {
    //$('.accordion-header').click(function () {
    //    $(this).next().slideToggle();
    //    $(this).toggleClass('expanded');
    //});
    $(window).resize(function () {
        if ($(window).outerWidth() < 900) {
            HideMenu()
        }
        else {
            ShowMenu()
        }
    });
});


