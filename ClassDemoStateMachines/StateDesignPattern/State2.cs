using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoStateMachines.StateDesignPattern
{
    public class State2 : IState<char, bool>
    {
        
        public IState<char, bool> NextStateFunction(char input)
        {
            switch (input)
            {
                case 'c': return new State0();
                default: return new State3();

            }
        }

        public bool OutputFunction(char input)
        {
            switch (input)
            {
                case 'c': return true;
                default: return false;

            }
        }
    }
}
