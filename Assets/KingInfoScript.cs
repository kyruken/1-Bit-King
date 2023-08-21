using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingInfoScript : MonoBehaviour
{
    public GameObject king;
    public SpriteRenderer kingSprite;
    public PlayerLogicScript kingLogicScript;
    public bool hasKey = false;
    // Start is called before the first frame update
    void Start()
    {
        setSpriteInfo();
    }

    void setSpriteInfo()
    {
        kingSprite = king.GetComponent<SpriteRenderer>();
        kingLogicScript = king.GetComponent<PlayerLogicScript>();
    }

}
