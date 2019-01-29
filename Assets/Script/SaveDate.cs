using UnityEngine;
using System.Collections;

public class SaveDate 
{
    public GameManager gameManager;
    public GamePanel gamePanel;

    public SaveDate(GameManager gameManager)
    {
        this.gameManager = gameManager;
    }


    public void Save()
    {

        PlayerPrefs.SetInt("Score", gameManager.player.score);
        PlayerPrefs.SetInt("Money", gameManager.player.money);
        PlayerPrefs.SetInt ("Time", gameManager.player.time);


    }

    


}
