using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    public float respawnTime = 1;
    public int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy();
        SpawnPlayer();
    }

    private void SpawnPlayer()
    {
        var playerInstance = Instantiate(player, new Vector3(70,1,50), Quaternion.identity);
        playerInstance.name = "p1";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnEnemy()
    {
        Instantiate(enemy);
    }
}
