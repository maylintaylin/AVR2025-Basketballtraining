using UnityEngine;

public class BasketTrigger : MonoBehaviour
{
    public Transform[] targetPositions;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Basketball"))
        {
            Debug.Log("Korb getroffen!");
            MoveToRandomPredefinedPosition();
        }
    }

    private void MoveToRandomPredefinedPosition()
    {
        if (targetPositions.Length == 0) return;

        int index = Random.Range(0, targetPositions.Length);
        Transform newPos = targetPositions[index];

        transform.position = newPos.position;
        transform.rotation = newPos.rotation;
    }
}