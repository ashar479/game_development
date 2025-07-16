using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnning3_H : MonoBehaviour
{
    public GameObject Firstaid3;
    void Start()
    {

        GameObject firstaid3;
        GameObject enemySpawnPoint1 = GameObject.Find("spawnner3_H");
        firstaid3 = Instantiate(Firstaid3, enemySpawnPoint1.transform.position, enemySpawnPoint1.transform.rotation);

    }
}
