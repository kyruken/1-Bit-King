using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    public string currentColor;
    public GameObject spawnPoint;
    public RespawnScript respawn;
    private SpriteRenderer wallSprite;
    private Sprite[] sprites;
    private string spriteNames = "Walls";

    void Start()
    {
        respawn = GameObject.FindGameObjectWithTag("Spawn").GetComponent<RespawnScript>();
        wallSprite = this.GetComponent<SpriteRenderer>();
        loadWalls();
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        GameObject king = coll.gameObject;
        string kingColor = king.GetComponent<PlayerLogicScript>().currentColor;
        if (coll.gameObject.tag == "Player" && currentColor.Equals(kingColor))
        {
            respawn.spawnAtLocation();
            respawn.spawnWithColor();
        }
    }

    private void loadWalls()
    {
        sprites = Resources.LoadAll<Sprite>(spriteNames);
    }
    public void changeWallColor()
    {
        if (currentColor == "White")
        {
            currentColor = "Black";
            wallSprite.sprite = sprites[0];
        }
        else 
        {
            currentColor = "White";
            wallSprite.sprite = sprites[1];
        }
    }
}
