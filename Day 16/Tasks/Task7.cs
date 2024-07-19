Sarah is working on a project where she needs to compare two arrays to determine if they are equal or not. She's building a program in Java to accomplish this task.

She starts by writing a Java class named ArrayEquality This class contains a main method where she initializes a Scanner object to take input from the user.

When the program runs, it prompts the user to enter the number of elements for the first array.

Next, the program asks for the number of elements for the second array.



The program then uses the Arrays.equals method to compare the two arrays, arr1 and arr2. Since both arrays contain the same elements in the same order, it returns true and returns "Arrays are equal" to the console. otherwise, it returns "Arrays are not equal."



Sample Test Case-1

Enter the number of elements for the first array: 3
Enter the elements for the first array:
23
66
77
Enter the number of elements for the second array: 2
Enter the elements for the second array:
45
66
Arrays are not equal


Sample Test Case-2

Enter the number of elements for the first array: 4
Enter the elements for the first array:
23
24
25
26
Enter the number of elements for the second array: 4
Enter the elements for the second array:
23
24
25
26
Arrays are equal


Sample Test Case-3

Enter the number of elements for the first array: 4
Enter the elements for the first array:
23
12
12
23
Enter the number of elements for the second array: 4
Enter the elements for the second array:
23
45
34
65
Arrays are not equal