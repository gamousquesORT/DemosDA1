using System;
using System.Text;

namespace DA1StackLogic
{
   
    public class Da1Stack
    {
        private int[] numbers = new int[5];
        private int index = 0;
        private const int capacity = 5;
        
        public bool IsEmpty()
        {
            return (Size() == 0);
        }

        public void Push(int num)
        {
            if (++index >= capacity)
                throw new OverflowException("Push over stack size");
            numbers[index] = num;
        }

        public int Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("pop on empty stack");
            
            return numbers[index--];;
        }

        public int Size()
        {
            return index;
        }
    }
    
}