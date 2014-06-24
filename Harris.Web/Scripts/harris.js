var Harris = window.Harris || {};

$(function () {
    var $capabilities = $("input.capability[type='checkbox']");
    $capabilities.on('change', function (e) {
        var list = [];
        $capabilities.each(function (i, e) {
            var $e = $(e);
            list.push({ id: $e.data('id'), checked: $e.prop('checked') });
        });
    });
});