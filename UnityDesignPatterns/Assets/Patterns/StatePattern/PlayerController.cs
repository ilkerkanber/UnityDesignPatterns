using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{
    public class PlayerController : MonoBehaviour
    {
        State state;
        Animator animator;
        void Awake()
        {
            animator = GetComponentInChildren<Animator>();
        }
        void Start()
        {
            state = new Idle(animator);
        }
        void Update()
        {
            Debug.Log(state.state);
            state = state.Process();
        }
    }

}
