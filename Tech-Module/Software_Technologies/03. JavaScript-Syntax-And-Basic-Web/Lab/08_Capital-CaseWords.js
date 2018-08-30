function capitalCaseWords(arr) {
    const str = arr.toString();
    const regex = /\b([A-Z]+)\b/g;
    let matches = str.match(regex);

    console.log(matches.join(", "));
}

capitalCaseWords(['We start by HTML, CSS, JavaScript, JSON and REST.\n' +
'Later we touch some PHP, MySQL and SQL.\n' +
'Later we play with C#, EF, SQL Server and ASP.NET MVC.\n' +
'Finally, we touch some Java, Hibernate and Spring.MVC.']);
