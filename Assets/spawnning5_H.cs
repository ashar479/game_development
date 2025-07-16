using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnning5_H : MonoBehaviour
{
    public GameObject Firstaid5;
    void Start()
    {

        GameObject firstaid5;
        GameObject enemySpawnPoint1 = GameObject.Find("spawnner5_H");
        firstaid5 = Instantiate(Firstaid5, enemySpawnPoint1.transform.position, enemySpawnPoint1.transform.rotation);

    }
}
