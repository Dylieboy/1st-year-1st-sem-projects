using System;

namespace Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examAssignments = 5;

            string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

            int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
            int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
            int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
            int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

            // We don't need to pre-allocate an empty array size 10 here anymore!
            int[] studentScores;

            Console.Clear();
            Console.WriteLine("Student\t\tExam Score\tOverall\tGrade\t\tExtra Credit\n");

            foreach (string name in studentNames)
            {
                // Clean and standard if/else chain to assign the correct array
                if (name == "Sophia")
                {
                    studentScores = sophiaScores;
                }
                else if (name == "Andrew")
                {
                    studentScores = andrewScores;
                }
                else if (name == "Emma")
                {
                    studentScores = emmaScores;
                }
                else
                {
                    studentScores = loganScores;
                }

                int examScoreSum = 0;
                int extraCreditSum = 0;
                int extraCreditCount = 0;
                int gradedAssignments = 0;

                // SINGLE LOOP: We calculate both exam totals and extra credit in one go!
                foreach (int score in studentScores)
                {
                    gradedAssignments++;

                    if (gradedAssignments <= examAssignments)
                    {
                        examScoreSum += score;
                    }
                    else
                    {
                        extraCreditSum += score;
                        extraCreditCount++;
                    }
                }

                // Math calculations using (decimal) casting to prevent integer division bugs
                decimal averageExam = (decimal)examScoreSum / examAssignments;

                decimal averageExtraCredit = 0;
                if (extraCreditCount > 0)
                {
                    averageExtraCredit = (decimal)extraCreditSum / extraCreditCount;
                }

                // Extra credit is worth 10% of an exam score
                decimal currentStudentGrade = (examScoreSum + ((decimal)extraCreditSum / 10)) / examAssignments;
                decimal extraCreditPointsContribution = currentStudentGrade - averageExam;

                // Simple, classic if/else chain for grades
                string currentStudentLetterGrade = "";

                if (currentStudentGrade >= 97)
                    currentStudentLetterGrade = "A+";
                else if (currentStudentGrade >= 93)
                    currentStudentLetterGrade = "A";
                else if (currentStudentGrade >= 90)
                    currentStudentLetterGrade = "A-";
                else if (currentStudentGrade >= 87)
                    currentStudentLetterGrade = "B+";
                else if (currentStudentGrade >= 83)
                    currentStudentLetterGrade = "B";
                else if (currentStudentGrade >= 80)
                    currentStudentLetterGrade = "B-";
                else if (currentStudentGrade >= 77)
                    currentStudentLetterGrade = "C+";
                else if (currentStudentGrade >= 73)
                    currentStudentLetterGrade = "C";
                else if (currentStudentGrade >= 70)
                    currentStudentLetterGrade = "C-";
                else if (currentStudentGrade >= 67)
                    currentStudentLetterGrade = "D+";
                else if (currentStudentGrade >= 63)
                    currentStudentLetterGrade = "D";
                else if (currentStudentGrade >= 60)
                    currentStudentLetterGrade = "D-";
                else
                    currentStudentLetterGrade = "F";

                // Formatted Output (using :F1 and :F2 to round decimals perfectly)
                Console.WriteLine($"{name}\t\t{averageExam:F1}\t\t{currentStudentGrade:F2}\t{currentStudentLetterGrade}\t\t{averageExtraCredit:F1} ({extraCreditPointsContribution:F2} pts)");
            }

            Console.WriteLine("\nPress the Enter key to continue");
            Console.ReadLine();
        }
    }
}