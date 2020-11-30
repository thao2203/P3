var app = angular.module("myApp", []);
//console.clear();
app.controller("hotPost", function ($scope, $http) {

    $http({
        method: 'get',
        url: '/baiViet/getbaiviethot'
    }).then(function successCallback(res) {

        $scope.listbaiviethot = res.data;//lưu dữ liệu vào biến $scope.listbaivietmoinhat 
        //console.log($scope.listbaiviethot);

    })
}).filter("filterdate", function () {
    var re = /\/Date\(([0-9]*)\)\//;
    return function (x) {
        var m = x.match(re);
        if (m) return new Date(parseInt(m[1]));
        else return null;
    };
});
app.controller("newpost", function ($scope, $http) {

    $http({
        method: 'get',
        url: '/baiViet/getbaivietmoinhat'
    }).then(function successCallback(res) {

        $scope.listbaivietmoi = res.data;//lưu dữ liệu vào biến $scope.listbaivietmoinhat 
        //console.log($scope.listbaivietmoi);

    })
}).filter("filterdate", function () {
    var re = /\/Date\(([0-9]*)\)\//;
    return function (x) {
        var m = x.match(re);
        if (m) return new Date(parseInt(m[1]));
        else return null;
    };
});

app.controller("cakepost", function ($scope, $http) {

    $http({
        method: 'get',
        url: '/baiViet/getbaivietBanhNgot'
    }).then(function successCallback(res) {

        $scope.listbaivietBanhNgot = res.data;//lưu dữ liệu vào biến $scope.listbaivietmoinhat 
        //console.log($scope.listbaivietBanhNgot);

    })
}).filter("filterdate", function () {
    var re = /\/Date\(([0-9]*)\)\//;
    return function (x) {
        var m = x.match(re);
        if (m) return new Date(parseInt(m[1]));
        else return null;
    };
});

app.controller("HaNoipost", function ($scope, $http) {

    $http({
        method: 'get',
        url: '/baiViet/getbaivietHaNoi'
    }).then(function successCallback(res) {

        $scope.listbaivietHaNoi = res.data;//lưu dữ liệu vào biến $scope.listbaivietmoinhat 
        //console.log($scope.listbaivietHaNoi);

    })
}).filter("filterdate", function () {
    var re = /\/Date\(([0-9]*)\)\//;
    return function (x) {
        var m = x.match(re);
        if (m) return new Date(parseInt(m[1]));
        else return null;
    };
});

app.controller("NoiBatpost", function ($scope, $http) {

    $http({
        method: 'get',
        url: '/baiViet/getbaivietNoiBat'
    }).then(function successCallback(res) {

        $scope.listNoiBat = res.data;//lưu dữ liệu vào biến $scope.listbaivietmoinhat 
        //console.log($scope.listNoiBat);

    })
});

app.controller("bvTheoLoai", function ($scope, $http, $location) {
    var maDMC = $location.search().maLoai;
    $http({
        method: 'get',
        url: '/baiViet/getbaiviettheoloai?maLoai=' + maDMC,

    }).then(function successCallback(res) {
        //$scope.listBaiVietTheoLoai = res.data;//lưu dữ liệu vào biến $scope 
        $scope.view = res.data[0].tendanhmuccon;
        //console.log($scope.listBaiVietTheoLoai);

    })
});
//----------
app.controller("LoaibvPost", function ($scope, $http, $location) {
    var maDMC = $location.search().maLoai;
    $scope.pagesize = 5;
    $http({
        method: 'get',
        url: '/baiViet/getphantrangBV?maLoai='+ maDMC +'&&pagesize='+$scope.pagesize+''
    }).then(function successCallback(res) {
        $scope.listdsloaibv = res.data;//lưu dữ liệu vào biến $scope.listbaivietmoinhat 
        console.log($scope.listdsloaibv);

    })
    $scope.load = function () {
        $scope.pagesize += 5;
        $http({
            method: 'get',
            url: '/baiViet/getphantrangBV?maLoai='+ maDMC +'&&pagesize='+$scope.pagesize+''
        }).then(function successCallback(res) {

            $scope.listdsloaibv = res.data;//lưu dữ liệu vào biến $scope.listbaivietmoinhat 
            console.log($scope.listdsloaibv);

        })
    }
});
//Danh mục
app.controller("DanhMucPost", function ($scope, $http) {

    $http({
        method: 'get',
        url: '/danhmuc/GetDanhMuc'
    }).then(function successCallback(res) {

        $scope.listDanhMuc = res.data;//lưu dữ liệu vào biến $scope
        //console.log($scope.listDanhMuc);

    })
});

