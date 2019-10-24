// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {
    $(document).on('keydown', function (e) {
        console.log(e.keyCode);
        switch (e.keyCode) {
            case 37:
                console.log('left');
                var prev = $('#prev').val();
                window.location.href = prev;
                break;
            case 39:
                console.log('right');
                var next = $('#next').val();
                window.location.href = next;
                break;
        }

    });
});