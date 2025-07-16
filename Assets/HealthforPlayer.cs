using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class HealthforPlayer : MonoBehaviour
{
    public float health;
    public Slider slider;
    public Text text;
    private System.Random random = new System.Random();
    public static event Action finish;
    public static HealthforPlayer Instance;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Awake()
    {
        Instance = this;
    }


    void Update()
    {

        slider.value = health;
        text.text = "Health : " + health;

    }

    void OnCollisionEnter(Collision obj)
    {
        if (health <= 10)
        {
            Destroy(gameObject);
            finish?.Invoke();
        }

        if (obj.gameObject.tag == "enemy")
            health = health - 10f;



        if (health < 100)
        {
            if (obj.gameObject.tag == "firstaid")
                health = health + 10f;
        }

    }
    public void increaseHealth(int value)
    {
        if (health < 100f)
        {
            health = health + value;
        }
    }

    public float getHealthValue()
    {
        return health;
    }


}