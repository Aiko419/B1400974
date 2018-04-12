angular.module('myApp', []).controller('userCtrl', function ($scope) {
    $scope.fName = '';
    $scope.lName = '';
    $scope.passw1 = '';
    $scope.passw2 = '';
    $scope.edit = true;
    $scope.error = false;
    $scope.hideform = true;
    $scope.editUser = function (id) {
        $scope.hideform = false;
        if (id === 'new') {
            $scope.edit = true;
            $scope.incomplete = true;
            $scope.fName = '';
            $scope.lName = '';
        } else {
            $scope.edit = false;
            $scope.fName = $scope.users[id - 1].fName;
            $scope.lName = $scope.users[id - 1].lName;
        }
    };

    $scope.$watch('passw1', function () { $scope.test(); });
    $scope.$watch('passw2', function () { $scope.test(); });

    $scope.test = function () {
        if ($scope.passw1 !== $scope.passw2) {
            $scope.error = true;
        } else {
            $scope.error = false;
        }        
    };

});