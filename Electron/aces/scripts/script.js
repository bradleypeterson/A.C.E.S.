// Global Variables
db = new Database();

// Start of ExpressJS URL Rounting
// express = require('express');
// app = express();
// app.get('/index.html', (req, res, next) => {
//     console.log('Test');

// });

// app.listen(5000);
// var http = require('http');
// var url = require('url');
// http.createServer(function(req, res){
//     res.writeHead(200, {'Content-Type': 'text/html'});
//     var path = url.parse(request.url).pathname;
//     $('#content-header').load('components/header.html');
//     res.writeHead(404);
//     res.write('Route not defined');
//     res.end();
// }).listen();

// End of Node.js URL Routing

var parameters = {
    view: 'overview',
    page: 'overview',
    content: 'overview'
}

function init(){
    // Get URL Parameters
    var url = window.location.href;
    var urlSections = url.split("?");
    if (urlSections.length == 2){
        var urlParams = urlSections[1].split("&");
        for (var param in urlParams){
            param = urlParams[param].split("=");
            parameters[param[0]] = param[1];
        }
    }

    initElectron();
    loadComponents();
}

function initElectron(){
    try{
      const customTitlebar = require('custom-electron-titlebar');

      let MyTitleBar = new customTitlebar.Titlebar({
          backgroundColor: customTitlebar.Color.fromHex('#333333'),
          icon: null,
          titleHorizontalAlignment: 'left',
          menu: null
      });

      MyTitleBar.updateTitle('A.C.E.S.');
    }
    catch{}
}

function loadComponents(){
    $('#page-nav').load('components/navigation.html');
    $('#content-header').load('components/header.html');
    
    switch (parameters['view']){
        case 'course':
            $('#content-main').load('components/course.html');
            break;
        case 'section':
            break;
        case 'assignment':
            break;
        case 'student':
            break;
        default:
            break;
    }
}

function toggleMenu(){
    if ($("#content-nav").hasClass("hidden")){
        $("#content-nav").animate({
            width: 140,
            paddingLeft: 10,
            paddingRight: 10
        });
        $("#content-main").animate({
            paddingLeft: 200
        });
        $("#content-nav").removeClass("hidden");
    }
    else{
        $("#content-nav").animate({
            width: 0,
            paddingLeft: 0,
            paddingRight: 0
        });
        $("#content-main").animate({
            paddingLeft: 0
        });
        $("#content-nav").addClass("hidden");
    }
}

function coursesNav(){
    $("#page-subnav").load("components/courseNav.html");
    $("#page-subnav").css("display", "block");
    $("#page-subnav").animate({
        width: 200
    });
    // $("body").on("click", function(e){
    //     e.stopPropagation();
    //     closeSubnav();
    // })
}

function sectionsNav(){
    $("#page-subnav").load("components/sectionsNav.html");
    $("#page-subnav").animate({
        width: 200
    },{
        complete: function(){
            $(this).css("display", "block");
        }
    });
}

function closeSubnav(){
    $("#page-subnav").animate({
        width: 0
    },{
        complete: function(){
            $(this).css("display", "none");
        }
    });
    $(document).off("click");
}

function addClass(){
    $("#page-popup").css("display", "block");
    $("#page-popup").load("components/addCourse.html");
}

function addSection(){
    $("#page-popup").css("display", "block");
    $("#page-popup").load("components/addSection.html");
}

function closePopup(){
    $("#page-popup").css("display", "none");
}