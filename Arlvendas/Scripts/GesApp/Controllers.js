app.controller("GesCtrl", function ($scope, GesService) {
    getAllClientes();
    function getAllClientes() {
        debugger;
        var servCall = GesService.getClientes();
        servCall.then(function (clis) {
            $scope.lstClientes = clis.data;
        }, function (error) {
            alert("ops! algo deu errado");
        });
    };
});