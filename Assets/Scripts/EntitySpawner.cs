using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntitySpawner : MonoBehaviour
{
    public GameObject entity;
    public int spawnLimit;
    private static int _entities = 0;
    private void Start()
    {
        InvokeRepeating("SpawnEntity", 5f, 5f);
    }

    private void SpawnEntity()
    {
        if (_entities < spawnLimit)
        {
            var spawnDistance = new Vector3(Random.Range(-3f,3f), 0, Random.Range(-3f,3f));
            Instantiate(entity,(transform.position + spawnDistance), Quaternion.identity);
            _entities++;
        }
        else
        {
            Debug.Log("Spawn limit reached for " + entity.name);
        }
    }

    public static void DestroyEntity(GameObject entity)
    {
        Debug.Log("Removing " + entity);
        _entities--;
        Destroy(entity);
    }
}
