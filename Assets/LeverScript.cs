using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : MonoBehaviour
{
    public GameObject wallToSwitch;
    public GameObject wallToSwitch2;


    void OnTriggerEnter2D(Collider2D coll)
    {
        wallToSwitch.GetComponent<WallScript>().changeWallColor();
        wallToSwitch2.GetComponent<WallScript>().changeWallColor();
    }
}
