using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] EnemyData _enemyData;
    int currentHp;
    float currentSpeed;
    void Start()
    {
        currentSpeed = _enemyData.Speed;
        Debug.Log("Hýzý:" + currentSpeed);
    }
}
