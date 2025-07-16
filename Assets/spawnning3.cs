using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnning3 : MonoBehaviour
{
public GameObject Enemy3;
    void Start()
    {

        GameObject enemy3;
        GameObject enemySpawnPoint1 = GameObject.Find("spawnner3");
        enemy3 = Instantiate(Enemy3, enemySpawnPoint1.transform.position, enemySpawnPoint1.transform.rotation);

    }
}
