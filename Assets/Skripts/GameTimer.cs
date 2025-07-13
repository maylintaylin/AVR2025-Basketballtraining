using TMPro;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    [Header("Timer-Einstellungen")]
    public float timeRemaining = 90f;
    public bool timerRunning = false;

    [Header("Referenzen")]
    public TextMeshProUGUI timerText;      // Das UI-Textfeld für den Timer
    public GameObject startButton;         // Der Start-Button, der deaktiviert wird

    void Update()
    {
        if (timerRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                UpdateTimerDisplay();
            }
            else
            {
                timeRemaining = 0;
                timerRunning = false;
                timerText.text = "⏱ Zeit abgelaufen!";
            }
        }
    }

    public void StartTimer()
    {
        timeRemaining = 60f;
        timerRunning = true;
        UpdateTimerDisplay();

        // Button deaktivieren
        if (startButton != null)
        {
            startButton.SetActive(false);
        }
    }

    void UpdateTimerDisplay()
    {
        int seconds = Mathf.CeilToInt(timeRemaining);
        timerText.text = "Zeit: " + seconds.ToString() + "s";
    }
}
