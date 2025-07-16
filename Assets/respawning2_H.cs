using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawning2_H : MonoBehaviour
{
    public GameObject respwan2;
    private UnityEngine.Object enemyRef;

    // Start is called before the first frame

    void Start()
    {
        enemyRef = Resources.Load("firstaid2");
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
        GameObject firstaid2;
        GameObject enemySpawnPoint2 = GameObject.Find("spawnner2_H");
        firstaid2 = Instantiate((GameObject)enemyRef, enemySpawnPoint2.transform.position, enemySpawnPoint2.transform.rotation);
        Destroy(respwan2, 0.1f);
    }
}
