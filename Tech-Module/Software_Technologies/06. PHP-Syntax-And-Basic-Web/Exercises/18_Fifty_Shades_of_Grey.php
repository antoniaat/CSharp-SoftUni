<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
    <style>
        div {
            display: inline-block;
            margin: 5px;
            width: 20px;
            height: 20px;
        }
    </style>
</head>
<body>
<?php
for ($i = 0; $i <= 51 * 5; $i += 51) {
    for ($j = 0; $j < 10 * 5; $j += 5) {
        $firstColor = $i + $j;
        echo "<div style='background-color:rgb($firstColor,$firstColor, $firstColor)'></div>";
    }

    echo "<br>";
}
?>
</body>
</html>