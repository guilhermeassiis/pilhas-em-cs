/*
    Data Structures
    The structure of Stack
    Created by: Guilherme de Assis
    Date: 14/01/2022

*/

namespace Program
{
    public class Stack
    {
        // Declared a object of type Position
        Position first;

        // Created Function of stackup
        public void Stackup(object item)
        {
            // instantied the object "First"
            first = new Position(first, item);
        }

        // Created a function of Unstack
        public object Unstack()
        {
            // Verify if object is null
            if (first == null)
            {
                // Exception of erro
                throw new InvalidOperationException();
            }
            // Defined the first out on the stack
            object result = first.item;
            // The next item selected
            first = first.next;
            // Return the result
            return result;

        }
        // Created the class Position
        class Position
        {
            // Defined nesting enter objects of same type
            public Position next;
            // Defined the object who recives the values
            public object item;
            //  defined the constuction method
            public Position(Position next, object item)
            {
                this.next = next;
                this.item = item;
            }
        }
    }
}