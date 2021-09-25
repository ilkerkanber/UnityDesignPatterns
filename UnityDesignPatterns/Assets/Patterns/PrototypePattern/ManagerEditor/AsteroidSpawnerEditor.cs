using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(AsteroidSpawner))]
public class AsteroidSpawnerEditor : Editor
{
    string path;
    string assetpath;
    string filename;
    
    void OnEnable()
    {
        path = Application.dataPath + "/Asteroid";
        assetpath = "Assets/Asteroid/";
        filename = "asteroid_"+System.DateTime.Now.Ticks.ToString();
    }
    public override void OnInspectorGUI()
    {
        AsteroidSpawner asteroidSpawner = (AsteroidSpawner)target;
        DrawDefaultInspector();
        if (GUILayout.Button("CreateAsteroid"))
        {
            asteroidSpawner.CreateAsteroid();
        }
        if (GUILayout.Button("SaveAsteroid"))
        {
            System.IO.Directory.CreateDirectory(path);
            Mesh mesh = asteroidSpawner.asteroid.GetComponent<MeshFilter>().sharedMesh;
            AssetDatabase.CreateAsset(mesh,assetpath+mesh.name+".asset");
            AssetDatabase.SaveAssets();
            PrefabUtility.SaveAsPrefabAsset(asteroidSpawner.asteroid, assetpath + filename + ".prefab");
        }
    }
}
