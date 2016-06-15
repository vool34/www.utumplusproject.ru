<script>
    $('.form-horizontal').on('submit', function (e) {
        var organizationObject = new Organization({
            name: $('#name').val()
        });
        var savedOrganization = Backendless.Persistence.of(Organization).save(organizationObject);
        console.log("Done!");
    });

    function Organization(args) {
        args = args || {};
        this.name = args.name || "";
    }

</script>

<h2>Создание</h2>
<form class="form-horizontal" role="form">
    <div class="form-group">
        <div class="col-sm-6">
            <input id="name" type="text" class="form-control" placeholder="Наименование" autocomplete="on" required="">
        </div>
        <div class="col-sm-2">
            <button type="submit" class="btn btn-default">OK</button>
        </div>
    </div>
</form>