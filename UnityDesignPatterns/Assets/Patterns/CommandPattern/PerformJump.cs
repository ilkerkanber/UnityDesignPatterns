using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerformJump : Command
{
    public override void Execute(Animator anim, bool isForward)
    {
        if(isForward)
        {
            anim.SetTrigger("isJumping");
        }
        else
        {
            anim.SetTrigger("isJumpingR");
        }
    }
}
