public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {

        // Plan:
        // 1. Create a new array of doubles with the size specified by 'length'.
        // 2. Iterate in a loop from 1 to 'length' (inclusive).
        // 3. In each iteration, calculate the multiple by multiplying 'number' by the loop index.
        // 4. Assign the result to the array in the correct position (loop index - 1).
        // 5. After the loop finishes, return the complete array.

        // Implementation:
        double[] result = new double[length]; // 1. Create the array.

        for (int i = 1; i <= length; ++i)
        { // 2. Iterate.
            double multiple = number * i;     // 3. Calculate the multiple.
            result[i - 1] = multiple;      // 4. Assign to the array.
        }

        return result; // 5. Return the result.

    }





    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
   
    
        public static void RotateListRight(List<int> data, int amount)
        {
          
            // Remember: Using comments in your program, write down your process for solving this problem
            // step by step before you write the code. The plan should be clear enough that it could
            // be implemented by another person.
            // Implementation:
            // 1. Calculate the split point.
            int splitIndex = data.Count - amount;

            // 2. Get the right part of the list (the elements to rotate).
            List<int> rightPart = data.GetRange(splitIndex, amount);

            // 3. Remove that same part from the original list.
            data.RemoveRange(splitIndex, amount);

            // 4. Insert the right part at the beginning of the list.
            data.InsertRange(0, rightPart);
        }
    }





