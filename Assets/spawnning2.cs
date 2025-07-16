using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnning2 : MonoBehaviour
{
public GameObject Enemy2;
    void Start()
    {

        GameObject enemy2;
        GameObject enemySpawnPoint1 = GameObject.Find("spawnner2");
        enemy2 = Instantiate(Enemy2, enemySpawnPoint1.transform.position, enemySpawnPoint1.transform.rotation);

    }
}
