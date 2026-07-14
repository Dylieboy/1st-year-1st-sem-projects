# Coin Flip Simulator

A simple C# console game that simulates a standard coin flip five times. It prompts user interaction, randomly rolls a binary result (Heads or Tails), and outputs the result in an easy-to-read layout.

## 🎯 Project Objectives
* Utilize a `do-while` loop to guarantee exactly five game rounds.
* Implement the `System.Random` class to simulate binary outcomes (0 or 1).
* Process user inputs dynamically in a looping console session.
* Minimize memory footprint by structuring random number generation correctly.

## 🛠️ Technical Highlights
* **Static Random Instantiation:** Rather than rebuilding a generator on every single loop iteration (which strains memory and risks seed collision), `Random` is instantiated exactly once outside the loop.
* **Efficient Binary Logic:** Converts the coin outcomes to a strict 0/1 binary state, using a simple conditional branch (`if-else`) to output Heads or Tails.

## 🚀 How to Run
1. Launch the file in your preferred C# IDE.
2. Run the program.
3. Follow the console prompt to type `h` (heads) or `t` (tails) and watch the simulation determine the actual outcome.