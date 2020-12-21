var app = angular.module("AdminApp", []);
app.controller("DanhSachBVController", function ($scope, $http) {
    $scope.maxsize = 5;

    $scope.totalcount = 0;

    $scope.pageIndex = 1;

    $scope.pageSize = 5;

    $scope.searchText = '';
    //----------------------------------------------------------------------------------------------------------------
    $scope.BVLisst = function () {

        $http.get("/QLBaiViet/Get_data_BV?pageindex=" + $scope.pageIndex + "&pagesize=" + $scope.pageSize).then(function (response) {

            $scope.listbv = response.data.listBaiViet;
            $scope.totalcount = response.data.totalcount;

        }, function (error) {
            alert('failed');
        });
    }
    $scope.BVLisst();
    $scope.pagechanged = function () {

        $scope.BVLisst();

    }
    $scope.changePageSize = function () {
        $scope.pageIndex = 1;
        $scope.BVLisst();
    }
    //----------------------------------------------------------------------------------------------------------------

    $scope.Xoasp = function (id) {
        $http.get("/QLBaiViet/Xoa_ruouvang?id=" + id).then(function (d) {
            alert(d.data);
            $http.get("/QLBaiViet/Get_data_BV?pageindex=" + $scope.pageIndex + "&pagesize=" + $scope.pageSize).then(function (response) {

                $scope.listbv = response.data.listBaiViet;

                $scope.totalcount = response.data.totalcount;

            }, function (error) {
                alert('failed');
            });
        }, function (error) {
            alert('Failed');
        });
    };
}).filter("filterdate", function () {
    var re = /\/Date\(([0-9]*)\)\//;
    return function (x) {
        var m = x.match(re);
        if (m) return new Date(parseInt(m[1]));
        else return null;
    };
});

