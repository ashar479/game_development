using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class axisnotation : MonoBehaviour
{
   
    // Start is called before the first frame update
    public GameObject PlayerP;
    public float globalPositionX;
    public float globalPositionY;
    public float globalPositionZ;

    // reference the UI text element
    public Text PositionDisplayX;
    public Text PositionDisplayY;
    public Text PositionDisplayZ;

    void Start()
    {
        // set the players global position X, Y and Z
    }

    void Update()
    {
        // update globalPosition with player's transform position
        globalPositionX = gameObject.transform.position.x;
        globalPositionZ = gameObject.transform.position.z;
        globalPositionY = WrapAngle(PlayerP.transform.localEulerAngles.y);
        // update UI text with new position

        PositionDisplayX.text = "X: " + globalPositionX;
        PositionDisplayY.text = "Y: " + globalPositionY;
        PositionDisplayZ.text = "Z: " + globalPositionZ;
    }

    float WrapAngle(float angle)
    {
        angle %= 360;
        if (angle > 360)
            return angle - 360;
        return angle;
    }

}
