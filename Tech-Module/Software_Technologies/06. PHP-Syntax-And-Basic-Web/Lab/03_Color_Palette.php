<DOCTYPE html>
    <html>
    <head>
        <link rel="stylesheet" href="Color_Palette.css">
    </head>
    <body>
    <?php
    for ($first = 0; $first <= 51 * 6; $first += 51) {
        for ($second = 0; $second < 51 * 6; $second += 51) {
            for ($third = 0; $third < 51 * 6; $third += 51) {
                echo "<div style='background:rgb($first, $second, $third)'>rgb($first,$second,$third)</div>";
            }
        }
    }
    ?>
    </body>
    </html>
</DOCTYPE>


