using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeInOne
{
    public class ThreeStacksOneArrayFixed
    {
        int[] stackGroup;
        int firstStack;
        int secondStack;
        int thirdStack;
        int stackCap;

        public ThreeStacksOneArrayFixed(int stackSize)
        {
            stackCap = stackSize;
            stackGroup = new int[stackSize * 3];
            firstStack = 0;
            secondStack = stackSize;
            thirdStack = stackSize * 2;
        }

        public void PushFirstStack(int data)
        {
            if( firstStack >= stackCap )
            {
                throw new Exception("First stack is full");
            }

            stackGroup[firstStack++] = data;       
        }

        public int PopFirstStack()
        {
            if (firstStack <= 0)
            {
                throw new Exception("First stack is empty");
            }

            return stackGroup[--firstStack];
        }

        public void PushSecondStack( int data )
        {
            if( secondStack >= stackCap*2 )
            {
                throw new Exception("Second stack is full");
            }

            stackGroup[secondStack++] = data;
        }

        public int PopSecondStack()
        {
            if( secondStack <= stackCap )
            {
                throw new Exception("Second stack is empty");
            }

            return stackGroup[--secondStack];
        }

        public void PushThirdStack( int data )
        {
            if( thirdStack >= stackCap*3)
            {
                throw new Exception("Third stack is full");
            }

            stackGroup[thirdStack++] = data;
        }

        public int PopThirdStack()
        {
            if( thirdStack <= stackCap*2)
            {
                throw new Exception("Third stack is empty");
            }

            return stackGroup[--thirdStack];
        }
    }
}
