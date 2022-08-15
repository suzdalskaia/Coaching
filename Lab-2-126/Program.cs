namespace Lab2_problem_126
{
    class Program
    {
        //задача: знайти номер під'ізду та поверх за заданим номером квартири
        static void Main(string[] args)
        {
            string inputData = "30, 2, 5, 27";

            char[] separator = { ',', ' ' };
            string[] separatedInput = inputData.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            int[] numbersInput = new int[separatedInput.Length];

            for (int i = 0; i < separatedInput.Length; i++)
            {
                numbersInput[i] = int.Parse(separatedInput[i]);
            }

            int appartmentsInBuilding = numbersInput[0];
            int entrance = numbersInput[1];
            int floors = numbersInput[2];
            int particularAppartment = numbersInput[3];

            if ((appartmentsInBuilding % entrance == 0) && (appartmentsInBuilding % floors == 0) && particularAppartment >= 1 && particularAppartment <= appartmentsInBuilding)
            {
                int appartmentsPerEntrance = appartmentsInBuilding / entrance;
                int currentEntrance = (int)Math.Ceiling((double)particularAppartment / (double)appartmentsPerEntrance);

                int firstAppartmentAtEntrance = (appartmentsPerEntrance * (currentEntrance - 1)) + 1;
                int appartmentsPerFloor = appartmentsPerEntrance / floors;
                int currentFloor = (particularAppartment - firstAppartmentAtEntrance) / appartmentsPerFloor + 1;

                Console.WriteLine($"{currentEntrance}, {currentFloor}");
                Console.ReadKey();
            }
        }
    }
}
