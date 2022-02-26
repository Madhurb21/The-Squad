using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNextTile : MonoBehaviour
{
    private RoadSpawn roadSpawn;
    // Start is called before the first frame update
    void Start()
    {
        roadSpawn = FindObjectOfType<RoadSpawn>();
        SpawnObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            roadSpawn.spawn();
            Destroy(this.gameObject, 3f);
        }
    }
    public GameObject obstaclePrefab;

    void SpawnObstacle ()
    {
        int obstacleSpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }

}
