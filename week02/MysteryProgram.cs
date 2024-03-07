using System;
using System.Collections.Generic;

class D
{
    static void Main()
    {
        int[] d = R(5); //Give us an array with 5 random integers in the range of 1-7
        Array.Sort(d); //Sort the array from smallest to largest.
        Console.WriteLine("Values: " + string.Join(", ", d)); //Print the array
        int s = C(d); // returns an integer value equivalent to 10 * the amount of redundant values in the array d.
        Console.WriteLine("Total: " + s); // prints out integer s.
    }

    static int[] R(int n)
    {
        Random r = new Random(); //give us a new random class instance
        int[] d = new int[n]; //make the array d the length of the argument n
        // populate the array d with random numbers within the range of 1 to 7
        for (int i = 0; i < n; i++)
        {
            d[i] = r.Next(1, 7);
        }
        //return the new array
        return d;
    }

    static int C(int[] d)
    {
        int s = 0;
        Dictionary<int, int> c = new Dictionary<int, int>(); //Make a dictionary, c, that stores integers and uses them as the keys.
        
        //Tells us which values are present via the keys of the dictionary, and stores how many duplicates there were.
        
        foreach (int x in d) // traverse the array d.
        {
            if (c.ContainsKey(x)) //if c contains the current value as a key add 1 to it's value stored.
            {
                c[x]++;
            }
            else //else add the value as a key with the value of 1
            {
                c[x] = 1;
            }
        }
        //Adds to the integer s dependent on how many redundant values are present in the c dictionary.
        foreach (int v in c.Values) 
        {
            switch (v)
            {
                case 2:
                    s += 10;
                    break;
                case 3:
                    s += 20;
                    break;
                case 4:
                    s += 30;
                    break;
                case 5:
                    s += 40;
                    break;
            }
        }
        return s;
    }
}