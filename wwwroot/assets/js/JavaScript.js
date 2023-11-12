$(document).ready(function () {
    let page = window.location.pathname.split('/')[1];
})

if (page === '') {
    $('#Home').AddClass('active');
}

else {
    $('#' + page).AddClass('active');
}