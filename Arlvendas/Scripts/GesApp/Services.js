app.service("GesService", function ($http) {
    this.getClientes = function () {
        debugger;
        var url = "/Clientes/getAllClientes";
        return $http.get(url);
    };
    this.getMecanicos = function () {
        debugger;
        var url = "/Mecanicos/getAllMecanicos";
        return $http.get(url);
    }
});