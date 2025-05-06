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
        // Step 1: we will C]create an array to store the multiples of the given number.
       // The size of the array will be 'length'.
       double[] multiples = new double[length];
       // Step 2: we will use a loop to calculate and store the multiples of 'number'.
       // The loop runs 'length' times.
      for (int i = 1; i <= length; i++)

       {
        // Step 3: For each index, store the multiple of 'number' at the current position.
        multiples[i - 1] = number * i;

       }
        // Step 4: Return the array containing the multiples.
        return multiples;

       
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
    // PLAN to Rotate a List to the Right:
    // 1. We are rotating to the right, meaning we want the last 'amount' elements
    //    to move to the front of the list.
    // 2. We will use GetRange to slice the list:
    //    a. Get the last 'amount' elements and store them in a temporary list.
    //    b. Get the remaining elements (from start to Count - amount).
    // 3. Clear the original list.
    // 4. Add the last 'amount' elements first.
    // 5. Add the remaining elements after that.
    // 6. The list is now rotated in-place (no return value needed).

    // Step 1: Geting the last 'amount' elements.
    List<int> lastPart = data.GetRange(data.Count - amount, amount);

    // Step 2: Geting the remaining front part of the list.
    List<int> frontPart = data.GetRange(0, data.Count - amount);

    // Step 3: Clearing the original list to prepare for inserting rotated values.
    data.Clear();

    // Step 4: Adding the last part to the beginning.
    data.AddRange(lastPart);

    // Step 5: Adding the front part after the last part.
    data.AddRange(frontPart);
}

}
