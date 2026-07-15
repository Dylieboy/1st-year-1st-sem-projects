# Array Manipulation Practice

A C# console application designed to demonstrate fundamental array operations, including dynamic indexing, iterative read-only printing, and direct element mutation.

## 🎯 Project Objectives
* Declare and initialize a single-dimensional integer array.
* Dynamically access the first and last elements of an array of arbitrary size.
* Traverse and print array elements using a read-only `foreach` loop.
* Mutate index values directly using a standard `for` loop and assignment operators (`+=`).

## 🛠️ Technical Highlights
* **Dynamic Boundary Safety:** Replaced the hardcoded index reference `[7]` with `[Length - 1]` to retrieve the last element, protecting the program from `IndexOutOfRangeException` errors if the dataset changes.
* **Separation of Concerns:** Employs a `foreach` loop for printing values safely without risks of accidental mutation, while using a `for` loop specifically where index modification is required.
* **Console Alignment:** Enhanced user presentation with clear labels and double line breaks (`\n`) for clean diagnostic reading.

## 🚀 How to Run
1. Open the project in your preferred IDE.
2. Build and execute.
3. Observe the dynamic index printing and the mathematical transformation of the array.