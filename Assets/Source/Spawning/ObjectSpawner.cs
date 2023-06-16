using UnityEngine;

public class ObjectSpawner
{
    public ObjectSpawner(ObjectSpawnerEmitter emitter)
    {
        Object.Instantiate(emitter.Prefab, emitter.Position, Quaternion.identity);
    }
}
