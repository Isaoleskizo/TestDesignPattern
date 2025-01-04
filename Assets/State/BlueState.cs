using UnityEngine;

public class BlueState : IState
{
    public BlueState(ColorManager c)
    {
        manager = c;
    }


    private ColorManager manager;
    public void Enter()
    {

    }

    public void Update()
    {
        manager.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
        manager.state.TransitionTo(manager.state.whiteState);
    }

    public void Exit()
    {

    }
}
