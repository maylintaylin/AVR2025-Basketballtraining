using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BallBounceSound : MonoBehaviour
{
    public AudioClip bounceClip;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor") || collision.contacts[0].normal.y > 0.5f)
        {
            if (bounceClip != null)
            {
                audioSource.PlayOneShot(bounceClip);
            }
        }
    }
}
