var app = angular.module('Homeapp', []);
app.controller('ThongKeController', function ($scope, $http) {
    $http({
        method: 'get',
        url: '/ThongKe/getThongKe',

    }).then(function successCallback(res) {

        $scope.ThongKe = res.data[0];
        console.log($scope.ThongKe)

    }, function (error) {

        alert('failed');

    });
});
//app.controller('GetAllThongTinController', function ($scope, $http) {
//    $http.get('/ThongTin/getAllRecord').then(function (d) {

//        $scope.ThongTin = d.data;
//        console.log($scope.ThongTin)
//    }, function (error) {

//        alert('failed');

//    });
//})
//app.controller('info_userController', function ($scope, $http) {
//    $scope.UserName = localStorage.getItem('taikhoan');
//    $scope.logout = function () {

//        localStorage.clear();
//        window.location.href = '/Admin/Login';
//    }
//})
app.controller("Paging_ThongTinController", function ($scope, $http) {
    $scope.txtSearch = '';
    $scope.maxsize = 5;
    $scope.totalcount = 0;
    $scope.pageIndex = 1;
    $scope.pageSize = 5;
    $scope.addfn = function () {
        window.location.href = 'ThemThongTin';
    }
    $scope.ThongTinlist = function () {
        $http.get("/Admin/Get_data?pageindex=" + $scope.pageIndex + "&pagesize=" + $scope.pageSize).then(function (response) {
            $scope.ThongTindata = response.data.ThongTindata;
            $scope.totalcount = response.data.totalcount;
        }, function (error) {
            alert('failed');
        });
    }
    $scope.ThongTinlist();
    $scope.pagechanged = function () {
        $scope.ThongTinlist();
    }
    $scope.changePageSize = function () {
        $scope.pageIndex = 1;
        $scope.ThongTinlist();
    }
});
//app.controller("CRUD_ThongTinController", function ($scope, $http) {
//    $scope.btntext = "Lưu";
//    // Add record
//    $scope.savedata = function () {
//        $scope.btntext = "Please Wait..";
//        $scope.ThongTin.MaLoai = document.getElementById('MaLoai').value;
//        $http({
//            method: 'POST',
//            url: '/Admin/ThongTin/Addrecord',
//            data: $scope.ThongTin
//        }).then(function (d) {
//            $scope.btntext = "Lưu ";
//            window.location.href = 'Index';
//            $scope.ThongTin = null;
//            alert(d.data);
//        }), function error() {
//            alert('Failed');
//        };
//    };
//    // Display record by id
//    $scope.loadrecord = function (id) {
//        $http.get("/Admin/ThongTin/Get_databyid?id=" + id).then(function (d) {
//            $scope.ThongTin = d.data[0];
//            //$scope.ThongTin.LuotXem = $scope.ThongTin.LuotXem + 1;
//            //console.log($scope.ThongTin)
//            //$http({
//            //    method: 'POST',
//            //    url: '/Admin/ThongTin/update_record',
//            //    data: $scope.ThongTin
//            //}).then(function (d) {
//            //    $scope.btntext = "Update";
//            //    alert(d.data);
//            //}), function error() {
//            //    alert('Failed');
//            //};
//        }, function (error) {
//            alert('Failed');
//        });
//    };
//    //Delete record by id
//    $scope.deleterecord = function (id) {
//        $http.get("/Admin/ThongTin/delete_record?id=" + id).then(function (d) {
//            alert(d.data);
//            window.location.href = 'Index';
//        }, function (error) {
//            alert('Failed');
//        });
//    };
//    // Update record
//    $scope.updatedata = function () {
//        $scope.btntext = "Please Wait..";
//        $scope.ThongTin.MaLoai = document.getElementById('MaLoai').value;
//        $scope.ThongTin.Anh = document.getElementById('Anh').value;
//        delete $scope.ThongTin._Index;
//        console.log($scope.ThongTin)
//        $http({
//            method: 'POST',
//            url: '/Admin/ThongTin/update_record',
//            data: $scope.ThongTin
//       }).then(function (d) {
//            $scope.btntext = "Update";
//            window.location.href = '/Admin/ThongTin/Index';
//            $scope.ThongTin = null;
//            alert(d.data);
//        }), function error() {

//            alert('Failed');

//        };
//    };


//});
//app.controller("LoginController", function ($scope, $http, $window) {

//    $scope.btntext = "Login";

//    $scope.login = function () {

