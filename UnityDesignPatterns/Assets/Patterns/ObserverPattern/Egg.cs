using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Egg : MonoBehaviour
{
    public Event dropped;
    public Image icon;
    void Start()
    {
        dropped.Occurred(this.gameObject);
    }
    void Update()
    {
        
    }
}
