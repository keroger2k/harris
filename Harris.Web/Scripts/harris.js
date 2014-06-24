var Harris = window.Harris || {};

Harris.updateCapabilities = function (item) {
    var $matrixContainer = $('#matrix-result-container');
    $matrixContainer.html('');
    var xhr = $.ajax({
        type: 'POST',
        url: '/home/UpdateCapabilitiesMatrix',
        contentType: 'application/json',
        data: JSON.stringify({ item: item }),
        success: function (data) {
            $.each(data, function (id, matrix) {
                var template = $('#matrix-result-template').html();
                var matrixData = Mustache.render(template, matrix);
                $matrixContainer.append(matrixData);
            });
        }
    });
};


$(function () {
    var $capabilities = $("input.capability[type='checkbox']");
    $capabilities.on('change', function (e) {
        var list = [];
        $capabilities.each(function (i, e) {
            var $e = $(e);
            if ($e.prop('checked')) {
                list.push({ Id: $e.data('id'), Name: "NA" });
            }
        });

        Harris.updateCapabilities(list);
    });
});