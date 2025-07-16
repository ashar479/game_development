using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnning5 : MonoBehaviour
{
   public GameObject Enemy5;
    void Start()
    {

        GameObject enemy5;
        GameObject enemySpawnPoint1 = GameObject.Find("spawnner5");
        enemy5 = Instantiate(Enemy5, enemySpawnPoint1.transform.position, enemySpawnPoint1.transform.rotation);

    }
}
