<DOCTYPE html>
    <html>
    <head>
        <title>Sort Lines</title>
    </head>
    <body>
    <form>
        <textarea rows="10" name="text"></textarea><br>
        <input type="submit" value="Extract">
    </form>
    </body>
    </html>
</DOCTYPE>

<?php $sortedLines = "";
if (isset($_GET['text'])) {
    $lines = explode("\n", $_GET['text']);
    $lines = array_map('trim', $lines);
    sort($lines, SORT_STRING);

    echo $sortedLines = implode("\n", $lines);
}
?>