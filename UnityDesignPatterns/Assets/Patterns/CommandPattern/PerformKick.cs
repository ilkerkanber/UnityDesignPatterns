using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerformKick : Command
{
    public override void Execute(Animator anim, bool isForward)
    {
        if(isForward)
        {
            anim.SetTrigger("isKicking");
        }
        else
        {
            anim.SetTrigger("isKickingR");
        }
    }
}
