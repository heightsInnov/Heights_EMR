var http = require('http');
var port = process.env.port || 1337;
http.createServer(function (req, res) {
    res.writeHead(200, { 'Content-Type': 'text/plain' });
    res.end('Hello World\n');
}).listen(port);

console.log("Hello, World!");

var add = 1 + 3;
console.log(add);

var x = 0;
do{
x++;
    console.log("x: " + x);
}while (x<5)