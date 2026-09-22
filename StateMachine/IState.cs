namespace StateMachineSystem
{
    public interface IState
    {
        void Enter();
        void Execute();
        void Exit();
    }
}
