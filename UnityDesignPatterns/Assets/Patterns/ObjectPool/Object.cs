using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    [SerializeField] float lifeTime;
    ObjectPoolScript _objectPoolScript;
    float createdTime;
    
    private void Awake()
    {
        _objectPoolScript = GameObject.FindObjectOfType<ObjectPoolScript>();
    }
    void OnEnable()
    {
        createdTime = Time.time;
    }
    void OnDisable()
    {
        transform.position = _objectPoolScript.GetPointTransformPosition();
        createdTime = 0;
    }
    void Update()
    {
        if (Time.time>createdTime+lifeTime)
        {
            this.gameObject.SetActive(false);
            _objectPoolScript.queue.Enqueue(this.gameObject);
        }
    }
}
