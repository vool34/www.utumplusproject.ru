<!DOCTYPE html>
<html>
<head>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@Page.Title</title>
    <link href="~/content/bootstrap.css" rel="stylesheet" />
    <link href="~/content/bootstrap-theme.css" rel="stylesheet" />
    <script src="~/scripts/jquery-2.2.1.min.js"></script>
    <script src="~/scripts/jquery-ui-1.11.4.min.js"></script>
    <script src="~/scripts/jquery.validate.min.js"></script>
    <script src="~/scripts/bootstrap.min.js"></script>
    <script src="~/scripts/backendless.min.js"></script>
    <script src="~/scripts/init.js"></script>
    <script>

        $(document).ready(function () {

            var currentUser = Backendless.UserService.getCurrentUser();
            if (currentUser != null) {
                var username = currentUser["name"];
                $('#loggedinspan').text(username);
            }
            else {
                $('#loggedinspan').text('');
            };

        });

    </script>
</head>

<body role="document">
    <nav class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="#">Project+</a>
            </div>

            <div id="navbar" class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li class="active"><a href="#">Главная</a></li>
                    @*<li><a href="#about">About</a></li>
                        <li><a href="#contact">Contact</a></li>
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Dropdown <span class="caret"></span></a>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li role="separator" class="divider"></li>
                                <li class="dropdown-header">Nav header</li>
                                <li><a href="#">Separated link</a></li>
                                <li><a href="#">One more separated link</a></li>
                            </ul>
                        </li>*@
                </ul>
                <form class="navbar-form navbar-right">                    
                        <span style="color:white" id="loggedinspan"></span>                    
                </form>
            </div>
        </div>
    </nav>
    <div class="container theme-showcase" role="main">
        <br /><br /><br />
        @RenderBody()
    </div>
</body>
</html>
