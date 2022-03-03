using System;

namespace planHeist
{
    class Program
    {
        static void Main(string[] args)
        {

            //phase 6

            Console.WriteLine("Enter your bank difficulty level");
            int BankDifficultyLevel = int.Parse(Console.ReadLine());

            //phase 2 
            Console.WriteLine("Plan Your Heist!");
            Team HeistTeam = new Team();
            //phase 1

            //phase 3


            do
            {
                Member newMember = new Member();
                Console.WriteLine("Please enter your Team Member's Name.");
                string newMemberName = Console.ReadLine();
                if (newMemberName == "")
                {
                    break;
                }

                else
                {
                    newMember.Name = newMemberName;
                    Console.WriteLine("Please enter Team Member's Skill Level");
                    newMember.SkillLevel = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter Courage Factor's  Level");
                    newMember.CourageFactor = double.Parse(Console.ReadLine());
                    HeistTeam.addMember(newMember);

                }
            } while (true);
            //phase 5
            Console.WriteLine("How many times would you like to try?");
            int trialRuns = int.Parse(Console.ReadLine());
            int successFulRuns = trialRuns;
            for (int i = 1; i <= trialRuns; i++)
            {

                int heistLuckValue = new Random().Next(-10, 11);
                int adjustbankDifficalty=BankDifficultyLevel + heistLuckValue;
                int skill = HeistTeam.TotalSkillLevel();
                Console.WriteLine($"Trial {i}");
                Console.WriteLine($" team's combined skill level: {skill} and the bank difficulty Level:{adjustbankDifficalty}");

                if (adjustbankDifficalty > skill)
                {
                    Console.WriteLine("Heist failed");
                    successFulRuns--;
                }
                else
                {
                    Console.WriteLine("Heist Successful!");

                }
            }
            // had to  the number of tries and the successfulRuns to get the total of Successful runs each try has.

            Console.WriteLine(@$"Successful Run:{successFulRuns} Unsuccessful Run:{trialRuns - successFulRuns}
   ");

        }





    }






}
