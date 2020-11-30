using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractionComponent : MonoBehaviour
{
    Interactable ObjectToInteract = null;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && ObjectToInteract != null)
            InteractWithInteractable();
    }

    void InteractWithInteractable()
    {
        if(ObjectToInteract.CanInteract(transform))
            ObjectToInteract.Interact();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Zasubskrybowałeś obiekt " + other.gameObject);
        ObjectToInteract = other.gameObject.GetComponent<Interactable>();
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Subskrybcja obiektu "+ ObjectToInteract.name + " anulowana");
        ObjectToInteract = null;
    }
}
