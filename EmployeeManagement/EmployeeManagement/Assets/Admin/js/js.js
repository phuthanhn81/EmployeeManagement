app.directive('onlyLetter', function () {
    return {
        restrict: 'A',
        link: function (scope, element, attrs) {
            element.on('keypress', function (e) {
                var reg = new RegExp('^[a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$');
                var key = String.fromCharCode(e.keyCode);
                if (!reg.test(key)) {
                    e.preventDefault();
                }
            });
        }
    };
})

app.directive('onlyNumber', function () {
    return {
        restrict: 'A',
        link: function (scope, element, attrs) {
            element.on('keypress', function (e) {
                var reg = new RegExp('^[0-9]');
                var key = String.fromCharCode(e.keyCode);
                if (!reg.test(key)) {
                    e.preventDefault();
                }
            });
        }
    };
})

app.factory('factory', function () {
    var Employees = [];
    var MACV = '';
    var MABP = '';
    return {
        Employees: Employees,
        MACV: MACV,
        MABP: MABP,
    }
})

app.directive('range', function () {
    return {
        restrict: 'A',
        require: 'ngModel',
        link: function (scope, element, attrs, ngModel) {
            var MinMax = attrs.range.split(',');
            ngModel.$parsers.unshift(function (value) {
                var length = value.length;
                var valid = length == MinMax[0];
                if (length != 0) {
                    ngModel.$setValidity('range', valid);
                    ngModel.$setValidity('force', true);
                }
                else {
                    ngModel.$setValidity('range', true);
                    ngModel.$setValidity('force', false);
                }
                return valid ? value : MinMax[0];
            });

            ngModel.$formatters.unshift(function (value) {
                ngModel.$setValidity('force', false); // required

                if (value != null) { // Update
                    ngModel.$setValidity('force', true);
                    return value;
                }
            });
        }
    };
})

// directive mà có lỗi console thì sẽ ko sài đc