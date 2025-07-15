using UnityEngine;

public class BasketTrigger : MonoBehaviour
{
    public Transform[] targetPositions;   // Array der möglichen Zielpositionen
    public Transform ringTrigger;         // Der Ring mit dem Trigger
    public Transform basketRoot;          // Das Hauptobjekt des Korbs (das gesamte Basket-Setup, was verschoben werden soll)

    public ScoreManager scoreManager;     // NEU: Referenz zum ScoreManager

    // Start-Methode: Wird bei Spielstart aufgerufen
    private void Start()
    {
        // Sicherstellen, dass der Trigger korrekt eingestellt ist
        if (ringTrigger != null)
        {
            Collider col = ringTrigger.GetComponent<Collider>();
            if (col != null) col.isTrigger = true; // Trigger aktivieren
        }

        // Debug-Log für Initialisierung
        Debug.Log("BasketTrigger wurde korrekt initialisiert.");
    }

    // Trigger-Kollision prüfen
    private void OnTriggerEnter(Collider other)
    {
        // Prüfen, ob das kollidierende Objekt ein Basketball ist
        if (other.CompareTag("Basketball"))
        {
            Debug.Log("Ball ist durch den Korb gegangen! Korb bewegt sich...");

            // NEU: Punktestand erhöhen
            if (scoreManager != null)
            {
                scoreManager.AddPoint();
            }

            // Korb verschieben
            MoveToRandomPredefinedPosition();
        }
    }

    // Korb an eine zufällige vorgegebene Position bewegen
    private void MoveToRandomPredefinedPosition()
    {
        // Wenn keine Zielpositionen definiert sind, nichts tun
        if (targetPositions.Length == 0)
        {
            Debug.LogWarning("Keine Zielpositionen definiert! Korb bleibt stehen.");
            return;
        }

        // Zufällige Position im Array auswählen
        int index = Random.Range(0, targetPositions.Length);
        Transform newPosition = targetPositions[index];

        // Korb an die neue Position und Rotation bewegen
        basketRoot.position = newPosition.position;
        basketRoot.rotation = newPosition.rotation;

        Debug.Log($"Korb ist jetzt an Position {index} mit Koordinaten {newPosition.position}");
    }
}
