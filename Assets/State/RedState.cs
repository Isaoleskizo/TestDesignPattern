using UnityEngine;

public class RedState : IState
{
    public RedState(ColorManager c)
    {
        manager = c;
    }


    private ColorManager manager;
    public void Enter()
    {

    }

    public void Update()
    {
        manager.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        manager.state.TransitionTo(manager.state.blueState);
    }

    public void Exit()
    {

    }
}
