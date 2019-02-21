const request = new XMLHttpRequest();

bt1.onclick = function(){
    Call("add")
};

bt2.onclick = function(){
    Call("sub")
};

bt3.onclick = function(){
    Call("mul")
};

bt4.onclick = function(){
    Call("div")
};

bt5.onclick = function(){
    Call("exp")
};

function Call(method){
    request.open("GET", "http://127.0.0.1:8000/"+method+"?value1="+operand1.value+"&value2="+operand2.value);
    request.onload = function(){
        answer.value = request.responseText;
    };
    request.send();
};