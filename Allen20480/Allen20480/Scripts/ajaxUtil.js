var Ajax = function (options) {
    var _url = options.url;
    var _type = options.type;
    var _dataType = options.dataType;
    var _data = options.data;
    var _contentType = options.contentType;
    
    this.makeRequest = function () {
        return $.ajax({
            url: _url,
            type: _type,
            dataType: _dataType,
            contentType: _contentType,
            data: _data
        }).promise();
    }
}