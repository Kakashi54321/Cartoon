const express = require("express");
const cors = require("cors");
const app = express();
app.use(cors());

app.listen(8000,"localhost", () => {
    console.log("Server listening");
});

app.get("/add", (request, response) => {
    response.status(200).send(parseInt(request.query.value1) + parseInt(request.query.value2)+"");
})

app.get("/sub", (request, response) => {
    response.status(200).send(parseInt(request.query.value1) - parseInt(request.query.value2)+"");
})

app.get("/mul", (request, response) => {
    response.status(200).send(parseInt(request.query.value1) * parseInt(request.query.value2)+"");
})

app.get("/div", (request, response) => {
    response.status(200).send(parseInt(request.query.value1) / parseInt(request.query.value2)+"");
})

app.get("/exp", (request, response) => {
    response.status(200).send(parseInt(request.query.value1) ** parseInt(request.query.value2)+"");
})