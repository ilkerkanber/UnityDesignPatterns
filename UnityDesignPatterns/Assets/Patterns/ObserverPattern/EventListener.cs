using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class UnityGameObjectEvent : UnityEvent<GameObject>
{
        
}
public class EventListener : MonoBehaviour
{
    public Event _event;
    public UnityGameObjectEvent response = new UnityGameObjectEvent();
    void OnEnable()
    {
        _event.Register(this);    
    }
    void OnDisable()
    {
        _event.UnRegister(this);    
    }
    public void OnEventOccurs(GameObject go)
    {
        response.Invoke(go);
    }
}
