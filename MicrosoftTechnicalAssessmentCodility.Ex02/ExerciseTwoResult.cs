namespace MicrosoftTechnicalAssessmentCodility.Ex02
{
    public static class ExerciseTwoResult
    {
        /*
         * For example
         * "100", "110", "010", "011", "100" - 2, 3, 2, 1, 2
         */

        public static int[] Solution(string[] cars)
        {
            int[] similarCountCarsArray = new int[cars.Length];

            for (int i = 0; i < cars.Length; i++)
            {
                var currentCar = cars[i];
                similarCountCarsArray[i] = -1;

                for (int j = 0; j < cars.Length; j++)
                {
                    if (CarIsSimilar(currentCar, cars[j]))
                        similarCountCarsArray[i] += 1;
                }
            }

            return similarCountCarsArray;
        }

        private static bool CarIsSimilar(string currentCar, string carToCompare)
        {
            int differences = 0;

            for (int p = 0; p < currentCar.Length; p++)
                if (currentCar[p] != carToCompare[p])
                    differences++;

            if (differences > 1)
                return false;

            return true;
        }
    }
}
