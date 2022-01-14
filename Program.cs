/*
    Data Structures
    The structure of Stack
    Created by: Guilherme de Assis
    Date: 14/01/2022

*/

namespace Program
{
    class Program
    {
        static void Main()
        {
            // Instantied Stack object
            Stack s = new();
            // Stackup three items
            s.Stackup(1);
            s.Stackup(10);
            s.Stackup(100);
            // Unstack 3 items
            Console.WriteLine(s.Unstack());
            Console.WriteLine(s.Unstack());
            Console.WriteLine(s.Unstack());
        }
    }
}
