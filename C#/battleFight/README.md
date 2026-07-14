# Battle Fight Simulator

A lightweight, console-based battle simulator written in C#. This project simulates a turn-based combat encounter between a Hero and a Monster, utilizing basic programming constructs such as game loops, random generation, and conditional branching.

## 🎯 Project Objectives
* Implement an outer game loop using a `while` statement.
* Track and update health metrics for multiple entities (starting at 10 HP).
* Utilize the `System.Random` class to simulate random attack values (1–10).
* Ensure turn-based execution order (Hero always attacks first).
* Apply logic to prevent dead entities from attacking.
* Gracefully determine and print the winner.

## 🛠️ Technical Highlights
* **Optimized Game Loop:** The outer `while` loop continuously checks the health states of both combatants, terminating instantly when either drops to 0.
* **Turn Safety:** Utilizes control flow flow steps (`continue`) to prevent a defeated monster from dealing damage on the same turn it dies.
* **Formatted Output:** Employs `Math.Max(0, health)` to ensure character health displays elegantly as `0` instead of negative numbers upon defeat.

## 🚀 How to Run
1. Open the solution in **Visual Studio** or **VS Code**.
2. Run the application (`F5` or `dotnet run`).
3. Watch the console to see the turn-by-turn combat logs unfold!