using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitchScript : MonoBehaviour
{
    public KingInfoScript kingInfo;
    public bool destroyOnLeave = false;
    private Sprite[] sprites;
    private string spriteNames = "Sprites";

    void Start()
    {
        kingInfo = GameObject.FindGameObjectWithTag("Player").GetComponent<KingInfoScript>();
        loadSprites();
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            if (checkCurrentKingColorIsWhite(kingInfo.kingLogicScript.currentColor))
            {
                changeKingColor(kingInfo.kingSprite, sprites[0], kingInfo.kingLogicScript, "Black");
            }
            else 
            {
                changeKingColor(kingInfo.kingSprite, sprites[1], kingInfo.kingLogicScript, "White");
            }

        }
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        if (destroyOnLeave == true)
        {
            Destroy(gameObject);
        }
    }

    private void loadSprites()
    {
        sprites = Resources.LoadAll<Sprite>(spriteNames);
    }

    private bool checkCurrentKingColorIsWhite(string kingColor)
    {
        return kingColor == "White";
    }

    private void changeKingColor(SpriteRenderer kingSprite, Sprite spriteFile, PlayerLogicScript kingLogicScript, string kingNewColor)
    {
        kingSprite.sprite = spriteFile;
        kingLogicScript.currentColor = kingNewColor;
    }

    public void setNewKingColorForSpawn(string currentColor, string newColor)
    {
        if (currentColor != newColor)
        {
            if (newColor == "Black")
            {
                changeKingColor(kingInfo.kingSprite, sprites[0], kingInfo.kingLogicScript, newColor);
            }
            else 
            {
                changeKingColor(kingInfo.kingSprite, sprites[1], kingInfo.kingLogicScript, newColor);
            }
        }  
    }
}
