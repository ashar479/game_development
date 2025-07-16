using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public GameObject GameoverMenu;

    private void OnEnable()
    {
        HealthforPlayer.finish += GameoverMenuEnable;
    }
    private void OnDisable()
    {
        HealthforPlayer.finish -= GameoverMenuEnable;
    }

    public void GameoverMenuEnable()
    {
        GameoverMenu.SetActive(true);
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
