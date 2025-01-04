using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public StateMachine state;

    private void Awake()
    {
        state = new(this);
        state.Initialize(new BlueState(this));
    }

    private void Update()
    {
        state.Update();
    }
}
