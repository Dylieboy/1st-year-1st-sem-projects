# Student Score Histogram

A simple C# Console Application that reads student scores, displays a histogram using asterisks (`*`), and calculates the average score.

---

## Features

- Accepts any number of student scores.
- Stores scores in an integer array.
- Displays each score as a histogram.
- Calculates the average score.
- Includes input validation to prevent crashes from invalid input.

---

## Example

### Input

```
How many student scores are you going to read in: 5

Enter student 1 score: 6
Enter student 2 score: 9
Enter student 3 score: 12
Enter student 4 score: 3
Enter student 5 score: 15
```

### Output

```
Histogram
---------

****** 6
********* 9
************ 12
*** 3
*************** 15

-------------------------
Average score: 9.00
```

---

## Concepts Demonstrated

- Arrays
- For loops
- Foreach loops
- Input validation using `TryParse()`
- String constructor (`new string('*', number)`)
- Basic statistics (average)

---

## Requirements

- .NET Framework or .NET SDK
- Visual Studio 2022

---

## How to Run

1. Open the project in Visual Studio.
2. Press **Ctrl + F5** or click **Start Without Debugging**.
3. Enter the number of student scores.
4. Enter each student's score.
5. View the histogram and average.

---

## Possible Improvements

- Limit scores to a maximum value (e.g., 15).
- Display the highest and lowest score.
- Sort the scores before displaying.
- Show the median and mode.
- Use different characters instead of `*`.
- Display the histogram vertically.