var app = angular.module("myApp", []);
//console.clear();



//Slide Post
app.controller("YmmyPost", function ($scope, $http) {
    $http({
        method: 'get',
        url: '/baiViet/getbaivietyummy?'

    }).then(function successCallback(res) {
        $scope.HinhAnh = res.data[0].HinhAnh;
        $scope.tendanhmuc = res.data[0].tendanhmuc;
        $scope.tendanhmuccon = res.data[0].tendanhmuccon;
        $scope.MaDMC = res.data[0].MaDMC;
        $scope.MaBV = res.data[0].MaBV;
        $scope.TieuDe = res.data[0].TieuDe;
        $scope.tacgia = res.data[0].tacgia;
        $scope.ThoiGianDang = res.data[0].ThoiGianDang;
    })
}).filter("filterdate", function () {
    var re = /\/Date\(([0-9]*)\)\//;
    return function (x) {
        var m = x.match(re);
        if (m) return new Date(parseInt(m[1]));
        else return null;
    };
});
app.controller("YmmyPost2", function ($scope, $http) {
    $http({
        method: 'get',
        url: '/baiViet/getbaivietyummy2'

    }).then(function successCallback(res) {
        $scope.HinhAnh = res.data[0].HinhAnh;
        $scope.tendanhmuc = res.data[0].tendanhmuc;
        $scope.tendanhmuccon = res.data[0].tendanhmuccon;
        $scope.MaDMC = res.data[0].MaDMC;
        $scope.MaBV = res.data[0].MaBV;
        $scope.TieuDe = res.data[0].TieuDe;
        $scope.tacgia = res.data[0].tacgia;
        $scope.ThoiGianDang = res.data[0].ThoiGianDang;
    })
}).filter("filterdate", function () {
    var re = /\/Date\(([0-9]*)\)\//;
    return function (x) {
        var m = x.match(re);
        if (m) return new Date(parseInt(m[1]));
        else return null;
    };
});

