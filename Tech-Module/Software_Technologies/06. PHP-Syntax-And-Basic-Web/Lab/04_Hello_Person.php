<DOCTYPE html>
    <html>
    <head>
        <title>Hello, Person!</title>
    </head>
    <body>
    <main>
        <form>
            Name:
            <input type="text" name="person"/>
            <input type="submit">
        </form>
        <?php
        if (isset($_GET["person"])) {
            $personName = htmlspecialchars($_GET["person"]);
            echo "Hello, $personName!";
        }
        ?>
    </main>
    </body>
    </html>

