# Number Classification Counter

A simple C# console application that prompts the user to enter 10 numbers (integers or decimals) and counts how many of those inputs are positive, negative, or zero.

## 🎯 Project Objectives
* Utilize a `for` loop to capture exactly 10 user inputs.
* Cleanly handle decimal-point inputs using robust data types.
* Use nested `if-else` decision trees to classify numeric inputs.
* Print formatted counts using escape characters (`\t` and `\n`).

## 🛠️ Technical Highlights
* **Precise Iteration control:** Designed the loop range to execute exactly 10 times, avoiding common off-by-one errors.
* **Memory-Appropriate Types:** Uses `double` for input numbers to accommodate decimals, while using lightweight `int` values for category counters.
* **Branching Optimization:** Simplified the conditional chain by utilizing a trailing `else` block for negative numbers instead of evaluating a redundant logical condition.

## 🚀 How to Run
1. Open the file in Visual Studio or VS Code.
2. Run the application.
3. Input any 10 numbers of your choice to see the final tally.