using UnityEngine;

public class BasketTrigger : MonoBehaviour
{
    public Transform[] targetPositions;   // Array der möglichen Zielpositionen
    public Transform ringTrigger;         // Der Ring mit dem Trigger
    public Transform basketRoot;          // Das Hauptobjekt des Korbs (das gesamte Basket-Setup, was verschoben werden soll)
    public Transform startPosition;       // Startposition für den Korb (neu!)

    private void Start()
    {
        // Sicherstellen, dass der Trigger korrekt eingestellt ist
        if (ringTrigger != null)
        {
            Collider col = ringTrigger.GetComponent<Collider>();
            if (col != null) col.isTrigger = true; // Trigger aktivieren
        }

        // // Korb an Startposition setzen (neu!)
        // if (startPosition != null)
        // {
        //     basketRoot.position = startPosition.position;
        //     basketRoot.rotation = startPosition.rotation;
        //     Debug.Log("Korb wurde zur Startposition gesetzt.");
        // }

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
        Vector3 fixedPosition = new Vector3(
            newPosition.position.x,
            basketRoot.position.y,    // Behalte ursprüngliche Y-Position
            newPosition.position.z
        );

        basketRoot.position = fixedPosition;
        basketRoot.rotation = newPosition.rotation;

        Debug.Log($"Korb ist jetzt an Position {index} mit Koordinaten {newPosition.position}");
    }
}
