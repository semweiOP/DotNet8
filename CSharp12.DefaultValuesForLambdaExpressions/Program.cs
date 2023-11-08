


var addWithDefault = (int addTo = 2) => addTo + 1;

var IncrementBy = (int source, int increment = 1) => source + increment;

var sum = (params int[] numbers) => numbers.Sum();


_ = addWithDefault(); // 3

_ = addWithDefault(5); // 6

_ = IncrementBy(5); // 6

_ = IncrementBy(5, 2); // 7

_ = sum(); // 0

_ = sum(1, 2, 3);  // 6

