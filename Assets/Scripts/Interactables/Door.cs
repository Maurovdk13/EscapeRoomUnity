using UnityEngine;

public class Door : InteractableObject
{
    [SerializeField] private InventoryManager inventoryManager;

    public override void Interact()
    {
        if (inventoryManager.HasKey)
        {
            Debug.Log("Door opened");
            gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("Door is locked");
        }
    }
}