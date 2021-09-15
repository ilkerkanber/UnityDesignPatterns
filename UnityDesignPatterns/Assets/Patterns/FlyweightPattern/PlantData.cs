using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="PlantData",menuName ="Create New PlantData",order =51)]
public class PlantData : ScriptableObject
{
    public enum THREAT
    {
        None,Low,Moderate,High 
    }
    [field: SerializeField]
    public string Name { get; private set; }

    [field: SerializeField]
    public THREAT Threat { get; private set; }

    [field: SerializeField]
    public Texture Icon { get; private set; }
}
