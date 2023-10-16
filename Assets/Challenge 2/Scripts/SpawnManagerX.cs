using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{

    //Array to Hold Balls in Game(accessible through the main Unity Portal) 
    public GameObject[] ballPrefabs;

    //Floats to set the limits of where the balls spawn from
    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
   
    // Start is called before the first frame update
    void Start()
    {
        //Calling the Spawn Random Ball Method. 
        SpawnRandomBall();
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()

    {
        //Variable Changed to random range to make ball spawning interval random
        float spawnInterval = Random.Range(2.0f, 6.0f);

        //Calling the Spawn Random Ball method to generate random balls
        Invoke("SpawnRandomBall" , spawnInterval);

        //Index to envoke random ball out of balls 1,2,3. 
        int randomBall = Random.Range(0, ballPrefabs.Length);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randomBall], spawnPos, ballPrefabs[randomBall].transform.rotation);
    }

}
