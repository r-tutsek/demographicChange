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
                $scope.linearChartLabels = labelArr.reverse();
                $scope.linearChartData = dataArr.reverse();
            } else if (methodName == "GetEthnicGroupsPopulation") {
                var tmpArr = {};
                angular.forEach(data, function (obj, key) {
                    var tmp = {};
                    if (typeof tmpArr[obj.Year] == "undefined") {
                        tmpArr[obj.Year] = [];
                    }
                    tmp["PopulationCount"] = obj.PopulationCount;
                    tmp["Ethnicity"] = obj.Ethnicity;
                    tmpArr[obj.Year].push(tmp);
                });
                var index = 0;
                var ethnicRow1 = [];
                var ethnicRow2 = [];
                var ethnicRow3 = [];
                if (Object.keys(tmpArr).length > 0) {
                    $scope.barChartOptions = {legend: {display:true}};
                    angular.forEach(tmpArr, function (obj, key) {
                        labelArr.push(key);
                        ethnicRow1.push(obj[0].PopulationCount);
                        ethnicRow2.push(obj[1].PopulationCount);
                        ethnicRow3.push(obj[2].PopulationCount);
                        if (index == 0) {
                            $scope.barChartSeries = [obj[0].Ethnicity, obj[1].Ethnicity, obj[2].Ethnicity];
                        }
                        ++index;
                    });
                    dataArr = [ethnicRow1, ethnicRow2, ethnicRow3];
                }
                $scope.barChartLabels = labelArr;
                $scope.barChartData = dataArr;
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