//        $scope.btntext = "Please wait..!";

//        $http({

//            method: "POST",

//            url: '/Admin/Login/userlogin',

//            data: $scope.user

//        }).then(function (d) {

//            $scope.btntext = 'Login';

//            if (d.data == 1) {


//                $http.get("/Admin/Login/get_info_user?taikhoan=" + $scope.user.TaiKhoan).then(function (d) {

//                    $scope.infoUser = d.data[0];
//                    localStorage.setItem('taikhoan', $scope.infoUser.TaiKhoan);
//                    localStorage.setItem('avatar', $scope.infoUser.Avatar);
//                    window.location.href = 'home'

//                }, function (error) {

//                    alert('Failed');

//                });



//            }
//            else {

//                alert(d.data);

//            }

//            $scope.user = null;

//        }), function error() {

//            alert('Can not connect to server');

//        };

//    };



//})




//app.controller('LoaiTinController', function ($scope, $http) {
//    $http.get('/LoaiThongTin/getAllRecord').then(function (d) {
//        $scope.LoaiThongTin = d.data;
//        $scope.LoaiThongTin1 = $scope.LoaiThongTin[0].TenLoai;
//        $scope.LoaiThongTin2 = $scope.LoaiThongTin[1].TenLoai;
//        $scope.LoaiThongTin3 = $scope.LoaiThongTin[2].TenLoai;
//        $scope.LoaiThongTin4 = $scope.LoaiThongTin[3].TenLoai;
//        $scope.LoaiThongTin5 = $scope.LoaiThongTin[4].TenLoai;

//        $scope.MaLoai1 = $scope.LoaiThongTin[0].MaLoai;
//        $scope.MaLoai2 = $scope.LoaiThongTin[1].MaLoai;
//        $scope.MaLoai3 = $scope.LoaiThongTin[2].MaLoai;
//        $scope.MaLoai4 = $scope.LoaiThongTin[3].MaLoai;
//        $scope.MaLoai5 = $scope.LoaiThongTin[4].MaLoai;

//        $http.get("/ThongTin/get_TenTTbyLoaiTT?id=" + $scope.MaLoai1).then(function (d) {

//            $scope.Title1 = d.data;
//            console.log($scope.Title1)

//        }, function (error) {

//            alert('Failed');

//        });
//        $http.get("/ThongTin/get_TenTTbyLoaiTT?id=" + $scope.MaLoai2).then(function (d) {

//            $scope.Title2 = d.data;
//            console.log($scope.Title2)

//        }, function (error) {

//            alert('Failed');

//        });
//        $http.get("/ThongTin/get_TenTTbyLoaiTT?id=" + $scope.MaLoai3).then(function (d) {

//            $scope.Title3 = d.data;
//            console.log($scope.Title3)

//        }, function (error) {

//            alert('Failed');

//        });
//        $http.get("/ThongTin/get_TenTTbyLoaiTT?id=" + $scope.MaLoai4).then(function (d) {

//            $scope.Title4 = d.data;
//            console.log($scope.Title4)

//        }, function (error) {

//            alert('Failed');

//        });
//        $http.get("/ThongTin/get_TenTTbyLoaiTT?id=" + $scope.MaLoai5).then(function (d) {

//            $scope.Title5 = d.data;
//            console.log($scope.Title5)

//        }, function (error) {

//            alert('Failed');

//        });


//    })
//});
//app.controller('LoaiThongTinController', function ($scope, $http) {

//    $http.get('/LoaiThongTin/getAllRecord').then(function (d) {

//        $scope.LoaiThongTin = d.data;

//    }, function (error) {

//        alert('failed');

//    });

//});
//app.controller('GetTTbyLoaiTinController', function ($scope, $http) {

//    $scope.loadrecord = function (id) {

//        $http.get("/ThongTin/get_TenTTbyLoaiTin?id=" + id).then(function (d) {

//            $scope.ThongTin = d.data;
//            console.log($scope.ThongTin)

//        }, function (error) {

//            alert('Failed');

//        });

//    };


//});
//app.controller('GetTTbyIDController', function ($scope, $http) {

//    $scope.loadrecord = function (id) {

//        $http.get("/ThongTin/Get_databyid?id=" + id).then(function (d) {

//            $scope.ThongTin = d.data;
//            console.log($scope.ThongTin)

//        }, function (error) {

//            alert('Failed');

//        });

//    };


//});
