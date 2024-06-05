window.addEventListener('scroll', () => {
    let scroll = window.scrollY;

    $('#text').css('margin-top', scroll * 2.0 + 'px');
    $('#leaf').css({
        top : scroll * -1.2 + 'px',
        left : scroll * 1.2 + 'px',
    });

    $('#hill1').css('top', scroll * 0.5 +'px');
    $('#hill2').css('top', scroll * 0.2 +'px');
    $('#hill3').css('top', scroll * 0.3 +'px');
    $('#hill4').css('left', scroll * -1.2 +'px');
    $('#hill5').css('left', scroll * 1.2 +'px');
});