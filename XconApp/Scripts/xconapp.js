var XCON =
(($) => {

    var xcon = {
        showLoading: () => {
            $("#main-loading").modal("show");
        },

        hideLoading: () => {
            $("#main-loading").modal("hide");
        }
    };

    return xcon;

})(jQuery);