app.controller("YmmyPost3", function ($scope, $http) {
    $http({
        method: 'get',
        url: '/baiViet/getbaivietyummy3'

    }).then(function successCallback(res) {
        $scope.HinhAnh = res.data[0].HinhAnh;
        $scope.tendanhmuc = res.data[0].tendanhmuc;
        $scope.tendanhmuccon = res.data[0].tendanhmuccon;
        $scope.MaDMC = res.data[0].MaDMC;
        $scope.MaBV = res.data[0].MaBV;
        $scope.TieuDe = res.data[0].TieuDe;
        $scope.tacgia = res.data[0].tacgia;
        $scope.ThoiGianDang = res.data[0].ThoiGianDang;
    })
}).filter("filterdate", function () {
    var re = /\/Date\(([0-9]*)\)\//;
    return function (x) {
        var m = x.match(re);
        if (m) return new Date(parseInt(m[1]));
        else return null;
    };
});
//end Slide Post
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
////////////////////////////////
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
app.controller("newpostCT", function ($scope, $http) {

    $http({
        method: 'get',
        url: '/baiViet/getbaivietmoinhatCT'
    }).then(function successCallback(res) {

        $scope.listbaivietmoiCT = res.data;//lưu dữ liệu vào biến $scope.listbaivietmoinhat 
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
/////////////////////////////////
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
//////////////////////////////////////////
app.controller("NgauNhienPost", function ($scope, $http) {

    $http({
        method: 'get',
        url: '/baiViet/getbaivietngaunhien'
    }).then(function successCallback(res) {

        $scope.listNgauNhien = res.data;//lưu dữ liệu vào biến $scope.listbaivietmoinhat 
        //console.log($scope.listNgauNhien);

    })
}).filter("filterdate", function () {
    var re = /\/Date\(([0-9]*)\)\//;
    return function (x) {
        var m = x.match(re);
        if (m) return new Date(parseInt(m[1]));
        else return null;
    };
});
app.controller("NgauNhienPost1", function ($scope, $http) {

    $http({
        method: 'get',
        url: '/baiViet/getbaivietngaunhien1'
    }).then(function successCallback(res) {

        $scope.listNgauNhien1 = res.data;//lưu dữ liệu vào biến $scope.listbaivietmoinhat 
        //console.log($scope.listNgauNhien);

    })
}).filter("filterdate", function () {
    var re = /\/Date\(([0-9]*)\)\//;
    return function (x) {
        var m = x.match(re);
        if (m) return new Date(parseInt(m[1]));
        else return null;
    };
});
app.controller("NgauNhienPost2", function ($scope, $http) {

    $http({
        method: 'get',
        url: '/baiViet/getbaivietngaunhien2'
    }).then(function successCallback(res) {

        $scope.listNgauNhien2 = res.data;//lưu dữ liệu vào biến $scope.listbaivietmoinhat 
        //console.log($scope.listNgauNhien);

    })
}).filter("filterdate", function () {
    var re = /\/Date\(([0-9]*)\)\//;
    return function (x) {
        var m = x.match(re);
        if (m) return new Date(parseInt(m[1]));
        else return null;
    };
});
app.controller("NgauNhienPost3", function ($scope, $http) {
    $http({
        method: 'get',
        url: '/baiViet/getbaivietngaunhien3'
    }).then(function successCallback(res) {

        $scope.listNgauNhien3 = res.data;//lưu dữ liệu vào biến $scope.listbaivietmoinhat 
        //console.log($scope.listNgauNhien);

    })
}).filter("filterdate", function () {
    var re = /\/Date\(([0-9]*)\)\//;
    return function (x) {
        var m = x.match(re);
        if (m) return new Date(parseInt(m[1]));
        else return null;
    };
});

app.controller("imgQuangCaoPost728x90", function ($scope, $http) {
    $http({
        method: 'get',
        url: '/baiViet/getQuangCao728x90'

    }).then(function successCallback(res) {
        $scope.hinhAnh = res.data[0].hinhAnh;
        $scope.video = res.data[0].video;

        console.log($scope.hinhAnh);
    })
});
app.controller("imgQuangCaoPost450x360", function ($scope, $http) {
    $http({
        method: 'get',
        url: '/baiViet/getQuangCao450x360'

    }).then(function successCallback(res) {
        $scope.hinhAnh = res.data[0].hinhAnh;
        console.log($scope.hinhAnh);
    })
});
/////////////////////////////////////////////////////////

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
        //console.log($scope.listdsloaibv);

    })
    $scope.load = function () {
        $scope.pagesize += 5;
        $http({
            method: 'get',
            url: '/baiViet/getphantrangBV?maLoai='+ maDMC +'&&pagesize='+$scope.pagesize+''
        }).then(function successCallback(res) {

            $scope.listdsloaibv = res.data;//lưu dữ liệu vào biến $scope.listbaivietmoinhat 
            //console.log($scope.listdsloaibv);

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
//CTBV
app.controller("CTBVPost", function ($scope, $http, $location) {
    var maBV = $location.search().maBV;
    $http.post("/chiTietBaiViet/updateView?mbv=" + maBV);
    $http({
        method: 'get',
        url: '/chiTietBaiViet/getChiTietBaiViet?maBV=' + maBV,

    }).then(function successCallback(res) {
        $scope.maDMC = res.data[0].maDMC;
        $scope.tenDM = res.data[0].tenDM;
        $scope.tenDMC = res.data[0].tenDMC;
        $scope.tieuDe = res.data[0].tieuDe;
        $scope.tacGia = res.data[0].tacGia;
        $scope.thoiGian = res.data[0].thoiGian;
        $scope.luotXem = res.data[0].luotXem;
        $scope.tieuDeTiep = res.data[0].tieuDe;
        $scope.noiDung1 = res.data[0].noiDung1;
        $scope.hinhAnh1 = res.data[0].hinhAnh1;
        $scope.noiDung2 = res.data[0].noiDung2;
        $scope.hinhAnh2 = res.data[0].hinhAnh2;
        $scope.noiDung3 = res.data[0].noiDung3;
        $scope.hinhAnh3 = res.data[0].hinhAnh1;
        $scope.nguoiBL = res.data[0].nguoiBL;
        $scope.thoiGianBL = res.data[0].thoiGianBL;
        $scope.noiDungBL = res.data[0].noiDungBL;
        $scope.nguoiTLBL = res.data[0].nguoiTLBL;
        $scope.thoiGianTLBL = res.data[0].thoiGianTLBL;
        $scope.noiDungTLBL = res.data[0].noiDungTLBL;

    })
   
}).filter("filterdate", function () {
    var re = /\/Date\(([0-9]*)\)\//;
    return function (x) {
        var m = x.match(re);
        if (m) return new Date(parseInt(m[1]));
        else return null;
    };
});

app.controller("PhanHoiController", function ($scope, $http, $location) {
    var maBV = $location.search().maBV;
    $http.get("/PhanHoi/getbinhluan?maBV=" + maBV).then(function (data) {
        $scope.listBL = [];
        $scope.binhLuan = data.data;
        

        $http.get('/PhanHoi/getTLBinhLuan').then(function (data) {
            $scope.TLbinhluan = data.data;
            //console.log($scope.binhLuan);
            //console.log($scope.TLbinhluan);

            for (let i = 0; i < $scope.binhLuan.length; i++) {
                const node = $scope.binhLuan[i];
                node.listTLBL = [];
                for (let j = 0; j < $scope.TLbinhluan.length; j++) {
                    const node_con = $scope.TLbinhluan[j];
                    if (node_con.maBL == node.mabL) {
                        node.listTLBL.push(node_con);
                    }
                }
                $scope.listBL.push(node);
            }
        })
        //console.log($scope.listBL);
    })
    //console.log($scope.binhLuan);
}).filter("filterdate", function () {
    var re = /\/Date\(([0-9]*)\)\//;
    return function (x) {
        var m = x.match(re);
        if (m) return new Date(parseInt(m[1]));
        else return null;
    };
});


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

    });
}).filter("filterdate", function () {
    var re = /\/Date\(([0-9]*)\)\//;
    return function (x) {
        var m = x.match(re);
        if (m) return new Date(parseInt(m[1]));
        else return null;
    };
});


//Footer 
//dmc YUMMY
app.controller("danhMucYUMMYFooter", function ($scope, $http) {

    $http({
        method: 'get',
        url: '/danhmuccon/GetDanhMucConYMFOOTER'
    }).then(function successCallback(res) {

        $scope.listdmYMFooter = res.data;//lưu dữ liệu vào biến $scope
    })
});

