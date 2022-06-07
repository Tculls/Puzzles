
        static void Main(string[] args)
        {
            int[] nums = RandomArray();
            string [] toss = TossCoin();
            double TossMultipleCoins();
            string[] namesArray =
           ShuffleNames(namesArray, rand);
        }
        static int[] RandomArray()
        {
            Random rand = new Random();
            // create an empty array to hold 10 integer values
            int[] numArray = new int[10];
            int min = 25;
            int max = 5;
            int sum = 0;
            // loop through the array
            for (int i = 0; i<10; i++)
            {
                // assign each index a random integer 5-25
                numArray[i] = rand.Next(5,26);
                // add to sum
                sum += numArray[i];
                //  min and max values of that array
                if (numArray[i] < min)
                {
                    min = numArray[i];
                }
                if (numArray[i] > max)
                {
                    max = numArray[i];
                }
            }
            Console.WriteLine($"min: {min}, max: {max}, sum {sum}");
            Console.WriteLine(String.Join(", ", numArray));
            return numArray;
        }

         string[] TossCoin()
        {
            Console.WriteLine("Coin Toss");
            List<string> sides = new List<string> ()
            {
                "Heads",
                "Tails"
            };
            Random rand = new Random();
            return sides;
        }
    

        List<string> names = new List<string>()
        {
            "Todd",
            "Tiffany",
            "Charlie",
            "Geneva",
            "Sydney"
        };
            Random rand = new Random();
            for(int i = 0 ; i < names.Count; i++)
            {
                int randIndex = rand.Next(names.Count);
                string temp = names[i];
                names[i] = names[randIndex];
                names[randIndex] = temp;
            }
            return names;
        
    
