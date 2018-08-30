function turnObjectIntoJSONString(arr) {
    let obj = {};

    for (let i = 0; i < arr.length; i++) {
        let [key, value] = arr[i].split(' -> ');

        if(key === "grade" || key === "age"){
            obj[key] = Math.round(parseInt(value));
        }

        else {
            obj[key] = value;
        }
    }

    return JSON.stringify(obj);
}

console.log(turnObjectIntoJSONString(['name -> Angel',
    'surname -> Georgiev',
    'age -> 20',
    'grade -> 6.00',
    'date -> 23/05/1995',
    'town -> Sofia']));