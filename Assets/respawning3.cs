using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawning3 : MonoBehaviour
{
   public GameObject respwan3;
   private UnityEngine.Object enemyRef;

    // Start is called before the first frame

    void Start()
    {
        enemyRef = Resources.Load("enemy3");
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            respwan3.SetActive(false);
            Invoke(nameof(Respwan2), 5f);
        }
    }

    void Respwan2()
    {
        GameObject enemy3;
        GameObject enemySpawnPoint2 = GameObject.Find("spawnner3");
        enemy3 = Instantiate((GameObject)enemyRef, enemySpawnPoint2.transform.position, enemySpawnPoint2.transform.rotation);
        Destroy(respwan3, 0.1f);
    }
}
