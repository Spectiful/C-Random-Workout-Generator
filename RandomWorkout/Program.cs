using System;

namespace RandomWorkout
{
    internal class Program
    {
        static void Upperbody()
        {
            string[] upperbody = { "Bicep curls", "Hammer curls", "Overhead press", "Bench press", "Chest press", "Overhead triceps extensions", "Front lateral raise", "Side lateral raise", "Chest flyes", "Pullups" };

            Random rand = new Random();
            int randupper1 = rand.Next(upperbody.Length);
            int randupper2 = rand.Next(upperbody.Length);
            int randupper3 = rand.Next(upperbody.Length);
            int randupper4 = rand.Next(upperbody.Length);

            bool rpupper = true;
            while (rpupper)
            {
                Console.WriteLine("\nYou chose upper body");
                Console.WriteLine("What strength level will you lift? Select 1-3 for the options. \n1.Light \n2.Medium \n3.Heavy");
                int wostrength = Convert.ToInt32(Console.ReadLine());
                switch (wostrength)
                {
                    case 1:
                        bool rpset = true;
                        while (rpset)
                        {
                            Console.WriteLine("\nYou choose to lift light.");
                            Console.WriteLine("How many sets will you do? Choose between 3-5");
                            int wosets = Convert.ToInt32(Console.ReadLine());
                            if (wosets >= 3 && wosets <= 5)
                            {
                                bool rprep = true;
                                while (rprep)
                                {
                                    Console.WriteLine("\nHow many reps will you do? Choose reps between 12-20");
                                    int woreps = Convert.ToInt32(Console.ReadLine());
                                    if (woreps >= 12 && woreps <= 20)
                                    {
                                        bool rpexercises = true;
                                        while (rpexercises)
                                        {
                                            Console.WriteLine("\nHow many excercises? Choose between 3 or 4");
                                            int woexercise = Convert.ToInt32(Console.ReadLine());
                                            if (woexercise == 3)
                                            {
                                                Console.WriteLine("\n" + upperbody[randupper1] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(upperbody[randupper2] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(upperbody[randupper3] + " " + wosets + "x" + woreps);
                                                return;
                                            }
                                            if (woexercise == 4)
                                            {
                                                Console.WriteLine("\n" + upperbody[randupper1] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(upperbody[randupper2] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(upperbody[randupper3] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(upperbody[randupper4] + " " + wosets + "x" + woreps);
                                                return;
                                            }
                                            if (!(woexercise == 3 || woexercise == 4))
                                            {
                                                Console.WriteLine("Please choose the correct number.");
                                                rpexercises = true;
                                            }
                                        }
                                    }
                                    if (!(woreps >= 12 && woreps <= 20))
                                    {
                                        Console.WriteLine("Please choose reps between 12-20");
                                        rprep = true;
                                    }
                                }
                            }
                            if (!(wosets >= 3 && wosets <= 5))
                            {
                                Console.WriteLine("Please choose sets between 3-5");
                                rpset = true;
                            }
                        }
                        break;

                    case 2:
                        bool rpsetmed = true;
                        while (rpsetmed)
                        {
                            Console.WriteLine("\nYou choose to lift medium.");
                            Console.WriteLine("How many sets will you do? Choose between 3-4");
                            int wosets = Convert.ToInt32(Console.ReadLine());
                            if (wosets >= 3 && wosets <= 4)
                            {
                                bool rprep = true;
                                while (rprep)
                                {
                                    Console.WriteLine("\nHow many reps will you do? Choose reps between 8-10");
                                    int woreps = Convert.ToInt32(Console.ReadLine());
                                    if (woreps >= 8 && woreps <= 10)
                                    {
                                        bool rpexercises = true;
                                        while (rpexercises)
                                        {
                                            Console.WriteLine("\nHow many excercises? Choose between 3 or 4");
                                            int woexercise = Convert.ToInt32(Console.ReadLine());
                                            if (woexercise == 3)
                                            {
                                                Console.WriteLine("\n" + upperbody[randupper1] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(upperbody[randupper2] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(upperbody[randupper3] + " " + wosets + "x" + woreps);
                                                return;
                                            }
                                            if (woexercise == 4)
                                            {
                                                Console.WriteLine("\n" + upperbody[randupper1] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(upperbody[randupper2] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(upperbody[randupper3] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(upperbody[randupper4] + " " + wosets + "x" + woreps);
                                                return;
                                            }
                                            if (!(woexercise == 3 || woexercise == 4))
                                            {
                                                Console.WriteLine("Please choose the correct number.");
                                                rpexercises = true;
                                            }
                                        }
                                    }
                                    if (!(woreps >= 8 && woreps <= 10))
                                    {
                                        Console.WriteLine("Please choose reps between 12-20");
                                        rprep = true;
                                    }
                                }
                            }
                            if (!(wosets >= 3 && wosets <= 4))
                            {
                                Console.WriteLine("Please choose sets between 3-5");
                                rpset = true;
                            }
                        }
                        break;

                    case 3:
                        bool rpsethvy = true;
                        while (rpsethvy)
                        {
                            Console.WriteLine("\nYou choose to lift heavy.");
                            Console.WriteLine("For heavy lifting, It's recommended to do sets of 3");
                            int wosets = 3;

                            bool rprep = true;
                            while (rprep)
                            {
                                Console.WriteLine("\nHow many reps will you do? Choose reps between 3-5");
                                int woreps = Convert.ToInt32(Console.ReadLine());
                                if (woreps >= 3 && woreps <= 5)
                                {
                                    bool rpexercises = true;
                                    while (rpexercises)
                                    {
                                        Console.WriteLine("\nHow many excercises? Choose between 3 or 4");
                                        int woexercise = Convert.ToInt32(Console.ReadLine());
                                        if (woexercise == 3)
                                        {
                                            Console.WriteLine("\n" + upperbody[randupper1] + " " + wosets + "x" + woreps);
                                            Console.WriteLine(upperbody[randupper2] + " " + wosets + "x" + woreps);
                                            Console.WriteLine(upperbody[randupper3] + " " + wosets + "x" + woreps);
                                            return;
                                        }
                                        if (woexercise == 4)
                                        {
                                            Console.WriteLine("\n" + upperbody[randupper1] + " " + wosets + "x" + woreps);
                                            Console.WriteLine(upperbody[randupper2] + " " + wosets + "x" + woreps);
                                            Console.WriteLine(upperbody[randupper3] + " " + wosets + "x" + woreps);
                                            Console.WriteLine(upperbody[randupper4] + " " + wosets + "x" + woreps);
                                            return;
                                        }
                                        if (!(woexercise == 3 || woexercise == 4))
                                        {
                                            Console.WriteLine("Please choose the correct number.");
                                            rpexercises = true;
                                        }
                                    }
                                }
                                if (!(woreps >= 3 && woreps <= 5))
                                {
                                    Console.WriteLine("Please choose reps between 3-5");
                                    rprep = true;
                                }
                            }
                        }
                        break;
                }
            }
        }

        static void Lowerbody()
        {
            string[] lowerbody = { "Squats", "Deadlift", "Roman deadlifts (RDL)", "Deadlifts", "Lunges", "Side lunges", "Bulgarian split squat", "Goblet squats", "Sumo squats", "Calf raises" };

            Random lb = new Random();
            int randlower1 = lb.Next(lowerbody.Length);
            int randlower2 = lb.Next(lowerbody.Length);
            int randlower3 = lb.Next(lowerbody.Length);
            int randlower4 = lb.Next(lowerbody.Length);

            bool rplower = true;
            while (rplower)
            {
                Console.WriteLine("\nYou chose lower body");
                Console.WriteLine("What strength level will you lift? Select 1-3 for the options. \n1.Light \n2.Medium \n3.Heavy");
                int wostrength = Convert.ToInt32(Console.ReadLine());
                switch (wostrength)
                {
                    case 1:
                        bool rpset = true;
                        while (rpset)
                        {
                            Console.WriteLine("\nYou choose to lift light.");
                            Console.WriteLine("How many sets will you do? Choose between 3-5");
                            int wosets = Convert.ToInt32(Console.ReadLine());

                            if (wosets >= 3 && wosets <= 5)
                            {
                                bool rprep = true;
                                while (rprep)
                                {
                                    Console.WriteLine("\nHow many reps will you do? Choose reps between 12-20");
                                    int woreps = Convert.ToInt32(Console.ReadLine());
                                    if (woreps >= 12 && woreps <= 20)
                                    {
                                        bool rpexercises = true;
                                        while (rpexercises)
                                        {
                                            Console.WriteLine("\nHow many excercises? Choose between 3 or 4");
                                            int woexercise = Convert.ToInt32(Console.ReadLine());
                                            if (woexercise == 3)
                                            {
                                                Console.WriteLine("\n" + lowerbody[randlower1] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(lowerbody[randlower2] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(lowerbody[randlower3] + " " + wosets + "x" + woreps);
                                                return;
                                            }
                                            if (woexercise == 4)
                                            {
                                                Console.WriteLine("\n" + lowerbody[randlower1] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(lowerbody[randlower2] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(lowerbody[randlower3] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(lowerbody[randlower4] + " " + wosets + "x" + woreps);
                                                return;
                                            }
                                            if (!(woexercise == 3 || woexercise == 4))
                                            {
                                                Console.WriteLine("Please choose the correct number.");
                                                rpexercises = true;
                                            }
                                        }
                                    }
                                    if (!(woreps >= 12 && woreps <= 20))
                                    {
                                        Console.WriteLine("Please choose reps between 12-20");
                                        rprep = true;
                                    }
                                }
                            }
                            if (!(wosets >= 3 && wosets <= 5))
                            {
                                Console.WriteLine("Please choose sets between 3-5");
                                rpset = true;
                            }
                        }
                        break;

                    case 2:
                        bool rpsetmed = true;
                        while (rpsetmed)
                        {
                            Console.WriteLine("\nYou choose to lift medium.");
                            Console.WriteLine("How many sets will you do? Choose between 3-4");
                            int wosets = Convert.ToInt32(Console.ReadLine());
                            if (wosets >= 3 && wosets <= 4)
                            {
                                bool rprep = true;
                                while (rprep)
                                {
                                    Console.WriteLine("\nHow many reps will you do? Choose reps between 8-10");
                                    int woreps = Convert.ToInt32(Console.ReadLine());
                                    if (woreps >= 8 && woreps <= 10)
                                    {
                                        bool rpexercises = true;
                                        while (rpexercises)
                                        {
                                            Console.WriteLine("\nHow many exercises? Choose between 3 or 4");
                                            int woexercise = Convert.ToInt32(Console.ReadLine());
                                            if (woexercise == 3)
                                            {
                                                Console.WriteLine("\n" + lowerbody[randlower1] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(lowerbody[randlower2] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(lowerbody[randlower3] + " " + wosets + "x" + woreps);
                                                return;
                                            }
                                            if (woexercise == 4)
                                            {
                                                Console.WriteLine("\n" + lowerbody[randlower1] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(lowerbody[randlower2] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(lowerbody[randlower3] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(lowerbody[randlower4] + " " + wosets + "x" + woreps);
                                                return;
                                            }
                                            if (!(woexercise == 3 || woexercise == 4))
                                            {
                                                Console.WriteLine("Please choose the correct number.");
                                                rpexercises = true;
                                            }
                                        }
                                    }
                                    if (!(woreps >= 12 && woreps <= 20))
                                    {
                                        Console.WriteLine("Please choose reps between 8-10");
                                        rprep = true;
                                    }
                                }
                            }
                            if (!(wosets >= 3 && wosets <= 4))
                            {
                                Console.WriteLine("Please choose sets between 3-4");
                                rpset = true;
                            }
                        }
                        break;

                    case 3:
                        bool rpsethvy = true;
                        while (rpsethvy)
                        {
                            Console.WriteLine("\nYou choose to lift heavy.");
                            Console.WriteLine("For heavy lifting, It's recommended to do sets of 3");
                            int wosets = 3;

                            bool rprep = true;
                            while (rprep)
                            {
                                Console.WriteLine("\nHow many reps will you do? Choose reps between 3-5");
                                int woreps = Convert.ToInt32(Console.ReadLine());
                                if (woreps >= 3 && woreps <= 5)
                                {
                                    bool rpexercises = true;
                                    while (rpexercises)
                                    {
                                        Console.WriteLine("\nHow many excercises? Choose between 3 or 4");
                                        int woexercise = Convert.ToInt32(Console.ReadLine());
                                        if (woexercise == 3)
                                        {
                                            Console.WriteLine("\n" + lowerbody[randlower1] + " " + wosets + "x" + woreps);
                                            Console.WriteLine(lowerbody[randlower2] + " " + wosets + "x" + woreps);
                                            Console.WriteLine(lowerbody[randlower3] + " " + wosets + "x" + woreps);
                                            return;
                                        }
                                        if (woexercise == 4)
                                        {
                                            Console.WriteLine("\n" + lowerbody[randlower1] + " " + wosets + "x" + woreps);
                                            Console.WriteLine(lowerbody[randlower2] + " " + wosets + "x" + woreps);
                                            Console.WriteLine(lowerbody[randlower3] + " " + wosets + "x" + woreps);
                                            Console.WriteLine(lowerbody[randlower4] + " " + wosets + "x" + woreps);
                                            return;
                                        }
                                        if (!(woexercise == 3 || woexercise == 4))
                                        {
                                            Console.WriteLine("Please choose the correct number.");
                                            rpexercises = true;
                                        }
                                    }
                                }
                                if (!(woreps >= 3 && woreps <= 5))
                                {
                                    Console.WriteLine("Please choose reps between 3-5");
                                    rprep = true;
                                }
                            }
                        }
                        break;
                }
            }
        }

        static void Fullbody()
        {
            string[] fullbody = { "Bicep curls", "Hammer curls", "Overhead press", "Bench press", "Chest press", "Overhead triceps extensions", "Front lateral raise", "Side lateral raise", "Chest flyes", "Pullups", "Squats", "Deadlift", "Roman deadlifts (RDL)", "Deadlifts", "Lunges", "Side lunges", "Bulgarian split squat", "Goblet squats", "Sumo squats", "Calf raises" };

            Random fb = new Random();
            int randfullbody1 = fb.Next(fullbody.Length);
            int randfullbody2 = fb.Next(fullbody.Length);
            int randfullbody3 = fb.Next(fullbody.Length);
            int randfullbody4 = fb.Next(fullbody.Length);

            bool rpfullbody = true;
            while (rpfullbody)
            {
                Console.WriteLine("\nYou chose full body");
                Console.WriteLine("What strength level will you lift? Select 1-3 for the options. \n1.Light \n2.Medium \n3.Heavy");
                int wostrength = Convert.ToInt32(Console.ReadLine());
                switch (wostrength)
                {
                    case 1:
                        bool rpset = true;
                        while (rpset)
                        {
                            Console.WriteLine("\nYou choose to lift light.");
                            Console.WriteLine("How many sets will you do? Choose between 3-5");
                            int wosets = Convert.ToInt32(Console.ReadLine());
                            if (wosets >= 3 && wosets <= 5)
                            {
                                bool rprep = true;
                                while (rprep)
                                {
                                    Console.WriteLine("\nHow many reps will you do? Choose reps between 12-20");
                                    int woreps = Convert.ToInt32(Console.ReadLine());
                                    if (woreps >= 12 && woreps <= 20)
                                    {
                                        bool rpexercises = true;
                                        while (rpexercises)
                                        {
                                            Console.WriteLine("\nHow many exercises? Choose between 3 or 4");
                                            int woexercise = Convert.ToInt32(Console.ReadLine());
                                            if (woexercise == 3)
                                            {
                                                Console.WriteLine("\n" + fullbody[randfullbody1] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(fullbody[randfullbody2] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(fullbody[randfullbody3] + " " + wosets + "x" + woreps);
                                                return;
                                            }
                                            if (woexercise == 4)
                                            {
                                                Console.WriteLine("\n" + fullbody[randfullbody1] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(fullbody[randfullbody2] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(fullbody[randfullbody3] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(fullbody[randfullbody4] + " " + wosets + "x" + woreps);
                                                return;
                                            }
                                            if (!(woexercise == 3 || woexercise == 4))
                                            {
                                                Console.WriteLine("Please choose the correct number.");
                                                rpexercises = true;
                                            }
                                        }
                                    }
                                    if (!(woreps >= 12 && woreps <= 20))
                                    {
                                        Console.WriteLine("Please choose reps between 12-20");
                                        rprep = true;
                                    }
                                }
                            }
                            if (!(wosets >= 3 && wosets <= 5))
                            {
                                Console.WriteLine("Please choose sets between 3-5");
                                rpset = true;
                            }
                        }
                        break;

                    case 2:
                        bool rpsetmed = true;
                        while (rpsetmed)
                        {
                            Console.WriteLine("\nYou choose to lift medium.");
                            Console.WriteLine("How many sets will you do? Choose between 3-4");
                            int wosets = Convert.ToInt32(Console.ReadLine());
                            if (wosets >= 3 && wosets <= 4)
                            {
                                bool rprep = true;
                                while (rprep)
                                {
                                    Console.WriteLine("\nHow many reps will you do? Choose reps between 8-10");
                                    int woreps = Convert.ToInt32(Console.ReadLine());
                                    if (woreps >= 8 && woreps <= 10)
                                    {
                                        bool rpexercises = true;
                                        while (rpexercises)
                                        {
                                            Console.WriteLine("\nHow many exercises? Choose between 3 or 4");
                                            int woexercise = Convert.ToInt32(Console.ReadLine());
                                            if (woexercise == 3)
                                            {
                                                Console.WriteLine("\n" + fullbody[randfullbody1] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(fullbody[randfullbody2] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(fullbody[randfullbody3] + " " + wosets + "x" + woreps);
                                                return;
                                            }
                                            if (woexercise == 4)
                                            {
                                                Console.WriteLine("\n" + fullbody[randfullbody1] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(fullbody[randfullbody2] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(fullbody[randfullbody3] + " " + wosets + "x" + woreps);
                                                Console.WriteLine(fullbody[randfullbody4] + " " + wosets + "x" + woreps);
                                                return;
                                            }
                                            if (!(woexercise == 3 || woexercise == 4))
                                            {
                                                Console.WriteLine("Please choose the correct number.");
                                                rpexercises = true;
                                            }
                                        }
                                    }
                                    if (!(woreps >= 12 && woreps <= 20))
                                    {
                                        Console.WriteLine("Please choose reps between 8-10");
                                        rprep = true;
                                    }
                                }
                            }
                            if (!(wosets >= 3 && wosets <= 4))
                            {
                                Console.WriteLine("Please choose sets between 3-4");
                                rpset = true;
                            }
                        }
                        break;

                    case 3:
                        bool rpsethvy = true;
                        while (rpsethvy)
                        {
                            Console.WriteLine("\nYou choose to lift heavy.");
                            Console.WriteLine("For heavy lifting, It's recommended to do sets of 3");
                            int wosets = 3;

                            bool rprep = true;
                            while (rprep)
                            {
                                Console.WriteLine("\nHow many reps will you do? Choose reps between 3-5");
                                int woreps = Convert.ToInt32(Console.ReadLine());
                                if (woreps >= 3 && woreps <= 5)
                                {
                                    bool rpexercises = true;
                                    while (rpexercises)
                                    {
                                        Console.WriteLine("\nHow many excercises? Choose between 3 or 4");
                                        int woexercise = Convert.ToInt32(Console.ReadLine());
                                        if (woexercise == 3)
                                        {
                                            Console.WriteLine("\n" + fullbody[randfullbody1] + " " + wosets + "x" + woreps);
                                            Console.WriteLine(fullbody[randfullbody2] + " " + wosets + "x" + woreps);
                                            Console.WriteLine(fullbody[randfullbody3] + " " + wosets + "x" + woreps);
                                            return;
                                        }
                                        if (woexercise == 4)
                                        {
                                            Console.WriteLine("\n" + fullbody[randfullbody1] + " " + wosets + "x" + woreps);
                                            Console.WriteLine(fullbody[randfullbody2] + " " + wosets + "x" + woreps);
                                            Console.WriteLine(fullbody[randfullbody3] + " " + wosets + "x" + woreps);
                                            Console.WriteLine(fullbody[randfullbody4] + " " + wosets + "x" + woreps);
                                            return;
                                        }
                                        if (!(woexercise == 3 || woexercise == 4))
                                        {
                                            Console.WriteLine("Please choose the correct number.");
                                            rpexercises = true;
                                        }
                                    }
                                }
                                if (!(woreps >= 3 && woreps <= 5))
                                {
                                    Console.WriteLine("Please choose reps between 3-5");
                                    rprep = true;
                                }
                            }
                        }
                        break;
                }
            }
        }

        public static void Main(string[] args)
        {
            bool repeatcode = true;
            while (repeatcode)
            {
                Console.WriteLine("      *********C# RANDOM WORKOUT GENERATOR*********    ");
                Console.WriteLine("What kind of workout would you want? \nSelect the following by entering between 1-3 \n1.Upper Body \n2.Lower Body \n3.Full body");
                int wotype = Convert.ToInt32(Console.ReadLine());
                if (wotype == 1)
                {
                    Upperbody();
                }
                if (wotype == 2)
                {
                    Lowerbody();
                }
                if (wotype == 3)
                {
                    Fullbody();
                }

                if (wotype != 1 && wotype != 2 && wotype != 3)
                {
                    Console.WriteLine("Please choose the correct option. \n");
                }

                Console.WriteLine("Start Over? Enter Y/y for yes or N/n for no");
                string pick = Console.ReadLine();

                if (pick == "N" || pick == "n")
                {
                    Console.WriteLine("Thank you for using the workout program!");
                    repeatcode = false;
                }

                if (pick == "Y" || pick == "y")
                {
                    repeatcode = true;
                }
            }
        }
    }
}

