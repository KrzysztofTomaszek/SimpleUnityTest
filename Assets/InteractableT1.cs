using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableT1: Interactable
{
    public Material Material;
    public override void Interact()
    {
        base.Interact();
        Debug.Log("Interaktujesz z boxem T1");
        gameObject.GetComponent<MeshRenderer>().material = Material;
    }                  
}
