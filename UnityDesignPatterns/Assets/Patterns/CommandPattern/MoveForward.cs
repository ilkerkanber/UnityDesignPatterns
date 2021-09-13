using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : Command
{
    public override void Execute(Animator anim, bool isForward)
    {
        if (isForward)
        {
            anim.SetTrigger("isWalking");
        }
        else
        {
            anim.SetTrigger("isWalkingR");
        }
    }
}
