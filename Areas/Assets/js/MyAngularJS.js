﻿var app = angular.module("AdminApp", []);
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
        $http.get("/QLBaiViet/Xoa_BV?id=" + id).then(function (d) {
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

//----------------------------------------Thêm loại san pham------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------------------------
app.controller("ThemBVController", function ($scope, $http) {

    $scope.thembv = function () {
        var object = {
            "dt.MaBV": $scope.MaBV,
            "dt.MaDM": $scope.MaDM,
            "dt.MaDMC": $scope.MaDMC,
            "dt.TaiKhoanUS": $scope.TaiKhoanUS,
            "dt.TieuDe": $scope.TieuDe,
            "dt.TrangThai": $scope.TrangThai,
            "dt.ThoiGianDang": $scope.ThoiGianDang,
            "dt.HinhAnh": $scope.HinhAnh,
        }
        $http({
            method: 'POST',
            url: '/QLBaiViet/Them_BV',
            data: object
        }).then(function (d) {
            window.location.href = '/QLBaiViet/DanhSachBV';
        }, function (e) {
            alert('failed');
        });

    }
    $http.get('/QLBaiViet/Get_MaDM').then(function (d) {
        $scope.listmaDM = d.data;
    }, function (error) {
        alert('failed');
    })
    $http.get('/QLBaiViet/Get_MaDMC').then(function (d) {
        $scope.listmaDMC = d.data;
    }, function (error) {
        alert('failed');
    })
    $http.get('/QLBaiViet/Get_US').then(function (d) {
        $scope.listUS = d.data;
    }, function (error) {
        alert('failed');
    })
});

app.controller("SuaBVController", function ($scope, $http, $location) {

    var MaBV = $location.search().id
    $http({
        method: 'get',
        url: '/QLBaiViet/Get_BV_byid?id=' + MaBV,

    }).then(function (jsonResults) {
        $scope.bv = jsonResults.data[0];
        console.log(jsonResults.data)
    })
    $scope.suabv = function () {
        $http({
            method: 'POST',
            url: '/QLBaiViet/Sua_BV',
            data: $scope.bv
        }).then(function (d) {
            alert(d.data);
            window.location.href = '/QLBaiViet/DanhSachBV';
        }, function (e) {
            alert('failed');
        });
    };
});