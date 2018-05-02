var demographicChangeModule = angular.module("DemographicChangeApp", ['chart.js']);

demographicChangeModule.controller("DemographicChangeController", function ($scope, $http) {

    var dataUrl = "/api/DemographicChangeApi/GetDemographicChangeData";
    var dataToPost = { "NamespaceName": "demographicChangeService", "ClassName": "DemographicChangeService", "MethodName": "GetChangeData", "CountryName": "Romania" };

    $scope.onGetDemographicChangeData = function () {
        postData(dataUrl, dataToPost);
    };

    function displayChart(data) {
        if (data != null) {
            var labelArr = [];
            var dataArr = [];
            angular.forEach(data, function (obj, key) {
                labelArr.push(obj.Year);
                dataArr.push(obj.PopulationCount);
            });
            $scope.labels = labelArr.reverse();
            $scope.data = dataArr.reverse();
            angular.element("#demographicChangeCanvasEmptyText").hide();
        }
    }

    function postData(url, dataToPost) {
        $http.post(url, dataToPost).then(function (success) {
            if (success.status == 200) {
                console.log(success);
                displayChart(success.data);
            }
        });
    }
});