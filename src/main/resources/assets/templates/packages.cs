<?cs include:"partials/sidebar-page-top.cs" ?>
<?cs include:"macros.cs" ?>

<div class="w3-container">

    <h1><?cs var:page.title ?></h1>

    <p><?cs call:tag_list(root.descr) ?></p>

    <ul class="w3-ul w3-hoverable">
        <?cs each:pkg = docs.packages ?>
        <li>
            <a href="<?cs var:toroot ?><?cs var:pkg.link ?>"><?cs var:pkg.name ?></a>
            <?cs if:pkg.since.key ?>[since <?cs var:pkg.since.key ?> ]<?cs /if ?>
            <?cs call:tag_list(pkg.shortDescr) ?>
        </li>
        <?cs /each ?>
    <ul>

</div>
<?cs include:"partials/sidebar-page-bottom.cs" ?>