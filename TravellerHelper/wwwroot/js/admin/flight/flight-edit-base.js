$(function () {
    var self = {}

    self.init = function () {
        self.initInputs();
    }

    self.initInputs = function () {
        $("#time_from_box input, #time_to_box input").datetimepicker({
            todayHighlight: !0,
            autoclose: !0,
            pickerPosition: "bottom-left",
            format: "dd/mm/yyyy hh:ii"
        });


        $("#place_from_box select, #place_to_box select").select2({
            width: "100%"
        });

        $("#seats_limit_box input").inputmask({ mask: "99", placeholder: "" });

        $("#price_box input").inputmask({ mask: "9999", placeholder: "" });
    }
    self.init();
})