using System.Diagnostics;

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

        // Plan:
        // Step 1: Create an array of doubles with the size of 'length'.
        // Step 2: Iterate through the array using a for loop.
        // Step 3: For each index, calculate the multiple of 'number' by multiplying 'number' with (index + 1).
        // Step 4: Return the populated array

        // The array to hold the multiples
        double[] multiples = new double[length];
        // Loop through each index of the array
        for (int index = 0; index < length; index++)
        {
            multiples[index] = number * (index + 1); // For each position, calculate the multiples (number * (index + 1)). Example: number = 7, index = 0 -> 7 * (0 + 1) = 7, 7 * (1 + 1) = 14, and so on.
        }

        // To debug the array contents of the Test Method and show in debug console when run in debug mode.
        Debug.WriteLine($"<double> {string.Join(", ", multiples)}");

        return multiples; // Return the array of multiples
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

        // Plan:
        // 1. Figure out how many items will be moved to the front.
        //    Example: for data.Count = 9 and amount = 3, last 3 items (7,8,9) move to the front.
        // 2. Get a slice of the last 'amount' items. (data.GetRange(data.Count - amount, amount))
        // 3. Get a slice of the remaining items at the front. (data.GetRange(0, data.Count - amount))
        // 4. Clear the original list (or remove items).
        // 5. Add the two slices back in the new order: last part first, then the first part.

        // Debugging output to trace the original list and rotation amount
        Debug.WriteLine($"Original List: {string.Join(", ", data)}");
        Debug.WriteLine($"Rotate Amount: {amount}");
        Debug.WriteLine("");

        List<int> lastPart = data.GetRange(data.Count - amount, amount); // Getting the last 'amount' items
        Debug.WriteLine($"Last Part: {string.Join(", ", lastPart)}");  // Debugging output to trace the last part

        List<int> firstPart = data.GetRange(0, data.Count - amount); // Getting the first part of the list
        Debug.WriteLine($"First Part: {string.Join(", ", firstPart)}"); // Debugging output to trace the first part

        data.Clear(); // Clear the original list to prepare for reordering
        data.AddRange(lastPart); // Add the last part first
        data.AddRange(firstPart); // Add the first part next
        Debug.WriteLine("");

        Debug.WriteLine($"Rotated List: {string.Join(", ", data)}"); // Debugging output to trace the final rotated list

    }
}
