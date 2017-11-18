$(function () {
    var self = {}
    self.activeAjaxConnections = 0;

    $(document).ajaxStop(function () {
        self.activeAjaxConnections = 0;
        mApp.unblockPage();
        //console.clear();
    });

    //check internet connection
    $(document).ajaxSend(function (event, jqxhr, settings) {
        self.activeAjaxConnections++;
        mApp.blockPage({ overlayColor: "#000000", type: "loader", state: "success", message: "Please wait..." });
        //$.ajax({
        //    type: "POST",
        //    url: "/Settings/CheckInternetConnection",
        //    global: false
        //}).done(function (json) {

        //}).fail(function (jqXHR, exception) {
        //    // Our error logic here
        //    var msg = '';
        //    if (jqXHR.status === 0) {
        //        msg = 'Not connect.\n Verify Network.';
        //    } else if (jqXHR.status == 404) {
        //        msg = 'Requested page not found. [404]';
        //    } else if (jqXHR.status == 500) {
        //        msg = 'Internal Server Error [500].';
        //    } else if (exception === 'parsererror') {
        //        msg = 'Requested JSON parse failed.';
        //    } else if (exception === 'timeout') {
        //        msg = 'Time out error.';
        //    } else if (exception === 'abort') {
        //        msg = 'Ajax request aborted.';
        //    } else {
        //        msg = 'Uncaught Error.\n' + jqXHR.responseText;
        //    }
        //    jqxhr.abort();
        //    Lobibox.notify('error', {
        //        position: 'center top',
        //        msg: msg
        //    });
        //}).always(function () {
        //});
    });
});