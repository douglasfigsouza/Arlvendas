app.service("GesService", function ($http) {
    this.getClientes = function () {
        debugger;
        return $http.get("/Clientes/getAllClientes");
    };
});