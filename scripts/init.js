var APPLICATION_ID = '8F2BEBB7-9103-DC4C-FFD9-296280365500';
var SECRET_KEY = '08F98D9E-69C0-1197-FFDD-0DCF1450FE00';
var VERSION = 'v1';

init();

function init() {
    Backendless.initApp(APPLICATION_ID, SECRET_KEY, VERSION);
    var userProps = [
        { name: 'email' },
        { name: 'name' },
        { name: 'password' }
    ];

    for (var element in userProps) {
        makeComponent(userProps[element]);
    }
};

function makeComponent(property) {
    $("#regFields").append("<div><input type='text' class='input-block-level user-properties' placeholder= '" + property.name + "' name='" + property.name + "'> </input></div>");
};

function loginUser(username, password) {
    
    try {
        var user = Backendless.UserService.login(username, password);
        if (user != null) {
            return 1;
            console.log("Login: green");
        }
        else {
            return 0;
            console.log("Login: red");
        }
    }
    catch (e) {
        return 0;
        console.log("Login: red - " + e.message);
    }
}
