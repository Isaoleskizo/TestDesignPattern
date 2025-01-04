using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DamageHandler : MonoBehaviour
{
    [SerializeField] private int MonkeyHP = 1000;
    [SerializeField] private bool cramptes;
    [SerializeField] private AudioSource SFXDamageInflicted;
    [SerializeField] private ParticleSystem VFXSang;



    public event Action ThingAppened;



    public void DoThing()
    {
        if (ThingAppened != null)
        {
            ThingAppened.Invoke();

        }
    }

    void Update()
    {
        OnDamageInflectedOnBigMonkey();
    }

    private void OnDamageInflectedOnBigMonkey()
    {
        DoThing();
        cramptes = true;
        MonkeyHP--;

    }
}
