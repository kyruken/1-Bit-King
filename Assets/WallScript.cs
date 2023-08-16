using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    public string currentColor = "White";
    public GameObject spawnPoint;

    void OnTriggerEnter2D(Collider2D coll)
    {
        GameObject king = coll.gameObject;
        string kingColor = king.GetComponent<PlayerLogicScript>().currentColor;

        Debug.Log(currentColor.Equals(kingColor));
        if (coll.gameObject.tag == "Player" && currentColor.Equals(kingColor))
        {
            Debug.Log("working");
            Debug.Log(new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y, spawnPoint.transform.position.z));
            king.transform.position = new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y, spawnPoint.transform.position.z);
        }
    }
}
