using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameEnvironment 
{
    static GameEnvironment Instance;
    public List<GameObject> Obstacles { get; private set; } = new List<GameObject>();
    public List<GameObject> Goals{ get; private set; } = new List<GameObject>();

    public static GameEnvironment Singleton
    {
        get
        {
            if (Instance == null)
            {
                Instance = new GameEnvironment();
                Instance.Goals.AddRange(GameObject.FindGameObjectsWithTag("goal"));
            }
            return Instance;
        }
    }
    public GameObject GetRandomGoal()
    {
        int index = Random.Range(0, Goals.Count);
        return Goals[index];
    }
    public void AddObstacles(GameObject go)
    {
        Obstacles.Add(go);
    }
    public void RemoveObstacles(GameObject go)
    {
        int index = Obstacles.IndexOf(go);
        Obstacles.RemoveAt(index);
        GameObject.Destroy(go);
    }
}
