// I showed creativity by adding a Remove Goal feature so that the user can remove unwanted on completed goals to keep the list from bloating.

using System;

class Program
{
    static void Main(string[] args)
    {
        String choice;
        int totalPoints = 0;
        List<Goal> goals = new List<Goal>();

        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Remove Goal");
            Console.WriteLine("  7. Quit");

            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            Console.Clear();

            if (choice == "1")
            {
                goals.Add(CreateNewGoal());
            }
            else if (choice == "2")
            {
                ListGoals(goals);
            }
            else if (choice == "3")
            {
                SaveGoals(goals, totalPoints);
            }
            else if (choice == "4")
            {
                (goals, totalPoints) = LoadGoals();
            }
            else if (choice == "5")
            {
                totalPoints = RecordEvent(goals, totalPoints);
            }
            else if (choice == "6")
            {
                goals = RemoveGoal(goals);
            }
            else if (choice == "7")
            {
                Console.WriteLine("Goodbye");
                break;
            }
        }
    }
    
    static Goal CreateNewGoal()
    {   
        String choice;

        while (true)
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");

            Console.Write("What type of goal would you like to create? ");
            choice = Console.ReadLine();
            Console.Clear();

            Console.Write("What is the name of your goal? ");
            String title = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            String description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (choice == "1")
            {
                SimpleGoal newGoal = new SimpleGoal(title, description, points);
                return newGoal;
            }
            else if (choice == "2")
            {
                EternalGoal newGoal = new EternalGoal(title, description, points);
                return newGoal;
            }
            else if (choice == "3")
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int compleationGoal = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int compleationPoints = int.Parse(Console.ReadLine());

                ChecklistGoal newGoal = new ChecklistGoal(title, description, points, compleationGoal, compleationPoints);
                return newGoal;
            }
            else
            {
                Console.WriteLine("ERROR: invalid goal type");
                Console.WriteLine();
            }
        }
    }

    static void ListGoals(List<Goal> goals)
    {
        int num = 0;

        foreach (Goal g in goals)
        {
            num += 1;
            Console.Write($"{num}.");
            g.Display();
        }

        Console.WriteLine();
    }

    static int RecordEvent(List<Goal> goals, int totalPoints)
    {
        int choice;
        int points;

        while (true)
        {
            ListGoals(goals);
            Console.Write("Which goal did you accomplish? ");
            choice = int.Parse(Console.ReadLine()) - 1;

            if (choice < 0 | choice >= goals.Count)
            {
                Console.WriteLine("ERROR: invalid choice");
            }
            else
            {
                points = goals[choice].ScoreGoal();

                Console.WriteLine($"Congratulations! You have earned {points} points!");
                
                totalPoints += points;
                Console.WriteLine($"You now have {totalPoints} points!");
                Console.WriteLine();

                return totalPoints;
            }
        }
    }

    static List<Goal> RemoveGoal(List<Goal> goals)
    {
        int choice;
        
        ListGoals(goals);
        Console.Write("Which goal would you like to remove (select 0 to keep all goals)? ");
        choice = int.Parse(Console.ReadLine()) - 1;

        if (choice == -1)
        {}
        else if (choice < goals.Count())
        {
            goals.RemoveAt(choice);
        }
        return goals;
    }

    static void SaveGoals(List<Goal> goals, int points)
    {
        String filename;

        Console.Clear();
        Console.Write("What is the filename for the goal file? ");
        filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(points);
            
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.GetSaveString());
            }
        }

        Console.WriteLine("Goals Saved");
        Console.WriteLine();
    }

    static (List<Goal>, int) LoadGoals()
    {
        List<Goal> goals = new List<Goal>();
        int points = 0;

        String filename;
        Console.Write("What is the filename for the goal file? ");
        filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            

            if (parts.Count() == 1)
            {
                points = int.Parse(line);
            }
            else
            {
                string[] goalParts = parts[1].Split("`");
                if(parts[0] == "SimpleGoal")
                {
                    String title = goalParts[0];
                    String description = goalParts[1];
                    int score = int.Parse(goalParts[2]);
                    Boolean completed = Boolean.Parse(goalParts[3]);

                    goals.Add(new SimpleGoal(title, description, score, completed));
                }
                else if(parts[0] == "EternalGoal")
                {
                    String title = goalParts[0];
                    String description = goalParts[1];
                    int score = int.Parse(goalParts[2]);

                    goals.Add(new EternalGoal(title, description, score));
                }
                else if(parts[0] == "ChecklistGoal")
                {
                    String title = goalParts[0];
                    String description = goalParts[1];
                    int score = int.Parse(goalParts[2]);
                    int compleationGoal = int.Parse(goalParts[3]);
                    int compleationPoints = int.Parse(goalParts[5]);
                    int timesCompleted = int.Parse(goalParts[4]);

                    goals.Add(new ChecklistGoal(title, description, score, compleationGoal, compleationPoints, timesCompleted));
                }
            }
        }

        Console.WriteLine("Goals Loaded");
        Console.WriteLine();

        return (goals, points);
    }
}