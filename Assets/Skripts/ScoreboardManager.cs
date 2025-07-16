using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreboardManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text timerText;
    public Button startButton;

    private int score = 0;
    private float timeRemaining = 60f;
    private bool timerRunning = false;

    void Start()
    {
        UpdateScore(0);
        timerText.text = FormatTime(timeRemaining);
        startButton.onClick.AddListener(StartGame);
    }

    void Update()
    {
        if (timerRunning)
        {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining <= 0)
            {
                timeRemaining = 0;
                timerRunning = false;
                Debug.Log("Zeit abgelaufen!");
            }
            timerText.text = FormatTime(timeRemaining);
        }
    }

    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Treffer: " + score;
    }

    public void StartGame()
    {
        score = 0;
        UpdateScore(0);
        timeRemaining = 60f;
        timerRunning = true;
        startButton.gameObject.SetActive(false);
    }

    private string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
