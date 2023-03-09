namespace Code
{
    public static class RtsCodeTest{

        //aboveBelow
        public static Dictionary<string, int> aboveBelow(int[] theList, int theComparisonValue)
        {
            Dictionary<string, int> aboveBelowRecord = new Dictionary<string, int>()
            {
                {"above", 0},
                {"below", 0}
            };

            if(theList != null)
            {
                for(int i = 0; i < theList.Length; i++)
                {
                    if(theList[i] > theComparisonValue)
                    {
                        int aboveCount = aboveBelowRecord["above"] + 1;
                        aboveBelowRecord["above"] = aboveCount;
                    }
                    else if(theList[i] < theComparisonValue)
                    {
                        int belowCount = aboveBelowRecord["below"] + 1;
                        aboveBelowRecord["below"] = belowCount;
                    }
                }
            }

            return aboveBelowRecord;
        }

        //stringRotation

        public static string stringRotation(string originalString, int rotationAmount){


            if(originalString == null){
                return "Please enter a non null string value";
            }

            if(originalString.Length < rotationAmount){
                rotationAmount = rotationAmount%originalString.Length;
            }

            string lowerString = originalString.Substring(0, rotationAmount);
            string upperString = originalString.Substring(rotationAmount, originalString.Length-rotationAmount);

            string rotatedString = upperString + lowerString;

            return rotatedString;
        }
    }
}