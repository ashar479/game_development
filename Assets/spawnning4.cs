using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnning4 : MonoBehaviour
{
   public GameObject Enemy4;
    void Start()
    {

        GameObject enemy4;
        GameObject enemySpawnPoint1 = GameObject.Find("spawnner4");
        enemy4 = Instantiate(Enemy4, enemySpawnPoint1.transform.position, enemySpawnPoint1.transform.rotation);

    }
}
