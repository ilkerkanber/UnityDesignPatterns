using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerformPunch : Command
{
    public override void Execute(Animator anim, bool isForward)
    {
        if (isForward)
        {
            anim.SetTrigger("isPunching");
        }
        else
        {
            anim.SetTrigger("isPunchingR");
        }

    }
}
