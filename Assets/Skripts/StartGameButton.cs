using UnityEngine;


public class StartGameButton : MonoBehaviour
{
    public GameObject basketball;      // Der erste Ball
    public GameObject timerUI;         // Optional: UI für Timer
    public float gameDuration = 90f;   // z. B. 60 Sekunden Spielzeit

    private float timer;
    private bool gameRunning = false;

    public void StartGame(UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor interactor)
    {
        Debug.Log("Spiel gestartet!");

        if (basketball != null) basketball.SetActive(true);
        if (timerUI != null) timerUI.SetActive(true);

        timer = gameDuration;
        gameRunning = true;
    }

    void Update()
    {
        if (gameRunning)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                Debug.Log("Spiel beendet!");
                gameRunning = false;
                // Optional: Spiel beenden oder ausblenden
            }
        }
    }
}
