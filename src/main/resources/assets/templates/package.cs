<?cs include:"partials/sidebar-page-top.cs" ?>
<?cs include:"macros.cs" ?>

<div class="w3-container w3-theme-l4">
    <h1>
        <span class="w3-small">package <b><?cs var:package.name ?></b></span>
        <br/>
        <?cs var:package.shortName ?>
    </h1>

    <div id="api-info-block">
        <div class="api-level">
            <?cs if:reference.apilevels ?>
            Since: <a href="<?cs var:toroot ?>guide/appendix/api-levels.html#level<?cs var:package.since.key ?>">API
            Level <?cs var:package.since.name ?></a>
            <?cs /if ?>

            <?cs if:subcount(package.federated) ?>
            <div>
                Also:
                <?cs each:federated=package.federated ?>
                <a href="<?cs var:federated.url ?>"><?cs var:federated.name ?></a>
                <?cs if:!last(federated) ?>,<?cs /if ?>
                <?cs /each ?>
            </div>
            <?cs /if ?>
        </div>
    </div>

</div>

<div class="w3-container">

    <?cs if:subcount(package.descr) ?>
    <div class="jd-descr">
        <?cs call:tag_list(package.descr) ?>
    </div>
    <?cs /if ?>

    <?cs def:class_link_list(classes) ?>
    <ul class="w3-ul w3-padding-large">
        <?cs set:count = #1 ?>
        <?cs each:cl=classes ?>
        <li <?cs if:count % #2 ?>class="w3-light-grey"<?cs /if ?>>
            <h5><?cs call:type_link(cl.type) ?></h5>
            <p class="w3-small"><?cs call:short_descr(cl) ?>&nbsp;</p>
        </li>
        <?cs set:count = count + #1 ?>
        <?cs /each ?>
    </ul>
    <?cs /def ?>

    <?cs def:class_table(label, classes) ?>

    <?cs if:subcount(classes) ?>
    <h2><?cs var:label ?></h2>

    <?cs call:class_link_list(classes) ?>
    <?cs /if ?>

    <?cs /def ?>

    <?cs call:class_table("Interfaces", package.interfaces) ?>
    <?cs call:class_table("Classes", package.classes) ?>
    <?cs call:class_table("Enums", package.enums) ?>
    <?cs call:class_table("Exceptions", package.exceptions) ?>
    <?cs call:class_table("Errors", package.errors) ?>

</div>
<?cs include:"partials/sidebar-page-bottom.cs" ?>