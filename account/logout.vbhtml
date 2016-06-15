@Code
    Layout = "~/_LayoutPage1.vbhtml"
    PageData("Title") = "Выход"

End Code
<script>
    Backendless.UserService.logout();
</script>
<h2 class="form-signin-heading">Вы вышли из системы</h2>