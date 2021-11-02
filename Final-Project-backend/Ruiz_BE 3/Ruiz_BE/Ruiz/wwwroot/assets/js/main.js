(function ($) {
    "use strict";


    var windows = $(window);
    var sticky = $('.header-sticky');

    windows.on('scroll', function() {
        var scroll = windows.scrollTop();
        if (scroll < 300) {
            sticky.removeClass('is-sticky');
        }else{
            sticky.addClass('is-sticky');
        }
    });
    
    $(".off-canvas-btn").on('click', function () {
        $("body").addClass('fix');
        $(".off-canvas-wrapper").addClass('open');
    });

    $(".btn-close-off-canvas,.off-canvas-overlay").on('click', function () {
        $("body").removeClass('fix');
        $(".off-canvas-wrapper").removeClass('open');
    });
    
    
	$('[data-countdown]').each(function () {
		var $this = $(this),
			finalDate = $(this).data('countdown');
		$this.countdown(finalDate, function (event) {
			$this.html(event.strftime('<div class="single-countdown"><span class="single-countdown__time">%D</span><span class="single-countdown__text">Days</span></div><div class="single-countdown"><span class="single-countdown__time">%H</span><span class="single-countdown__text">Hours</span></div><div class="single-countdown"><span class="single-countdown__time">%M</span><span class="single-countdown__text">Mins</span></div><div class="single-countdown"><span class="single-countdown__time">%S</span><span class="single-countdown__text">Secs</span></div>'));
		});
	});
    
    
    
    $(".categories_title").on("click", function() {
        $(this).toggleClass('active');
        $('.categories_menu_toggle').slideToggle('medium');
    }); 
 
    $('.categories-more-less').on('click', function(){
        $('.hide-child').slideToggle();
        $(this).toggleClass('rx-change');
    });	
    
    function categorySubMenuToggle(){
        $('.categories_menu_toggle li.menu_item_children > a').on('click', function(){
        if($(window).width() < 991){
            $(this).removeAttr('href');
            var element = $(this).parent('li');
            if (element.hasClass('open')) {
                element.removeClass('open');
                element.find('li').removeClass('open');
                element.find('ul').slideUp();
            }
            else {
                element.addClass('open');
                element.children('ul').slideDown();
                element.siblings('li').children('ul').slideUp();
                element.siblings('li').removeClass('open');
                element.siblings('li').find('li').removeClass('open');
                element.siblings('li').find('ul').slideUp();
            }
        }
        });
        $('.categories_menu_toggle li.menu_item_children > a').append('<span class="expand"></span>');
    }
    categorySubMenuToggle();
    

	var $offCanvasNav = $('.mobile-menu'),
		$offCanvasNavSubMenu = $offCanvasNav.find('.dropdown');

	$offCanvasNavSubMenu.parent().prepend('<span class="menu-expand"><i></i></span>');

	$offCanvasNavSubMenu.slideUp();

	$offCanvasNav.on('click', 'li a, li .menu-expand', function(e) {
        var $this = $(this);
        if ( ($this.parent().attr('class').match(/\b(menu-item-has-children|has-children|has-sub-menu)\b/)) && ($this.attr('href') === '#' || $this.hasClass('menu-expand')) ) {
            e.preventDefault();
            if ($this.siblings('ul:visible').length){
                $this.parent('li').removeClass('active');
                $this.siblings('ul').slideUp();
            } else {
                $this.parent('li').addClass('active');
                $this.closest('li').siblings('li').removeClass('active').find('li').removeClass('active');
                $this.closest('li').siblings('li').find('ul:visible').slideUp();
                $this.siblings('ul').slideDown();
            }
        }
    });
    


var heroSlider = $('.hero-slider-one');
heroSlider.slick({
    arrows: true,
    autoplay: false,
    autoplaySpeed: 5000,
    dots: false,
    pauseOnFocus: false,
    pauseOnHover: false,
    fade: true,
    infinite: true,
    slidesToShow: 1,
    prevArrow: '<button type="button" class="slick-prev"> <i class="fa fa-angle-left"> </i></button>',
    nextArrow: '<button type="button" class="slick-next"><i class="fa fa-angle-right"> </i></button>',
    responsive: [
        {
          breakpoint: 767,
          settings: {
            dots: false,
          }
        }
    ]
});

    
var product_4 = $('.product-active-lg-4');
product_4.slick({
    dots: false,
    infinite: true,
    slidesToShow: 4,
    slidesToScroll: 1,
    autoplay: false,
    prevArrow: '<button type="button" class="slick-prev"> <i class="fa fa-angle-left"> </i></button>',
    nextArrow: '<button type="button" class="slick-next"><i class="fa fa-angle-right"> </i></button>',
    responsive: [
        {
            breakpoint: 1199,
            settings: {
                slidesToShow: 3,
            }
        },
        {
            breakpoint: 991,
            settings: {
                slidesToShow: 2,
            }
        },
        {
            breakpoint: 767,
            settings: {
                slidesToShow: 2,
            }
        },
        {
            breakpoint: 480,
            settings: {
                slidesToShow: 2,
            }
        },
        {
            breakpoint: 479,
            settings: {
                slidesToShow: 1,
            }
        }
    ]
});

var product_row_4 = $('.product-active-row-4');
product_row_4.slick({
    dots: false,
    infinite: true,
    slidesToShow: 5,
    slidesToScroll: 1,
    rows: 2,
    autoplay: false,
    prevArrow: '<button type="button" class="slick-prev"> <i class="fa fa-angle-left"> </i></button>',
    nextArrow: '<button type="button" class="slick-next"><i class="fa fa-angle-right"> </i></button>',
    responsive: [
        {
            breakpoint: 1199,
            settings: {
                slidesToShow: 3,
            }
        },
        {
            breakpoint: 991,
            settings: {
                slidesToShow: 2,
            }
        },
        {
            breakpoint: 767,
            settings: {
                slidesToShow: 2,
            }
        },
        {
            breakpoint: 480,
            settings: {
                slidesToShow: 2,
            }
        },
        {
            breakpoint: 479,
            settings: {
                slidesToShow: 1,
            }
        }
    ]
});  
    
    
var brandActive = $('.our-brand-active');
brandActive.slick({
    dots: false,
    infinite: true,
    slidesToShow: 5,
    slidesToScroll: 1,
    autoplay: false,
    prevArrow: false,
    nextArrow: false,
    responsive: [
        {
            breakpoint: 991,
            settings: {
                slidesToShow: 4,
            }
        },
        {
            breakpoint: 767,
            settings: {
                slidesToShow: 2,
            }
        },
        {
            breakpoint: 480,
            settings: {
                slidesToShow: 1,
            }
        },
        {
            breakpoint: 479,
            settings: {
                slidesToShow: 1,
            }
        }
    ]
});

var testimonialSliderTwo = $('.testimonial-two');
testimonialSliderTwo.slick({
    arrows: false,
    autoplay: true,
    autoplaySpeed: 7000,
    dots: false,
    pauseOnFocus: false,
    pauseOnHover: false,
    infinite: true,
    slidesToShow: 2,
    slidesToScoll: 1,
    prevArrow: false,
    nextArrow: false,
});

$('.watch-color li').on('click', function () {
    $(this).addClass('checked').siblings().removeClass('checked');
});

$('[data-countdown]').each(function() {
	var $this = $(this), finalDate = $(this).data('countdown');
	$this.countdown(finalDate, function(event) {
		$this.html(event.strftime('<span class="cdown day"><span class="time-count">%-D</span> <p>Days</p></span> <span class="cdown hour"><span class="time-count">%-H</span> <p>Hours</p></span> <span class="cdown minutes"><span class="time-count">%M</span> <p>mins</p></span> <span class="cdown second"><span class="time-count">%S</span> <p>secs</p></span>'));
	});
}); 
         
$( "#price-slider" ).slider({
   range: true,
   min: 0,
   max: 120,
   values: [ 20, 115 ],
   slide: function( event, ui ) {
        $( "#min-price" ).val('$' + ui.values[ 0 ] );
        $( "#max-price" ).val('$' + ui.values[ 1 ] );
     }
  });
  $( "#min-price" ).val('$' + $( "#price-slider" ).slider( "values", 0 ));   
  $( "#max-price" ).val('$' + $( "#price-slider" ).slider( "values", 1 )); 


    $('.category-sub-menu li.has-sub > a').on('click', function () {
        $(this).removeAttr('href');
        var element = $(this).parent('li');
        if (element.hasClass('open')) {
            element.removeClass('open');
            element.find('li').removeClass('open');
            element.find('ul').slideUp();
        } else {
            element.addClass('open');
            element.children('ul').slideDown();
            element.siblings('li').children('ul').slideUp();
            element.siblings('li').removeClass('open');
            element.siblings('li').find('li').removeClass('open');
            element.siblings('li').find('ul').slideUp();
        }
    }); 


$('.product-large-slider').slick({
    fade: true,
    arrows: false,
    asNavFor: '.product-nav'
});


$('.product-nav').slick({
    slidesToShow: 4,
    asNavFor: '.product-large-slider',
    centerMode: true,
    centerPadding: 0,
    focusOnSelect: true,
    prevArrow: '<button type="button" class="slick-prev"><i class="fa fa-angle-left"></i></button>',
    nextArrow: '<button type="button" class="slick-next"><i class="fa fa-angle-right"></i></button>',
    responsive: [{
        breakpoint: 576,
        settings: {
            slidesToShow: 3,
        }
    }]
});

    
$('.nice-select').niceSelect ();

$('.img-zoom').zoom();
    
$('[data-fancybox="images"]').fancybox({
    hash: false,
});
    

$( '#showlogin' ).on('click', function() {
    $('#checkout-login' ).slideToggle(500);
}); 
    
$( '#showcoupon' ).on('click', function() {
    $('#checkout-coupon' ).slideToggle(500);
});
    
$("#chekout-box").on("change",function(){
    $(".account-create").slideToggle("100");
});
    
$("#chekout-box-2").on("change",function(){
    $(".ship-box-info").slideToggle("100");
});        
    
     
$.scrollUp({
    scrollText: '<i class="fa fa-angle-up"></i>',
    easingType: 'linear',
    scrollSpeed: 900,
    animation: 'fade'
});    
    
    
    
    
    
    
})(jQuery);

