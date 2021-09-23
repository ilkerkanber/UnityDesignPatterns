using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectPoolScript : MonoBehaviour
{
    public Queue<GameObject> queue;
    
    [SerializeField]    
    GameObject spawnObject;
    [SerializeField]
    int objectCount;

    GameObject objectPoint;
    Transform parentObjectTransform;

    void Awake()
    {
        objectPoint = transform.GetChild(0).gameObject;
        queue = new Queue<GameObject>();
        parentObjectTransform = GameObject.Find("Pool").transform;
    }
    void Start()
    {   
        Create(objectCount);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Use();
        }    
    }
  
    //Ýstenilen sayýda baþta üretir.
    void Create(int count)
    {
        for (int i = 1; i <= count; i++)
        {
            GameObject spawnableObject = Instantiate(spawnObject, objectPoint.transform.position, objectPoint.transform.rotation, parentObjectTransform);
            spawnableObject.SetActive(false);
            queue.Enqueue(spawnableObject);
        }
    }
    //Üretilen kullanýma hazýr küp çaðrýlýr
    void Use()
    {
        if (queue.Count == 0) 
        {
            Debug.Log("Kuyruk Sýfýrlandý");
            return;
        }
        GameObject newObject = queue.Dequeue();
        newObject.SetActive(true);
        newObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * Time.deltaTime * 10);
    }
    //Diðer class baþlangýç pozisyonuna eriþsin diye
    public Vector3 GetPointTransformPosition()
    {
        return objectPoint.transform.position;
    }
}
