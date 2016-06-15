@Code
    Layout = "~/_LayoutPage1.vbhtml"
    PageData("Title") = "Управление Организациями"
End Code
<script>

    $(document).ready(function () {
        $('.href').click(function (e) {
            e.preventDefault();
            $("#pageholder").load(this.href);
        });

        var organizationCollection = Backendless.Persistence.of(Organization).find();
        $("#maintable").find("tr:gt(0)").remove();
        $("#maintable").css("visibility", "hidden");

        $.each(organizationCollection, function (index, value) {
            if (value[index]) {
                console.log(value[index]);
            }
        });
    });

    function Organization(args) {
        args = args || {};
        this.name = args.name || "";
    };
</script>
<h2>Управление Организациями</h2>
<div class="col-sm-3 col-md-2 sidebar">
    <ul class="nav nav-sidebar">
        <li class="active"><a href="~/admin/organization">Обзор <span class="sr-only">(current)</span></a></li>
        <li><a href="organization-create" class="href">Создание</a></li>
        <li><a href="organization-edit" class="href">Редактирование</a></li>
        <li><a href="organization-delete" class="href">Удаление</a></li>
    </ul>
</div>
<div id="pageholder">
    <table id="maintable" style="visibility:hidden" class="bordered">
        <thead>
            <tr>
                <th>№</th>
                <th>Название</th>
                <th>Дата создания</th>
            </tr>
        </thead>
    </table>
</div>