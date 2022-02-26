using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawn : MonoBehaviour
{
    public GameObject road;
    private Vector3 nextSpawnPoint = new Vector3(0, -5f, 0);
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 3; i++)
        {
            spawn();
        }
    }

    public void spawn()
    {
        GameObject temp = Instantiate(road, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).position;
    }
}
