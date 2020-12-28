var app = angular.module('AdminApp', ['ui.bootstrap','imgurUpload']);


app.controller("DanhSachBVController", function ($scope, $http) {
    $scope.maxsize = 5;
    $scope.totalcount = 0;
    $scope.pageIndex = 1;
    $scope.pageSize = 5;
    $scope.searchText = '';
    $scope.BVLisst = function () {
        $http.get("/QLBaiViet/Get_data_BV?pageindex=" + $scope.pageIndex + "&pagesize=" + $scope.pageSize).then(function (response) {
            $scope.listbv = response.data.listBaiViet;
            $scope.totalcount = response.data.totalcount;
            //console.log($scope.totalcount);
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

    $scope.Xoabv = function (id) {
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
app.controller("ThemBVController", function ($scope, $http, imgurUpload) {
    $scope.info = { HinhAnh: "" }
    $scope.thembv = function () {
        var upimg = document.getElementById('exampleInputFile');
        var image = upimg.files[0];
        var success = function (result) {
          
            $scope.info.HinhAnh = result.data.link;
            $http({
                method: 'POST',
                url: '/QLBaiViet/Them_BV',
                data: $scope.info
            }).then(function (d) {
                console.log(d.data)


                window.location.href = '/QLBaiViet/DanhSachBV';
            }, function (e) {
                alert('failed');
            });
        };
        var clientId = "3631cecbf2bf2cf";
        imgurUpload.setClientId(clientId);
        imgurUpload
            .upload(image)
            .then(success);
    }
    $scope.getdmc = function (s) {
        $http.get('/QLBaiViet/getDMCbyMaDM?MaDM=' + s).then(function (sa) {
            $scope.listdmc = sa.data;
            //console.log($scope.listdmc)
        })
        }
    $http.get('/QLBaiViet/GetmaDM').then(function (d) {
        $scope.listmaDM = d.data;
        //console.log($scope.listmaDM)

    }, function (error) {
        alert('failed');
    })
    $http.get('/QLBaiViet/getmaDMC').then(function (d) {
        $scope.listmaDMC = d.data;
        //console.log($scope.listmaDMC)
    }, function (error) {
        alert('failed /QLBaiViet/getmaDMC');
    })
    $http.get('/QLBaiViet/Gettaikhoanus').then(function (d) {
        $scope.listUS = d.data;
        //console.log($scope.listUS)

    }, function (error) {
            alert('failed /QLBaiViet/Gettaikhoanus');
    })
}).filter("filterdate", function () {
    var re = /\/Date\(([0-9]*)\)\//;
    return function (x) {
        var m = x.match(re);
        if (m) return new Date(parseInt(m[1]));
        else return null;
    };
});

app.controller("SuaBVController", function ($scope, $http, $location, imgurUpload, $filter) {
    $scope.bv = { HinhAnh: "", ThoiGianDang:"" }
    var MaBV = $location.search().id;
    $http({
        method: 'get',
        url: '/QLBaiViet/Get_BV_byid?id=' + MaBV,

    }).then(function (jsonResults) {
        $scope.bv = jsonResults.data[0];
        //console.log(jsonResults.data)
        //console.log($scope.bv.ThoiGianDang)
        //console.log($filter('filterdate')($scope.bv.ThoiGianDang, 'dd/mm/yyyy'))
        $scope.bv.ThoiGianDang = new Date(ConvertDate($filter('filterdate')($scope.bv.ThoiGianDang, 'dd/mm/yyyy')))
      
    })

    $scope.suabv = function () {
        var upimg = document.getElementById('exampleInputFile');
        var image = upimg.files[0];
        if (image !== undefined) {
            var success = function (result) {

                $scope.bv.HinhAnh = result.data.link;

                $http({
                    method: 'POST',
                    url: '/QLBaiViet/Sua_BV',
                    data: $scope.bv
                }).then(function (d) {
                    console.log(d.data)
                    alert(d.data);
                    window.location.href = '/QLBaiViet/DanhSachBV';
                }, function (e) {
                    alert('failed');
                });

            };
            var clientId = "3631cecbf2bf2cf";
            imgurUpload.setClientId(clientId);
            imgurUpload
                .upload(image)
                .then(success);
        }
        else {

            $http({
                method: 'POST',
                url: '/QLBaiViet/Sua_BV',
                data: $scope.bv
            }).then(function (d) {
                //console.log(d.data)
                alert(d.data);
                window.location.href = '/QLBaiViet/DanhSachBV';
            }, function (e) {
                alert('failed');
            });
        }
    };
    $http.get('/QLBaiViet/getmaDMC').then(function (d) {
        $scope.listdmc = d.data;
        //console.log($scope.listdmc)
    }, function (error) {
        alert('failed /QLBaiViet/getmaDMC');
    })
    $scope.getdmc = function (s) {
        $http.get('/QLBaiViet/getDMCbyMaDM?MaDM=' + s).then(function (sa) {
            $scope.listdmc = sa.data;
            //console.log($scope.listdmc)
        })
    }
    $http.get('/QLBaiViet/GetmaDM').then(function (d) {
        $scope.listmaDM = d.data;
        //console.log($scope.listmaDM)

    }, function (error) {
        alert('failed');
    })
    $http.get('/QLBaiViet/getmaDMC').then(function (d) {
        $scope.listdmc = d.data;
        //console.log($scope.listdmc)
    }, function (error) {
        alert('failed /QLBaiViet/getmaDMC');
    })
    $http.get('/QLBaiViet/Gettaikhoanus').then(function (d) {
        $scope.listUS = d.data;
        //console.log($scope.listUS)

    }, function (error) {
        alert('failed /QLBaiViet/Gettaikhoanus');
    })
}).filter("filterdate", function () {
    var re = /\/Date\(([0-9]*)\)\//;
    return function (x) {
        var m = x.match(re);
        if (m) return new Date(parseInt(m[1]));
        else return null;
    };
});

app.controller("LoginController", function ($scope, $http) {
    $scope.login = function () {
        //console.log($scope.ad)
        $http.post('/Admin/login_', $scope.ad).then(function (s) {
            //console.log(s);
            localStorage.setItem("ten", s.data[0].tenUser)
            localStorage.setItem("anh", s.data[0].hinhAnh)
            localStorage.setItem("chucvu", s.data[0].chucVu)
            //console.log(s);
            window.location.href = '/ThongKe/Index';
        })
    }
})

function ConvertDate(str) {
    var date = new Date(str),
        mnth = ("0" + (date.getMonth() + 1)).slice(-2),
        day = ("0" + date.getDate()).slice(-2);
    return [date.getFullYear(), mnth, day].join("-");
}

function change(elm) {
    readImgUrlAndPreview(elm);
    function readImgUrlAndPreview(elm) {
        if (elm.files) {
            var reader = new FileReader();
            reader.onload = function (e) {
                $('#img').attr('src', e.target.result);
            }
        };
        reader.readAsDataURL(elm.files[0]);
    }
}
app.controller('ThongKeController', function ($scope, $http) {
    $http.get('/ThongKe/ThongKe').then(function (d) {
        $scope.ThongKe = d.data[0];
    }, function (error) {
        alert('failed');
    });
})
////////////////Login/////////////////////////////


app.controller("acc", function ($scope, $http) {
    if ($scope.ten = localStorage.getItem("ten") !== null) {
        $scope.ten = localStorage.getItem("ten")
        $scope.anh = localStorage.getItem("anh")
        $scope.chucvu = localStorage.getItem("chucvu")
    }
    else {
        window.location.href = '/Admin/Login';
    }
    $scope.signout = function () {
        localStorage.clear();
        window.location.href = '/Admin/Login';
    }
})


////////////////////////////////////////////////////