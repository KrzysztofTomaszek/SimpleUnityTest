using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float MaxInteract = 3f;

    public bool CanInteract(Transform other) {
        if(Vector3.Distance(other.position, transform.position) <= MaxInteract)
        {
            Debug.Log("W zasięgu interakcji");
            return true;
        }
        Debug.Log("Stoisz za daleko");
        return false;
    }

    public virtual void Interact() {
        Debug.Log("Interaktujesz");
    }
    
}
