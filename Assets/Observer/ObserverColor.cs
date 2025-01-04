using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverColor : Observer
{
    protected override void OnThingAppened()
    {
        transform.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
