   //$(function () {
   //         // Reference the hub.
   //         var hubNotif = $.connection.signalRHub;

   //         // Start the connection.
   //         $.connection.hub.start().done(function () {
   //             console.log('connection done');
   //             getAll();
   //         });

   //         // Notify while anyChanges.
   //         hubNotif.client.updatedData = function () {
   //             console.log('update');
   //             getAll();
   //         };
   //     });

        //setInterval(function () {
        //    console.log('interval');
        //    getAll() ;
        //}, 3000);



        function getAll() {
            var model = $('#dataTable tbody');
            $.ajax({
                url: '/home/index',
                contentType: 'text/json;',
                type: 'GET',
                dataType: 'json'
            })
            .success(function (result) {
                model.empty().append(result);
            })
            .error(function (e) {
                console.log('error:' + e);
            });
        }