var demographicChangeModule = angular.module("DemographicChangeApp", ['chart.js']);

demographicChangeModule.controller("DemographicChangeController", function ($scope, $http) {

    var apiUrl = "/api/DemographicChangeApi";
    
    $scope.onGetDemographicChangeData = function () {
        var actionName = "GetTotalPopulationData";
        getDemographicData(actionName);
    };

    $scope.onGetDemographicChangeByEthnicityData = function () {
        var actionName = "GetEthnicGroupsPopulationData";
        getDemographicData(actionName);
    };

    function displayChart(data, actionName) {
        if (data != null) {
            var labelArr = [];
            var dataArr = [];
            if (actionName == "GetTotalPopulationData") {
                angular.forEach(data, function (obj, key) {
                    labelArr.push(obj.Year);
                    dataArr.push(obj.PopulationCount);
                });
                $scope.linearChartLabels = labelArr;
                $scope.linearChartData = dataArr;
            } else if (actionName == "GetEthnicGroupsPopulationData") {
                var tmpArr = {};
                var ethnicitiesArr = {};
                angular.forEach(data, function (obj, key) {
                    var tmp = {};
                    if (typeof tmpArr[obj.Year] == "undefined") {
                        tmpArr[obj.Year] = [];
                    }
                    tmp["PopulationCount"] = obj.PopulationCount;
                    tmp["Ethnicity"] = obj.Ethnicity;
                    tmpArr[obj.Year].push(tmp);

                    if (typeof ethnicitiesArr[obj.Ethnicity] == "undefined") {
                        ethnicitiesArr[obj.Ethnicity] = [];
                    }
                });
                if (Object.keys(tmpArr).length > 0) {
                    angular.forEach(tmpArr, function (objArr, key) {
                        labelArr.push(key);
                        angular.forEach(objArr, function (obj, key2) {
                            ethnicitiesArr[obj.Ethnicity].push(obj.PopulationCount);
                        });
                    });
                }
                if (Object.keys(ethnicitiesArr).length > 0) {
                    var barChartSeries = [];
                    $scope.barChartOptions = { legend: { display: true } };
                    angular.forEach(ethnicitiesArr, function (objArr, key) {
                        barChartSeries.push(key);
                        dataArr.push(objArr);
                    });
                    $scope.barChartSeries = barChartSeries;
                }
                $scope.barChartLabels = labelArr;
                $scope.barChartData = dataArr;
            }
            angular.element("#demographicChangeCanvasEmptyText").hide();
        }
    }

    function getDemographicData(actionName) {
        $http.get(apiUrl+"/"+actionName).then(function (success) {
            if (success.status == 200) {
                displayChart(success.data, actionName);
            }
        });
    }
});