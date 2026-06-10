using UnityEngine;

public class KeyItem : InteractableObject
{
    public override void Interact()
    {
        Debug.Log("Key collected");

        gameObject.SetActive(false);
    }
}