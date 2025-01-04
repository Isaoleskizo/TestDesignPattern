using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    [SerializeField] private Subject subjectToObserve;

    virtual protected void OnThingAppened()
    {
        Debug.Log("observation");
    }

    private void Awake()
    {
        if(subjectToObserve != null)
        {
            subjectToObserve.ThingAppened += OnThingAppened;
        }
    }

    private void OnDestroy()
    {
        if(subjectToObserve != null)
        {
            subjectToObserve.ThingAppened -= OnThingAppened;
        }
    }


}
