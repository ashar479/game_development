using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawning5 : MonoBehaviour
{
public GameObject respwan5;
private UnityEngine.Object enemyRef;

    // Start is called before the first frame

    void Start()
    {
        enemyRef = Resources.Load("enemy5");
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            respwan5.SetActive(false);
            Invoke(nameof(Respwan2), 5f);
        }
    }

    void Respwan2()
    {
        GameObject enemy5;
        GameObject enemySpawnPoint2 = GameObject.Find("spawnner5");
        enemy5 = Instantiate((GameObject)enemyRef, enemySpawnPoint2.transform.position, enemySpawnPoint2.transform.rotation);
        Destroy(respwan5, 0.1f);
    }
}
