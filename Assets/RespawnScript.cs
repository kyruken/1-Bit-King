using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RespawnScript : MonoBehaviour
{
    public ColorSwitchScript colorSwitch;
    public KingInfoScript kingInfo;
    public GameObject king;
    public string spawnColor;
    public GameObject spawnPoint;

    void Start()
    {
        king = GameObject.FindGameObjectWithTag("Player");
        kingInfo = GameObject.FindGameObjectWithTag("Player").GetComponent<KingInfoScript>();
        spawnPoint = GameObject.FindGameObjectWithTag("Spawn");
    }
    public void spawnWithColor()
    {
        string currentColor = kingInfo.kingLogicScript.currentColor;
        colorSwitch.setNewKingColorForSpawn(currentColor, spawnColor);
    }

    public void spawnAtLocation()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
