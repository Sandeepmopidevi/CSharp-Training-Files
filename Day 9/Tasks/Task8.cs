using System;
class Task8
{
    static void Main(string[] args)
    {
        try
        {
            int index = int.Parse(args[0]);
            int[] array = { 10, 20, 30, 40, 50 };

            if (index >= 0 && index < array.Length)
            {
                Console.WriteLine("The element present at "+index+" is "+array[index]);
            }
            else
            {
                throw new IndexOutOfRangeException("The given index is out of bounds");
            }
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}