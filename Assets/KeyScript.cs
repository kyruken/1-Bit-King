using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public KingInfoScript kingInfo;

    void Start()
    {
        kingInfo = GameObject.FindGameObjectWithTag("Player").GetComponent<KingInfoScript>();
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            kingInfo.hasKey = true;
            Destroy(gameObject);
        }
    }
}
