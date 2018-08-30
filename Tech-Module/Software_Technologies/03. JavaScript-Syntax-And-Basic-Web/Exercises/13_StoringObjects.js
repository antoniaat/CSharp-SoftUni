function storingObjects(arr) {
    let obj = {};

    for (let i = 0; i < arr.length; i++) {

        let [currentName, currentAge, currentGrade] = arr[i].split(' -> ');

        console.log('Name:', obj.Name = currentName);
        console.log('Age:', obj.Age = currentAge);
        console.log('Grade:', obj.Grade = currentGrade);
    }
}

console.log(storingObjects(['Pesho -> 13 -> 6.00', 'Ivan -> 12 -> 5.57', 'Toni -> 13 -> 4.90']));