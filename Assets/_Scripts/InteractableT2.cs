using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableT2 : Interactable
{
    public override void Interact()
    {
        base.Interact();
        Debug.Log("Interaktujesz z boxem T2");
        gameObject.transform.localScale += new Vector3(3, 3, 3);
        gameObject.transform.position += new Vector3(-3, 3, -5);
    }
}
