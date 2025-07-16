using UnityEngine;

public class BasketTriggerScore : MonoBehaviour
{
    public ScoreboardManager scoreboardManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Basketball"))
        {
            scoreboardManager.UpdateScore(1);
        }
    }
}
