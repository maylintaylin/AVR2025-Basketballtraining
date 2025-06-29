using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BallHaptics : MonoBehaviour
{
    public void SendHaptic(UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor interactor)
    {
        if (interactor is UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor controllerInteractor)
        {
            controllerInteractor.xrController.SendHapticImpulse(0.6f, 0.2f);
        }
    }
}
