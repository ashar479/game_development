using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnning4_H : MonoBehaviour
{
    public GameObject Firstaid4;
    void Start()
    {

        GameObject firstaid4;
        GameObject enemySpawnPoint1 = GameObject.Find("spawnner4_H");
        firstaid4 = Instantiate(Firstaid4, enemySpawnPoint1.transform.position, enemySpawnPoint1.transform.rotation);

    }
}
