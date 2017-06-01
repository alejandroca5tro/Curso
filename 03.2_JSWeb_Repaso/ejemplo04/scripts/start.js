$(function() {
    var box = $('div#animated');
    box.animate({ left: '500px' }, 500).animate({ top: '500px' }, 1000);
    box.animate({ left: '50px' });
    box.animate({ top: '50px' });
    box.animate({ left: '-200px', top: '-200px', height: '10000px', width: '10000px' }, "slow");
});




// text.animate({ show }, "slow");
// var text = $('p.animated');
// text.animate({ hide });

// $(function() {
//     $('div#animated').animate({ left: '500px' }, 500);
//     $('div#animated').animate({ top: '500px' });
//     $('div#animated').animate({ left: '50px' });
//     $('div#animated').animate({ top: '50px' });
//     $('div#animated').animate({ left: '-200px', top: '-200px', height: '10000px', width: '10000px' }, "slow");
// });