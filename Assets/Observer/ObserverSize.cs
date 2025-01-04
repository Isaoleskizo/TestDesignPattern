using UnityEngine;

public class ObserverSize : Observer
{
    protected override void OnThingAppened()
    {
        transform.localScale += Vector3.one * 1.1f;
    }
}
