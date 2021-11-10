namespace MicrosoftTechnicalAssessmentCodility.Ex01
{
    public static class ExerciseOneResult
    {
        /*
         * For example
         * 14 - 19
         * 10 - 11
         * 99 - 9999
         */

        public static int Solution(int n)
        {
            int numberSum = GetNumberSum(n);
            int currentNumber = n;

            while (true)
            {
                var currentNumberSum = GetNumberSum(currentNumber);

                if (currentNumberSum == numberSum * 2)
                    return currentNumber;

                currentNumber++;
            }
        }

        private static int GetNumberSum(int n)
        {
            int numberSum = 0;
            string numberString = n.ToString();

            if (numberString.Length < 2)
                return n;

            var numberArray = numberString.ToCharArray();

            for (int i = 0; i < numberArray.Length; i++)
            {
                numberSum += int.Parse(numberArray[i].ToString());
            }

            return numberSum;
        }
    }
}
