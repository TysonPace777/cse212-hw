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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //PLAN
        //I will use an i integer to multiply each number 
        // but increase each time for example i starts at 1: 3*1, then 3*2

        List<double> multiples = new List<double>(); //New List

        for (int i = 1; i <= length; i++) //For each number of i, multiply to number and add 1
        {
            double multiple = number * i;
            multiples.Add(multiple); //after multiplying, add multiple to list
        }


        return multiples.ToArray(); // replace this return statement with your own
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //PLAN
        //I will make sure the amount is in the list of data or if it needs to
        //be ended if the amount is 0, then make a list for each rotated amount
        //and then the leftovers and clear the original list and add them back
        //in the new order

        amount = amount % data.Count; //Amount is actually in the list

        if (amount == 0) return; //for no rotation needed

        List<int> rotatedRight = data.GetRange(data.Count - amount, amount); //rotated values
        List<int> remainingNum = data.GetRange(0, data.Count - amount); //what stays

        data.Clear();

        data.AddRange(rotatedRight); //add rotated amount first
        data.AddRange(remainingNum); //finally put regular 1,2,3 etc after rotated
    }
}
