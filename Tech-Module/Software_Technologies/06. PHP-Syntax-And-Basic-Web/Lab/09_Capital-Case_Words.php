<DOCTYPE html>
    <html>
    <head>
        <title>
            Capital-Case Words
        </title>
    </head>
    <body>
    <form>
        <textarea rows="10" name="text"></textarea><br>
        <input type="submit" value="Extract">
    </form>
    </body>
    </html>

<?php
if (!empty($_GET['text'])) {
    $str = htmlspecialchars($_GET['text']);
    $check_hash = preg_match_all('/\b([A-Z]+)\b/', $str, $hashtweet);

    foreach($hashtweet[1] as $kvp) {
        echo $kvp . " ";
    }
}
?>