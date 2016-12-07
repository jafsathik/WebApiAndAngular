app.service("APIService", function ($http) {
    this.getSubs = function () {
        var url ="api/Person";
        return $http.get(url).then(function (response) {
            return response.data;
        });
    }

    this.saveSubscriber = function (sub) {
        return $http(
        {
            method: 'post',
            data: sub,
            url: 'api/Person'
        });
    }
});

