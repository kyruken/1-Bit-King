using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public KingInfoScript kingInfo;
    private GameObject BumpBackPoint;

    void Start()
    {
        kingInfo = GameObject.FindGameObjectWithTag("Player").GetComponent<KingInfoScript>();
        BumpBackPoint = GameObject.FindGameObjectWithTag("BumpPoint");
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player" && !kingInfo.hasKey)
        {
            coll.gameObject.transform.position = new Vector3(BumpBackPoint.transform.position.x, BumpBackPoint.transform.position.y, BumpBackPoint.transform.position.z);
        } else {
            kingInfo.hasKey = false;
            Destroy(gameObject);
        }
    }
}
