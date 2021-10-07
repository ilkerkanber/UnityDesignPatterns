using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : State
{
    public Idle(Animator animator):base(animator)
    {
        state = STATE.IDLE;
    }
    public override void Enter()
    {
        _animator.SetTrigger("IsIdle");
        base.Enter();
    }
    public override void Update()
    {
        Debug.Log(stage);
        if (Input.GetKeyDown(KeyCode.A))
        {
            Exit();
            nextState = new PunchLeft(_animator);
        }
        else if(Input.GetKeyDown(KeyCode.D)) 
        {
            Exit();
            nextState = new PunchRight(_animator);
        }
        else
        {
            base.Update();
        }
    }
    public override void Exit()
    {
        Debug.Log("Exit");
        _animator.ResetTrigger("IsIdle");
        base.Exit();
    }
}
