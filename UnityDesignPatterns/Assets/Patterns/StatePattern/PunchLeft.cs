using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchLeft : State
{
    public PunchLeft(Animator animator) : base(animator)
    {
        state = STATE.PUNCHL;
    }
    public override void Enter()
    {
        _animator.SetTrigger("IsPunchLeft");
        base.Enter();
    }
    public override void Update()
    {
        Exit();
    }
    public override void Exit()
    {
        _animator.ResetTrigger("IsPunchLeft");
        base.Exit();
        nextState = new Idle(_animator);
    }
}
