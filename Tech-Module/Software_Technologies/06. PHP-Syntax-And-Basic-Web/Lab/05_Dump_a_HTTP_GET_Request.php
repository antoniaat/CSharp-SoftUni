<DOCTYPE html>
    <html>
    <head>
        <title>Dump a HTTP GET Request</title>
    </head>
    <body>
    <main>
        <form>
            Name:
            <br><input type="text" name="name"><br>
            Age:
            <br><input type="number" name="age"><br>
            Town:
            <br><select name="town">
                <option value="10">Sofia</option>
                <option value="20">Varna</option>
                <option value="30">Plovdiv</option>
            </select><br>
            <input type="submit">
        </form>
    </main>
    </body>
    </html>

<?php var_dump($_GET); ?>
