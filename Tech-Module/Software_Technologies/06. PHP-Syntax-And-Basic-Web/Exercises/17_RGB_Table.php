<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
    <style>
        table * {
            border: 1px solid black;
            width: 50px;
            height: 50px;
        }
    </style>
</head>
<body>
<table>
    <tr>
        <td>
            Red
        </td>
        <td>
            Green
        </td>
        <td>
            Blue
        </td>
        <?php
        for ($first = 51; $first <= 51 * 6; $first += 51) {
            echo "<tr>";
                 echo "<td style='background-color:rgb($first, 0, 0)'></td>";
                 echo "<td style='background-color:rgb(0, $first, 0)'></td>";
                 echo "<td style='background-color:rgb(0, 0, $first)'></td>";

            echo "</tr>";
        }
        ?>
</table>
</body>
</html>