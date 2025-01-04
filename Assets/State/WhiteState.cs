using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteState : IState
{
    public WhiteState(ColorManager c)
    {
        manager = c;
    }
    private ColorManager manager;
    public void Enter()
    {

    }

    public void Update()
    {
        manager.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        manager.state.TransitionTo(manager.state.redState);
    }

    public void Exit() 
    { 
        
    }
}
