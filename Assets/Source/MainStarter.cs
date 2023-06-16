using UnityEngine;

public class MainStarter : Starter
{
    [SerializeField] private ObjectSpawnerEmitter _objectSpawnerEmitter;

    protected override void OnStart()
    {
        ObjectSpawner objectSpawner = new ObjectSpawner(_objectSpawnerEmitter);
    }
}
