<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8">

    <?cs if:project.name ?>
      <meta name="description" content="Javadoc API documentation for <?cs var:project.name ?>." />
    <?cs else ?>
      <meta name="description" content="Javadoc API documentation." />
    <?cs /if ?>

    <link rel="shortcut icon" type="image/x-icon" href="<?cs var:toroot ?>favicon.ico" />

    <title>
        <?cs if:page.title ?> <?cs var:page.title ?> <?cs /if ?>
        <?cs if:project.name ?> | <?cs var:project.name ?><?cs /if ?>
    </title>

    <link rel="stylesheet" href="http://www.w3schools.com/lib/w3.css">
    <link href="<?cs var:toassets ?>custom.css" rel="stylesheet" type="text/css" />

    <noscript>
      <style type="text/css">
        /*
        TODO do we need alternate style if JS is disabled?
        */
      </style>
    </noscript>
</head>
