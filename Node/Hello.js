// HTTP 모듈 로딩
let http = require("http");

// HTTP 서버를 Listen 상태로 8000포트 사용하여 마든다.
http.createServer(function (request, resopnse){

// response HTTP 타입 해더를 정의
resopnse.writeHead(200, {'Content-Type': 'text/plain'});

resopnse.end('Hello World');

}).listen(8000);        // 8000번 포트를 사용한다.

console.log("Server running at http://127.0.0.1:8000")