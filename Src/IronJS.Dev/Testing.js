﻿
var obj = {};
obj.a = "a-org";

with (obj) {
    var foo = function(x, y) {
        var myobj = {}
        myobj.z = 4;
        var z = 2;
        var a = "plz no";
        with(myobj) {
            var foo = function() {
                with({}) {
                    z = 3;
                }
            }
        }
        foo();
        return z;
    }
    var b;
    b = a;
    a = "a-next";
}

obj.b = b;

a_val = foo(1, 2);

/*
var outer = {}
outer.lol = "fail";
var inner = {}
inner.lol = "ok";
with(outer){
    with(inner){
        a_val = lol;
    }
}
*/