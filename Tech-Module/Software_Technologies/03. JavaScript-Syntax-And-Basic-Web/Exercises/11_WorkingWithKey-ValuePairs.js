function keyValuePairs(arr) {

    let obj = {};

    for (let i = 0; i < arr.length; i++) {

        let [ currentKey, currentValue ] = arr[i].split(' ');

        if (currentValue === undefined) {
            if(currentKey in obj) {
                return obj[currentKey];
            }
            else {
                return "None"
            }
        }

        obj[currentKey] = currentValue;
    }
}

console.log(keyValuePairs(['3 test',
    '3 test1',
    '4 test2',
    '4 test3',
    '4 test5',
    '4']));