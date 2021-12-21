using System;

namespace lab5
{
    class ContextStudent
    {
        NA_State na_State = new NA_State();
        С_State с_State = new С_State();
        B_State b_State = new B_State();
        A_State a_State = new A_State();

        private State CurrentState;
        int percents = 0;
        public ContextStudent()
        {
            CurrentState = na_State;
        }

        void SetState()
        {
            if (percents >= na_State.percents)
            {
                CurrentState = na_State;
            }
            if (percents >= с_State.percents)
            {
                CurrentState = с_State;
            }
            if (percents >= b_State.percents)
            {
                CurrentState = b_State;
            }
            if (percents >= a_State.percents)
            {
                CurrentState = a_State;
            }
        }

        public void Learn()
        {
            if (percents < 95)
            {
                percents += 5;
                SetState();
                CurrentState.CurrentPercent();
            }
            else
            {
                Console.WriteLine("Learned to maximum");
            }
        }
    }
}