app.controller("_DanhMucPost", function ($scope, $http) {

    $http({
        method: 'get',
        url: '/danhmuc/GetDanhMuc'
    }).then(function successCallback(res) {

        $scope.listDanhMuc = res.data;//lưu dữ liệu vào biến $scope
        //console.log($scope.listDanhMuc);

    })
});


//----------------------------
//navigator  

app.controller("getMenu", function ($scope, $http) {
    $http.get('/danhmuc/getdanhmuc').then(function (data) {
        $scope.menus = [];
        $scope.danhmuc = data.data;
        $http.get('/DanhMucCon/GetDanhMucCon').then(function (data) {
            $scope.danhmuccon = data.data;
            //console.log($scope.danhmuc);
            //console.log($scope.danhmuccon);
            for (let i = 0; i < $scope.danhmuc.length; i++) {
                const node = $scope.danhmuc[i];
                node.children = [];
                for (let j = 0; j < $scope.danhmuccon.length; j++) {
                    const node_con = $scope.danhmuccon[j];
                    if (node_con.madm == node.MaDM) {
                        node.children.push(node_con);
                    }
                }
                $scope.menus.push(node);
            }
        })
        //console.log($scope.menus);
    })
})


//Gmail
//view gọi hàm thực hiện ng-click gọi hàm bv SendMail
app.controller("myGmail", function ($scope, $http) {
   
    $scope.sendMe = function () {
        var i4 = { mail: $scope.mail }
       
        alert("Đăng ký thành công <3")
        $http({
            method: 'post',
            url: '/baiViet/SendMail',
            data: i4
        })
    }
});

app.controller("myGmailFooter", function ($scope, $http) {

    $scope.sendMe = function () {
        var i4 = { mail: $scope.mail }
        alert("Đăng ký thành công <3")
        $http({
            method: 'post',
            url: '/baiViet/SendMail',
            data: i4
        })
    }
});

app.controller('searchbar', function ($scope, $location) {
    
    $scope.search = function () {
       
        window.location = '/baiViet/search#!?key=' + $scope.searchvalue;
    }
})


app.controller("timkiem", function ($scope, $http, $location) {
    
    $http({
        method: 'get',
        url: '/baiViet/searchByName?key=' + $location.search().key,

    }).then(function successCallback(res) {

        $scope.listBaiVietTheoLoai = res.data;//lưu dữ liệu vào biến $scope 
        //console.log($scope.listBaiVietTheoLoai);

    })
}).filter("filterdate", function () {
    var re = /\/Date\(([0-9]*)\)\//;
    return function (x) {
        var m = x.match(re);
        if (m) return new Date(parseInt(m[1]));
        else return null;
    };
});

//CTBV
app.controller("CTBVPost", function ($scope, $http, $location) {
    var maBV = $location.search().maBV;
    $http({
        method: 'get',
        url: '/chiTietBaiViet/getChiTietBaiViet?maBV=' + maBV,

    }).then(function successCallback(res) {
        $scope.tenDMC = res.data[0].tenDMC;
        $scope.tieuDe = res.data[0].tieuDe;
        $scope.tacGia = res.data[0].tacGia;
        $scope.thoiGian = res.data[0].thoiGian;
        $scope.luotXem = res.data[0].luotXem;
        $scope.tieuDeTiep = res.data[0].tieuDe
        $scope.noiDung1 = res.data[0].noiDung1;
        $scope.hinhAnh1 = res.data[0].hinhAnh1;
        $scope.noiDung2 = res.data[0].noiDung2;
        $scope.hinhAnh2 = res.data[0].hinhAnh2;
        $scope.noiDung3 = res.data[0].noiDung3;
        $scope.hinhAnh3 = res.data[0].hinhAnh1;
        $scope.nguoiBL = res.data[0].nguoiBL;
        $scope.thoiGianBL = res.data[0].thoiGianBL;
        $scope.noiDungBL = res.data[0].noiDungBL;

    })
}).filter("filterdate", function () {
    var re = /\/Date\(([0-9]*)\)\//;
    return function (x) {
        var m = x.match(re);
        if (m) return new Date(parseInt(m[1]));
        else return null;
    };
});