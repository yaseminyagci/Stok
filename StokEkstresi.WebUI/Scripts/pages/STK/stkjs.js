var STKlist = function () {
    var that = this;
    var pageInitObject = [];

    var fillTable = function () {
        var table = $('#tableSTKList');

        if (!jQuery().DataTable) {
            return;
        }

        table.dataTable({
            "searching": false,
            "responsive": false,
            "paging": true,
            "processing": true, // for show progress bar
            "serverSide": true, // for process server side
            "filter": true, // this is for disable filter (search box)
            "orderMulti": false, // for disable multiple column at once
            "pageLength": 10,
            buttons: {
                buttons: [
                   {
                       text: "New Record",
                       action: function (e, dt, node, config) {
                           window.location.href = $("#hoteldefinitionAddUrl").val();
                       }
                   }
                ],
                dom: {
                    button: {
                        tag: "button",
                        className: "btn btn-default dt-AddButton"
                    },
                    buttonLiner: {
                        tag: null
                    }
                }
            },
            "dom": "<'row' <'col-md-12'B>><'row'<'col-md-6 col-sm-12'l><'col-md-6 col-sm-12'f>r><'table-scrollable't><'row'<'col-md-5 col-sm-12'i><'col-md-7 col-sm-12'p>>",
            "ajax": {
                "url": that.pageInitObject.urls.gridLoadUrl,
                "contentType": "application/json",
                "datatype": "json",
                "type": "POST",
                "data": function (data) {
                    var req = Core.createModel();
                    data.FilterRequest = req;

                    var request = {
                        model: data
                    };
                    return JSON.stringify(request);
                },
                "dataFilter": function (data) {
                    return data;
                    // var json = JSON.stringify jQuery.parseJSON(data);
                    // return json.data;
                }
            },
            "columns": [
                { "data": "SiraNo", "name": "SiraNo", "bSortable": false, "sWidth": "0" },
                { "data": "IslemTur", "name": "Name", "bSortable": false, "Width": "10" },
                { "data": "EvrakNo", "name": "Title", "bSortable": false, "Width": "10" },
                { "data": "Tarih", "name": "HotelUrl", "bSortable": false, "Width": "10" },
                { "data": "GirisMiktar", "name": "HotelType", "bSortable": true, "Width": "10" },
                { "data": "CikisMiktar", "name": "IsActive", "bSortable": true, "Width": "5" },
    

            ],
            "columnDefs": [
                {
                    "targets": [0],
                    "searchable": false
                },
                {
                    "targets": [1, 5],
                    "class": "text-center"
                },
              

            ]
        });
    };

    var refreshTable = function () {
        var oTable = $('#tableSTKList').DataTable();
        oTable.ajax.reload();
    }

    var handleStartup = function () {
        $('.box.box-default').boxWidget('toggle');
    };

    var handleEvents = function () {
         $(document).on('click', '.btnClear', function () {
            Core.clearForm();
            refreshTable();
            // $('#tableHotelTypeList').DataTable().rows('.selected').deselect();
        });

        $(document).on('click', '.btnSearch', function () {
            refreshTable();
        });
    };

    return {
        init: function (initObject) {
            // diğer js 'ler de url'leri direk nesne olarak göndermiştik. Model gibi düşünebilirsiniz.
            // Burada ise Array objeler halinde gönderildi.
            // List veya array gibi düşünülebilir.
            // ChromeDev Console üzerinden değişkeni çağırıp inceleyiniz.
            that.pageInitObject = initObject;

            if (!jQuery().dataTable) {
                return;
            }
            fillTable();
            handleEvents();
            handleStartup();
        }
    };
}();