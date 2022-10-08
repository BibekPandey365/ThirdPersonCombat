using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateMachine : MonoBehaviour
{

    State currentState;

    void Update()
    {
        currentState?.Tick(Time.deltaTime);     //if(currentState != null) {currentState.Tick(Time.deltaTime);}
    }

    public void SwitchState(State newState)
    {
        currentState?.Exit();
        currentState = newState;
        currentState?.Enter();
    }
}
