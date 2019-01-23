using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class GameOverPanel
{
    public GameManager gameManager;
    public GameObject panel;
    public Text score;
    public Text money;
    public Text time;


    public void SetActive(bool value)
    {
        panel.SetActive(value);
        if (value)
        {
            score.text = gameManager.player.score.ToString();
            money.text = gameManager.player.money.ToString();
            time.text = gameManager.player.time.ToString();

        }
    }

}