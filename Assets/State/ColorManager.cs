using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public StateMachine state;


    private void Awake()
    {
        state = new(this);
        state.Initialize(new RedState(this));
    }

    private void Update()
    {
        state.Update();
    }


}
