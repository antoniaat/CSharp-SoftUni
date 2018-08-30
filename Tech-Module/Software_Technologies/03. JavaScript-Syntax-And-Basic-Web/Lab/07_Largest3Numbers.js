function largestThreeNumbers(arr) {
    let nums = arr.map(Number);
    let numsSorted = nums.sort((a,b) => (b-a));

    if ( numsSorted.length >= 3 ) {
        for (let i = 0; i < 3; i++) {
            console.log(numsSorted[i]);
        }
    }
    else {
        for (let i = 0; i < numsSorted.length; i++) {
            console.log(numsSorted[i]);
        }
    }
}

largestThreeNumbers(['20', '20', '10'])