using UnityEngine;
using UnityEngine.UI;
public class GameManger : MonoBehaviour
{
    public Player player;
    public Text scoretext;
    public GameObject playbutton;
    public GameObject gameover;
    private int score;


    private void awake()
    {
        Application.targetFrameRate=60;
        pause();

    }
    public void play()
    {
        score=0;
        scoretext.text=score.ToString();

        playbutton.SetActive(false);
        gameover.SetActive(false);

        Time.timeScale=1f;
        player.enabled = true;

        pipes[] pipes = FindObjectsOfType<pipes>();
        for(int i=0 ; i<pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }
    public void pause()
    {
        Time.timeScale=0f;
        player.enabled = false;
    }
    public void GameOver()
    {
       gameover.SetActive(true);
       playbutton.SetActive(true);

       pause();
    }

    public void IncreaseScore()
    {
        score++;
        scoretext.text=score.ToString();
    }
}
