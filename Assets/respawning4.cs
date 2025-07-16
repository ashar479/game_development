using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawning4 : MonoBehaviour
{
public GameObject Bomb2;
private UnityEngine.Object enemyRef;

    // Start is called before the first frame

    void Start()
    {
        enemyRef = Resources.Load("enemy4");
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Bomb2.SetActive(false);
            Invoke(nameof(Respwan2), 5f);
        }
    }

    void Respwan2()
    {
        GameObject enemy4;
        GameObject enemySpawnPoint2 = GameObject.Find("spawnner4");
        enemy4 = Instantiate((GameObject)enemyRef, enemySpawnPoint2.transform.position, enemySpawnPoint2.transform.rotation);
        Destroy(Bomb2, 0.1f);
    }
}
