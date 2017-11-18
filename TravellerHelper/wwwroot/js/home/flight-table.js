function FlightTable() {
    var self = {}
    self.parentContainerSelector = "#flight_table_container";

    self.init = function() {
        self.initTable();
    }

    self.reloadTable = function(data) {
        self.table.clear().draw();
        self.table.rows.add(data);
        self.table.columns.adjust().draw();
    }

    self.initTable = function () {
        self.table = $(self.parentContainerSelector + ' table').DataTable({
            columns: [
                {
                    data: null,
                    render: function (data) {
                        return data.TimeFrom;
                    }
                },
                {
                    data: null,
                    render: function (data) {
                        return data.TimeTo;
                    }
                },
                {
                    data: null,
                    render: function (data) {
                        return data.AvailableSeats;
                    }
                },
                {
                    data: null,
                    render: function (data) {
                        return data.Price;
                    }
                },
                {
                    data: null,
                    render: function (data) {
                        return `Action`;
                    }
                }
            ]
        });
    }

    self.init();

    return self;
}