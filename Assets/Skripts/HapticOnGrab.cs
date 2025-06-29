using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HapticOnGrab : MonoBehaviour
{
    public float amplitude = 0.5f; // Stärke der Vibration (0-1)
    public float duration = 0.15f; // Dauer in Sekunden

    private void OnEnable()
    {
        var interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
        if (interactable != null)
        {
            interactable.selectEntered.AddListener(OnGrab);
        }
    }

    private void OnDisable()
    {
        var interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
        if (interactable != null)
        {
            interactable.selectEntered.RemoveListener(OnGrab);
        }
    }

    private void OnGrab(SelectEnterEventArgs args)
    {
        if (args.interactorObject is UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor controllerInteractor)
        {
            controllerInteractor.SendHapticImpulse(amplitude, duration);
        }
    }
}
