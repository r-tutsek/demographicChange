var demographicChangeModule = angular.module("DemographicChangeApp", ['chart.js']);

demographicChangeModule.controller("DemographicChangeController", function ($scope, $http) {

    var dataUrl = "/api/DemographicChangeApi/GetData";
    var dataToPost = { "NamespaceName": "demographicChangeService", "ClassName": "DemographicChangeService" };
    
    $scope.onGetDemographicChangeData = function () {
        dataToPost["MethodName"] = "GetTotalPopulation";
        postData(dataUrl, dataToPost);
    };

    $scope.onGetDemographicChangeByEthnicityData = function () {
        dataToPost["MethodName"] = "GetEthnicGroupsPopulation";
        postData(dataUrl, dataToPost);
    };

    function displayChart(data, methodName) {
        if (data != null) {
            var labelArr = [];
            var dataArr = [];
            if (methodName == "GetTotalPopulation") {
                angular.forEach(data, function (obj, key) {
                    labelArr.push(obj.Year);
                    dataArr.push(obj.PopulationCount);
                });
                $scope.labels = labelArr.reverse();
                $scope.data = dataArr.reverse();
            } else if (methodName == "GetEthnicGroupsPopulation") {
                var tmpArr = [];
                angular.forEach(data, function (obj, key) {
                    var tmp = {};
                    if (typeof tmpArr[obj.Year] == "undefined") {
                        tmpArr[obj.Year] = [];
                    }
                    tmp["PopulationCount"] = obj.PopulationCount;
                    tmp["Ethnicity"] = obj.Ethnicity;
                    tmpArr[obj.Year].push(tmp);
                });
                //continue from here...
            }
            angular.element("#demographicChangeCanvasEmptyText").hide();
        }
    }

    function postData(url, dataToPost) {
        $http.post(url, dataToPost).then(function (success) {
            if (success.status == 200) {
                displayChart(success.data, dataToPost["MethodName"]);
            }
        });
    }
});