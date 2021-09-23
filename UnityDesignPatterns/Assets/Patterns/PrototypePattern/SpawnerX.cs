using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerX : MonoBehaviour
{
    void Update()
    {
        if (Random.Range(0, 100) < 10)
        {
            ProcSphere.Clone(transform.position);
        }   
    }
}
