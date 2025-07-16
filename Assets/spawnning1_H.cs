using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnning1_H : MonoBehaviour
{
   public GameObject Firstaid1;
    void Start()
    {

        GameObject firstaid1;
        GameObject enemySpawnPoint1 = GameObject.Find("spawnner1_H");
        firstaid1 = Instantiate(Firstaid1, enemySpawnPoint1.transform.position, enemySpawnPoint1.transform.rotation);

    }
}
