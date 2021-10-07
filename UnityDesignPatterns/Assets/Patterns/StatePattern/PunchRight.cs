using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchRight : State
{
    public PunchRight(Animator animator) : base(animator)
    {
        state = STATE.PUNCHR;
    }
    public override void Enter()
    {
        _animator.SetTrigger("IsPunchRight");
        base.Enter();
    }
    public override void Update()
    {
        base.Update();
    }
    public override void Exit()
    {
        _animator.ResetTrigger("IsPunchRight");
        base.Exit();
    }
}
