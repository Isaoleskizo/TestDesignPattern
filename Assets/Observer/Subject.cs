using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Subject : MonoBehaviour
{
    public event Action ThingAppened;

    public void DoThing()
    {
        if(ThingAppened != null)
        {
            ThingAppened.Invoke();

        }
    }

    private void Update()
    {
        //DoThing();
    }







    private void OnMouseEnter()
    {
        DoThing();
    }
}
