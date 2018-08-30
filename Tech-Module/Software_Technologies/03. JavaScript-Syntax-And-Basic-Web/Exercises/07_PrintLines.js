function printLines(arr) {
    let currentLineIndex = 0;
    let currentLine = arr[currentLineIndex].toString();

    while ( currentLine !== "Stop") {
        console.log(currentLine);
        currentLineIndex++;
        currentLine = arr[currentLineIndex];
    }
}

printLines(['Line 1',
    'Line 2',
    'Line 3',
    'Stop'
]);