# Sentinel-Controlled Average Calculator

A clean C# console application that continuously accepts integer inputs from a user, aggregating their sum and tallying the entry count. The loop terminates immediately when the user inputs the sentinel value `-1`, after which the program displays the total sum and calculated mathematical average.

## 🎯 Project Objectives
* Utilize a `do-while` loop structure for dynamic user collection.
* Track cumulative states using mathematical addition operations.
* Correctly exclude the sentinel loop-termination value (`-1`) from final calculation results.
* Safely calculate and output floating-point divisions.

## 🛠️ Technical Highlights
* **Block Execution Safety:** Corrected conditional grouping scopes with explicit curly braces to prevent incorrect increments of the tracking counter.
* **Type-Cast Precision:** Casts integer sums to `double` elements during division, avoiding standard C# integer truncation bugs.
* **Division by Zero Protection:** Uses logical condition blocks to check if any valid entries exist before executing average divisions, keeping the runtime execution entirely crash-proof.

## 🚀 How to Run
1. Open the source file in your IDE.
2. Build and run.
3. Input numbers to accumulate values, then input `-1` to view your final sum and average outputs.