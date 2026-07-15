# Factorial Calculator

A robust C# console application that calculates the factorial of a user-specified positive integer. It displays the calculation step-by-step (e.g., `1 x 2 x 3 x 4 = 24`) and implements overflow-safe data tracking.

## 🎯 Project Objectives
* Accept user integer inputs and validate them safely.
* Implement a `for` loop to compute cumulative products.
* Work with larger integer boundaries using appropriate primitive data types (`long`).
* Correctly handle mathematical edge cases, such as 0! = 1.

## 🛠️ Technical Highlights
* **Mathematical Correctness:** Fixed cumulative addition bugs to execute true factorial multiplication ($n!$).
* **Safe Data Scale (`long` type):** Uses 64-bit signed integers (`long`) instead of standard 32-bit `int` variables, preventing numeric overflow bugs up to $20!$.
* **Robust Input Checks:** Uses `int.TryParse` alongside logic checks to ensure only non-negative integers are processed, preventing run-time execution crashes.

## 🚀 How to Run
1. Open the source file in your IDE.
2. Build and run the project.
3. Enter any positive integer (e.g., `5`) to view its step-by-step factorial breakdown.