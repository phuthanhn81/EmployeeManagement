var app = angular.module('app', ['ui.router', 'angularUtils.directives.dirPagination', 'datatables', 'datatables.fixedcolumns']);

app.config(['$stateProvider', function ($stateProvider) {
    $stateProvider.state('nhanvien', { // ui-sref
        url: '/nhanvien', // chuyển state
        views: {
            'content': {
                templateUrl: '/App/NHANVIEN/index.html',
                // controller: 'NHANVIENController', // gọi trong state thì HTML ko cần ng-controller nữa và ngược lại (+)
            }
        },
    }).state('create_nv', {
        url: '/create_nv',
        views: {
            'content': {
                templateUrl: '/App/NHANVIEN/create.html',
            }
        }
    }).state('update_nv', {
        url: '/update_nv',
        views: {
            'content': {
                templateUrl: '/App/NHANVIEN/update.html',
            }
        },
        // phải có mới sài $stateParams đc
        params: {
            employee: null,
            manv: null,
            hoten: null,
        }
    }).state('chamcong', {
        url: '/chamcong',
        views: {
            'content': {
                templateUrl: '/App/CHAMCONG/Index.html',
            }
        }
    })
}])

// url: '/delete_nv/:MANV/:HOTEN/:NGAYSINH'
// ui-sref="delete_nv({ MANV: n.MANV, HOTEN: n.HOTEN, NGAYSINH: n.NGAYSINH })"
// $stateParams.MANV, ...