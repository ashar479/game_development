using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawning3_H : MonoBehaviour
{
   public GameObject respwan2;
    private UnityEngine.Object enemyRef;

    // Start is called before the first frame

    void Start()
    {
        enemyRef = Resources.Load("firstaid3");
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
        GameObject firstaid3;
        GameObject enemySpawnPoint2 = GameObject.Find("spawnner3_H");
        firstaid3 = Instantiate((GameObject)enemyRef, enemySpawnPoint2.transform.position, enemySpawnPoint2.transform.rotation);
        Destroy(respwan2, 0.1f);
    }
}
