# Restaurant Food Rating System

A console-based feedback application written in C# that prompts users to rate their dining experience. The program uses a structured switch-selection block to evaluate numeric feedback and output corresponding quality indicators.

## 🎯 Project Objectives
* Prompt, read, and store user input as integer values.
* Process conditional selections cleanly using a `switch` block.
* Handle exceptional user inputs gracefully using fallback default cases.

## 🛠️ Technical Highlights
* **Robust Input Validation:** Implements `int.TryParse` to filter out non-numeric inputs (such as letters or empty spaces) and prevent application crashes.
* **Switch-Selection Structure:** Utilizes standard `switch` selection cases to process discrete feedback values (`1` for Good, `2` for Bad) with a `default` catch-all for invalid numbers.
* **Code Cleanliness:** Stripped of all unused namespace imports to ensure a fast compile time and minimal file clutter.

## 🚀 How to Run
1. Open the project in your IDE.
2. Run the program.
3. Enter `1` or `2` to view the rating feedback, or test the crash protection by entering letters!