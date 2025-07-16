using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawning1 : MonoBehaviour
{
    public GameObject respwan1;
    private UnityEngine.Object enemyRef;

    // Start is called before the first frame

    void Start()
    {
        enemyRef = Resources.Load("enemy1");
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            respwan1.SetActive(false);
            Invoke(nameof(Respwan2), 5f);
        }
    }

    void Respwan2()
    {
        GameObject enemy1;
        GameObject enemySpawnPoint2 = GameObject.Find("spawnner1");
        enemy1 = Instantiate((GameObject)enemyRef, enemySpawnPoint2.transform.position, enemySpawnPoint2.transform.rotation);
        Destroy(respwan1, 0.1f);
    }
}
