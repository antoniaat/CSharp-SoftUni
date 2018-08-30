function removeElements(arr) {

    let array = [];

    for (let i = 0; i < arr.length; i++) {

        let command = arr[i].split(' ');

        if (command[0] === 'add') {
            array.push(command[1]);
        }

        else if (command[0] === 'remove') {
            if (array[command[1]] !== undefined ) {
                array.splice(command[1], 1);
            }
        }
    }

    array = array.filter(Number);

    return array.join('\n');
}

console.log(removeElements(['add 3', 'add 5', 'remove 2', 'remove 0',  'add 7']));