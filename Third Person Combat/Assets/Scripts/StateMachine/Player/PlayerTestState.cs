using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTestState : PlayerBaseState
{

    private float timer;

    public PlayerTestState(PlayerStateMachine stateMachine) : base(stateMachine) { }

    public override void Enter()
    {
        stateMachine.InputReader.JumpEvent += Enter;
        Debug.Log("Enter");
    }

    public override void Tick(float deltaTime)
    {
        timer += deltaTime;
        Debug.Log(timer);
    }

    public override void Exit()
    {
        stateMachine.InputReader.JumpEvent -= Enter;
        Debug.Log("Exit");
    }
    
    void OnJump()
    {
        stateMachine.SwitchState(this);
    }
}
