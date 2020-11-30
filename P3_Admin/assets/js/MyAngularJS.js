var app = angular.module("MyAdminApp", []);
//console.clear();
app.controller("dsBaiVietPost", function ($scope, $http) {

    $http({
        method: 'get',
        url: '/Admin/getdanhsachbaiviet'
    }).then(function successCallback(res) {

        $scope.listDsBV = res.data;//lưu dữ liệu vào biến $scope.listbaivietmoinhat 
        console.log($scope.listDsBV);

    })
});