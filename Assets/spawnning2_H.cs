using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnning2_H : MonoBehaviour
{
    public GameObject Firstaid2;
    void Start()
    {

        GameObject firstaid2;
        GameObject enemySpawnPoint1 = GameObject.Find("spawnner2_H");
        firstaid2 = Instantiate(Firstaid2, enemySpawnPoint1.transform.position, enemySpawnPoint1.transform.rotation);

    }
}
