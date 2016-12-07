app.controller('APIController', function ($scope, APIService) {
    getAll();

    function getAll() {
        var servCall = APIService.getSubs();
        servCall.then(function(d) {
            $scope.persons = d.data;
        }, function(error) {
            $log.error('Oops! Something went wrong while fetching the data.');
        });
    }
    
    $scope.saveSubs = function () {
        alert();
        var sub = {
            MailID: $scope.mailid,
            SubscribedDate: new Date()
        };
        var saveSubs = APIService.saveSubscriber(sub);
        saveSubs.then(function(d) {
            getAll();
        }, function(error) {
            console.log('Oops! Something went wrong while saving the data.');
        });
    };
})

