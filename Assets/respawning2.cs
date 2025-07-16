using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawning2 : MonoBehaviour
{
    public GameObject respwan2;
    private UnityEngine.Object enemyRef;

    // Start is called before the first frame

    void Start()
    {
        enemyRef = Resources.Load("enemy2");
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            respwan2.SetActive(false);
            Invoke(nameof(Respwan2), 5f);
        }
    }

    void Respwan2()
    {
        GameObject enemy2;
        GameObject enemySpawnPoint2 = GameObject.Find("spawnner2");
        enemy2 = Instantiate((GameObject)enemyRef, enemySpawnPoint2.transform.position, enemySpawnPoint2.transform.rotation);
        Destroy(respwan2, 0.1f);
    }
}
