@Code
    Layout = "~/_LayoutPage1.vbhtml"
    PageData("Title") = "Вход"
End Code

<script>
    $(window).ready(function () {
        var currentUser = Backendless.UserService.getCurrentUser();
        if (currentUser != null) {
            var username = currentUser["name"];
            $('#loggedinspan').text(username);
        }
        else {
            $('#loggedinspan').text('');
        };

        $('.form-signin').on('submit', function (e) {
            e.preventDefault();

            var username = $('#username').val();
            var password = $('#password').val();

            try {
                var user = Backendless.UserService.login(username, password, true);
                if (user != null) {
                    console.log("Login: green");
                    window.location = "../../";
                }
                else {
                    console.log("Login: red");
                    $('#errorLogin').modal('show');
                }
            }
            catch (e) {
                console.log("Login: red - " + e.message);
                $('#errorLogin').modal('show');
            }
        });
    });

</script>

<div class="main-container">
    <form class="form-signin" role="form">
        <h2 class="form-signin-heading">Вход</h2>
        <input type="text" id="username" name="username" class="form-control" placeholder="Username" required="" autofocus=""><br />
        <input type="password" id="password" name="password" class="form-control" placeholder="Password" required="">
        <a href="../account/forget">Забыли пароль?</a><br />
        <a href="../account/logout"><span id="loggedinspan"></span></a>
        <hr />
        <button class="btn btn-lg btn-primary btn-block" type="submit">Вход</button>
    </form>
</div>

<div id="errorLogin" class="modal fade" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                <h4 class="modal-title" id="myModalLabel">Вход</h4>
            </div>
            <div class="modal-body">
                Ошибка входа. Попробуйте еще раз
            </div>
            <div class="modal-footer">
                @*<button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    <button type="button" class="btn btn-primary">Save changes</button>*@
            </div>
        </div>
    </div>
</div>