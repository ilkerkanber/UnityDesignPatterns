using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="EnemyData",menuName ="Enemy")]
public class EnemyData : ScriptableObject
{   
    //Kod tekrarından her bir scripte bu değişkenleri yerleştirmekten kurtuluyoruz.
    [field:SerializeField]
    public int MaxHealth { get; private set; }
    
    [field:SerializeField]
    public float Speed { get; private set; }
    
    [field:SerializeField]
    public float AttackDamage { get; private set; } 

}
