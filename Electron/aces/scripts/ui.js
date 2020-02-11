function toggleMenu(){
    if ($("#content-nav").hasClass("hidden")){
        $("#content-nav").animate({
            width: 200
        })
        $("#content-main").animate({
            paddingLeft: 200
        })
        $("#content-nav").removeClass("hidden");
    }
    else{
        $("#content-nav").animate({
            width: 0
        })
        $("#content-main").animate({
            paddingLeft: 0
        })
        $("#content-nav").addClass("hidden");
    }

    closeSubnav();
}

function coursesNav(){
    $("#page-subnav").load("components/courseNav.html");
    $("#page-subnav").css("display", "block");
    $("#page-subnav").animate({
        width: 200
    })
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
            $(this).css("display", "block")
        }
    })
}

function closeSubnav(){
    $("#page-subnav").animate({
        width: 0
    },{
        complete: function(){
            $(this).css("display", "none")
        }
    })
    $(document).off("click");
}

function addClass(){
    $("#page-popup").load("components/addCourse.html");
}