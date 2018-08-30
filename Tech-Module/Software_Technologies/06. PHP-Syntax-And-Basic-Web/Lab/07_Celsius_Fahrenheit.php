<DOCTYPE html>
    <html>
    <head>
        <title>Celsius to Fahrenheit</title>
    </head>
    <body>
    <form>s
        Celsius:
        <input type="number" name="celsiusInput">
        <input type="submit" value="Convert">

        Fahrenheit:
        <input type="number" name="fahrenheitInput">
        <input type="submit" value="Convert">
    </form>
    </body>
    </html>
</DOCTYPE>

<?php
if (isset($_GET['celsiusInput'])) {
    $celsiusNum = intval($_GET['celsiusInput']);
    $calculate = 1.8 * $celsiusNum + 32;

    echo "$celsiusNum &degC = $calculate&degF";
} else if (isset($_GET['fahrenheitInput'])) {
    $farenheitNum = intval($_GET['fahrenheitInput']);
    $calculate = (5 / 9) * ($farenheitNum - 32);

    echo "$celsiusNum &degC = $calculate&degF";
}
?>