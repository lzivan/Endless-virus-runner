using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenspawn;
    private float spawntime;



    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawntime){
            Spawn();
            spawntime = Time.time + timeBetweenspawn;
        }
    }

    void Spawn(){
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY,0), transform.rotation);

    }
}
