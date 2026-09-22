using System;
using System.Collections.Generic;

namespace StateMachineSystem
{
    public class StateMachine
    {
        private IState currentState;
        private Dictionary<Type, IState> states = new Dictionary<Type, IState>();

        public void RegisterState(IState state)
        {
            states[state.GetType()] = state;
        }

        public void ChangeState<T>() where T : IState
        {
            Type type = typeof(T);
            if (!states.ContainsKey(type)) return;

            currentState?.Exit();
            currentState = states[type];
            currentState.Enter();
        }

        public void Tick()
        {
            currentState?.Execute();
        }
    }
}
