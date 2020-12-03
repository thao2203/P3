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


var app1 = angular.module("LoginApp", []);
// đăng nhập
app1.controller("login", function ($scope, $http, $window) {

    $scope.btntext = "Đăng Nhập"; //giá trị nút đăng nhập
    $scope.DangNhap = function () { //được gọi khi bấm nút đăng nhập
        $scope.btntext = "Đang Đang Nhập....";
        $http({
            method: "POST", //method gửi dữ liệu
            url: '/Admin/DoLogin', //gọi hàm controller/account/Login
            params: $scope.US //dữ liệu truyền vào user là tên biến đặt bên input
        }).then(function (bool) { //gọi  khi thành công và lấy giá trị hàm trên trả vê
            console.log(bool)
            if (bool.data[0].Active == "2") { //kiểm tra dữ liệu đăng nhập trả về nếu là 2 thì đã hoàn tát đăng ký
                $scope.btntext = "Thành công!";
                //$cookies.put('taikhoan', $scope.KHACH_HANG.taikhoan); //lưu tên tài khoản và mật khẩu vào cookie để tự động đăng nhập lần sau
                //$cookies.put('matkhau', $scope.KHACH_HANG.matkhau);
                localStorage.setItem('taiKhoanUS', $scope.US.taiKhoanUS);
                localStorage.setItem('matkhau', $scope.US.matkhau);
                $window.location.href = '/Admin/danhSachBaiViet"';
            } else if (bool.data[0].Active == "1") { //nếu là 1 thì chưa điền thông tin cá nhận
                $scope.btntext = "Thành công!";
                //$cookies.put('taikhoan', $scope.KHACH_HANG.taikhoan); //lưu tên tài khoản và mật khẩu vào cookie để tự động đăng nhập lần sau
                //$cookies.put('matkhau', $scope.KHACH_HANG.matkhau);
                localStorage.setItem('taiKhoanUS', $scope.US.taiKhoanUS);
                localStorage.setItem('matkhau', $scope.US.matkhau);

                $window.location.href = '/Admin/danhSachBaiViet';
            } else if (bool.data[0].Active == "0") { //nếu là 1 thì chưa điền thông tin cá nhận
                $scope.btntext = "Thành công!";
                //$cookies.put('taikhoan', $scope.KHACH_HANG.taikhoan); //lưu tên tài khoản và mật khẩu vào cookie để tự động đăng nhập lần sau
                //$cookies.put('matkhau', $scope.KHACH_HANG.matkhau);
                localStorage.setItem('taiKhoanUS', $scope.US.taiKhoanUS);
                localStorage.setItem('matkhau', $scope.US.matkhau);

                $window.location.href = '/Account/sent';
            }
            else //thông tin đăng nhập k đúng
                $scope.btntext = "Thông tin đăng nhập không chính xác";
        });
    }

})