﻿app.controller("GesCtrl", function ($scope, GesService) {
    $scope.Produtos = [{}];
    getAllMecanicos();
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
    function getAllMecanicos() {
        debugger;
        var servCall = GesService.getMecanicos();
        servCall.then(function (mecs) {
            $scope.lstMecanicos = mecs.data;
        }, function (error) {
            alert("Ops! Não foi possivel buscas os mecanicos");
        });
    };

    $scope.addProduto = function () {
        $scope.Produtos.push(
        {
            DESCPROD: $scope.prod.descProd,
            VALUNPROD: $scope.prod.valorProd,
            UNIDMEDIDAPROD: $scope.prod.unidProd,
            QTD: $scope.prod.qtdProd
        });
        console.log($scope.Produtos);
    };
});