using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnning1 : MonoBehaviour
{
public GameObject Enemy1;

    // Start is called before the first frame update
    void Start()
    {

        GameObject enemy1;
        GameObject enemySpawnPoint1 = GameObject.Find("spawnner1");
        enemy1 = Instantiate(Enemy1, enemySpawnPoint1.transform.position, enemySpawnPoint1.transform.rotation);

    }
}
