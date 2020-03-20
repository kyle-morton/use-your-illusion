"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var DataService = /** @class */ (function () {
    function DataService(httpClient, url, endpoint) {
        this.httpClient = httpClient;
        this.url = url;
        this.endpoint = endpoint;
    }
    DataService.prototype.get = function (route) {
        var path = route == null ? "" + this.endpoint : this.endpoint + "/" + route;
        return this.httpClient.get("" + this.url + path);
    };
    DataService.prototype.post = function (item, route) {
        var path = route == null ? this.endpoint : this.endpoint + "/" + route;
        return this.httpClient
            .post("" + this.url + path, item);
    };
    DataService.prototype.put = function (item, route) {
        var path = route == null ? this.endpoint : this.endpoint + "/" + route;
        return this.httpClient
            .put("" + this.url + path, item);
    };
    DataService.prototype.delete = function (id, route) {
        var path = route == null ? this.endpoint : this.endpoint + "/" + route;
        return this.httpClient
            .delete("" + this.url + path + "/" + id);
    };
    return DataService;
}());
exports.DataService = DataService;
//# sourceMappingURL=data.service.js.map