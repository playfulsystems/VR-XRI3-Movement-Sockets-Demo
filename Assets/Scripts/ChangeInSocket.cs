using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit;

public class ChangeInSocket : MonoBehaviour
{
    XRSocketInteractor socketInteractor;

    private void OnEnable()
    {
        socketInteractor = GetComponent<XRSocketInteractor>();
        socketInteractor.selectEntered.AddListener(ObjectAttachedEvent);
        socketInteractor.selectExited.AddListener(ObjectDetachedEvent);
    }
    private void OnDisable()
    {
        socketInteractor.selectEntered.RemoveListener(ObjectAttachedEvent);
        socketInteractor.selectExited.RemoveListener(ObjectDetachedEvent);
    }
    public void ObjectAttachedEvent(SelectEnterEventArgs args)
    {
        args.interactableObject.transform.GetComponent<MeshRenderer>().material.color = Color.white;
    }
    public void ObjectDetachedEvent(SelectExitEventArgs args)
    {
        args.interactableObject.transform.GetComponent<MeshRenderer>().material.color = Color.red;
    }

}
