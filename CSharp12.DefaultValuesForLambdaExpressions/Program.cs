


var addWithDefault = (int addTo = 2) => addTo + 1;

var sum = (params int[] numbers) => numbers.Sum();


_ = addWithDefault(); // 3

_ = addWithDefault(5); // 6

_ = sum(); // 0

_ = sum(1, 2, 3);  // 6