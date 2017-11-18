$(function() {
    var self = {}
    self.flightTable = new FlightTable();

    self.init = function() {
        self.initInputs();
        self.initEvents();
    }

    self.initEvents = function() {
        $(document).on("click", "#search_btn", self.search);
    }

    self.search = function() {
        $.ajax({
            type: "POST",
            url: "/Home/FlightSearch"
        }).done(function(data) {
            console.log(data);
            self.flightTable.reloadTable(data);
        });
    }

    self.initInputs = function() {
        $("#date_of_travel").datepicker({
            orientation: "bottom"
        });

        $("#select_from, #select_to").select2({
            width: "100%"
        });
    }

    self.init();
})