using UnityEngine;

public class BasketTrigger : MonoBehaviour
{
    public Transform[] targetPositions;   // Array der möglichen Zielpositionen
    public Transform ringTrigger;         // Der Ring mit dem Trigger
    public Transform basketRoot;          // Das Hauptobjekt des Korbs (das gesamte Basket-Setup, was verschoben werden soll)
    public Transform startPosition;       // Startposition (optional)
    public ScoreManager scoreManager;     // Referenz zum ScoreManager
    public AudioSource netSound;          // AudioSource für den Sound beim Treffer

    private void Start()
    {
        // Sicherstellen, dass der Trigger korrekt eingestellt ist
        if (ringTrigger != null)
        {
            Collider col = ringTrigger.GetComponent<Collider>();
            if (col != null) col.isTrigger = true;
        }

        Debug.Log("BasketTrigger wurde korrekt initialisiert.");
    }

    private void OnTriggerEnter(Collider other)
    {
        // Prüfen, ob das kollidierende Objekt ein Basketball ist
        if (other.CompareTag("Basketball"))
        {
            Debug.Log("Ball ist durch den Korb gegangen! Korb bewegt sich...");

            // Punktestand erhöhen
            if (scoreManager != null)
            {
                scoreManager.AddPoint();
            }

            // Sound abspielen
            if (netSound != null)
            {
                netSound.Play();
            }

            // Korb verschieben
            MoveToRandomPredefinedPosition();
        }
    }

    private void MoveToRandomPredefinedPosition()
    {
        if (targetPositions.Length == 0)
        {
            Debug.LogWarning("Keine Zielpositionen definiert! Korb bleibt stehen.");
            return;
        }

        int index = Random.Range(0, targetPositions.Length);
        Transform newPosition = targetPositions[index];

        Vector3 fixedPosition = new Vector3(
            newPosition.position.x,
            basketRoot.position.y,
            newPosition.position.z
        );

        basketRoot.position = fixedPosition;
        basketRoot.rotation = newPosition.rotation;

        Debug.Log($"Korb ist jetzt an Position {index} mit Koordinaten {newPosition.position}");
    }
}

