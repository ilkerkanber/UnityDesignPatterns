using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State
{
    protected State nextState;
    protected Animator _animator;

    public STATE state;
    protected EVENT stage;
    
    public enum STATE
    {
        IDLE,PUNCHL,PUNCHR
    }
    public enum EVENT
    {
        ENTER,UPDATE,EXIT
    }
    public State(Animator animator)
    {
        _animator = animator;
        stage = EVENT.ENTER;
    }
    //
    public virtual void Enter()
    {
        stage = EVENT.UPDATE;
    }
    public virtual void Update()
    {
        stage = EVENT.UPDATE;
    }
    public virtual void Exit()
    {
        stage = EVENT.EXIT;
    }
    //
    public State Process()
    {
        switch (stage)
        {
            case EVENT.ENTER:
                Enter();
                break;

            case EVENT.UPDATE:
                Update();
                break;

            case EVENT.EXIT:
                Exit();
                return nextState;
        }
        return this;
    }
}
