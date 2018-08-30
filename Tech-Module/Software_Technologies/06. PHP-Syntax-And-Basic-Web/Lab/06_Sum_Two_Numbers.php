<DOCTYPE html>
    <html>
    <head>
        <title>Sum Two Numbers</title>
    </head>
    <body>
    <form>
        First Number:
        <br><input type="number" name="firstNumber"><br>
        Second Number:
        <br><input type="number" name="secondNumber"><br>
        <input type="submit"><br>

        <?php
        if (isset($_GET['firstNumber']) && $_GET['secondNumber']) {
            $firstNum = intval($_GET["firstNumber"]);
            $secondNum = intval($_GET["secondNumber"]);
            $calculate = $firstNum + $secondNum;

            echo "$firstNum + $secondNum = $calculate";
        }
        ?>

    </form>
    </body>
    </html>

