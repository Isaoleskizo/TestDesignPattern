using System;

[Serializable]
public class StateMachine
{
    public IState CurrentState { get; private set; }


    public BlueState blueState;
    public WhiteState whiteState;
    public RedState redState;


    //Sujet
    //public event Action<IState> stateChanged;


    //Constructeur
    public StateMachine(ColorManager cube)
    {
        this.blueState = new BlueState(cube);
        this.whiteState = new WhiteState(cube);
        this.redState = new RedState(cube);
    }

    public void Initialize(IState state)
    {
        CurrentState = state;
        state.Enter();

        //stateChanged?.Invoke(state);
    }

    public void TransitionTo(IState nextState)
    {
        CurrentState.Exit();
        CurrentState = nextState;

        nextState.Enter();

        //stateChanged?.Invoke(nextState);
    }

    public void Update()
    {
        if (CurrentState != null)
        {
            CurrentState.Update();
        }
    }
}
