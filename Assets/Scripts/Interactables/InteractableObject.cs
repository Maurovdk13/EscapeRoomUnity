using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    [SerializeField] private string interactionText = "Press E";

    public string InteractionText
    {
        get { return interactionText; }
    }

    public virtual void Interact()
    {
        Debug.Log("Interacted with " + gameObject.name);
    }
}