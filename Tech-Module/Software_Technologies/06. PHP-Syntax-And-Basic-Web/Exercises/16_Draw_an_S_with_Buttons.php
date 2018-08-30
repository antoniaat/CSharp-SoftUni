<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>

<?php
for ($k = 1; $k <= 5; $k++) {
    echo "<button style='background-color: blue'>1</button>";
}
echo "<br/>\n";

for ($col = 1; $col <= 3; $col++) {
    for ($row = 1; $row <= 5; $row++) {
        if ($row == 1) {
            echo "<button style='background-color: blue'>1</button>";
        } else {
            echo "<button>0</button>";
        }
    }
    echo "<br/>\n";
}

for ($k = 1; $k <= 5; $k++) {
    echo "<button style='background-color: blue'>1</button>";
}
echo "<br/>\n";

for ($col = 1; $col <= 3; $col++) {
    for ($row = 1; $row <= 5; $row++) {
        if ($row == 5) {
            echo "<button style='background-color: blue'>1</button>";
        } else {
            echo "<button>0</button>";
        }
    }
    echo "<br/>\n";
}

for ($k = 1; $k <= 5; $k++) {
    echo "<button style='background-color: blue'>1</button>";
}
echo "<br/>\n";
?>
</body>
</html>