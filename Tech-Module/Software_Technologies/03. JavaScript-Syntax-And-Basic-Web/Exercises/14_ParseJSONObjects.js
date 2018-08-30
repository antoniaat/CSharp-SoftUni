function parseJSONObjects(arr) {
    for (let i = 0; i < arr.length; i++) {
        let {name, age, date} = JSON.parse(arr[i]);

        console.log('Name:', name);
        console.log('Age:', age);
        console.log('Date:', date);
    }
}

parseJSONObjects(['{"name":"Gosho","age":10,"date":"19/06/2005"}',
    '{"name":"Tosho","age":11,"date":"04/04/2005"}']);