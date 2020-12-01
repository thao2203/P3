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
}).filter("filterdate", function () {
    var re = /\/Date\(([0-9]*)\)\//;
    return function (x) {
        var m = x.match(re);
        if (m) return new Date(parseInt(m[1]));
        else return null;
    };
});
