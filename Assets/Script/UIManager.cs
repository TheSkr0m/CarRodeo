using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    

    public GameOverPanel panel;
    public GamePanel gamePanel;
    public GameManager gameManager;
    private int time = 0;
    private int scoreTime = 0;
    private float currentTime = 0;
    private int minutes =0;
    private int seconds =0;
    private float currentScoreTime = 0;
    private float saveTime = 0;
    private float currentSaveTime = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    void Update()
    {
        currentTime += Time.deltaTime;
        currentScoreTime += Time.deltaTime;
        saveTime += Time.deltaTime;
        currentSaveTime = (int)saveTime;
        if (currentSaveTime == 1) {
            gameManager.player.time++;
            currentSaveTime = 0;
            saveTime = 0;
        }

        time = (int)currentTime;

        scoreTime = (int)currentScoreTime;
        Debug.Log(time);
        if (time == 60) {
            time = 0;
            minutes++;
            currentTime = 0;

        }
        if (scoreTime == 10) {

            gameManager.player.score += 100;
            scoreTime = 0;
            currentScoreTime = 0;
        }

        gamePanel.updateTime(minutes +" : " + time);


        gamePanel.updateScore(gameManager.player.score);

        

        //Debug.Log(minutes+":"+se);
    }

    public void UpdateMoney(int money)
    {
        gamePanel.updateMoney(money);

    }
}
