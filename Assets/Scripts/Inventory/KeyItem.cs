using UnityEngine;

public class KeyItem : InteractableObject
{
    [SerializeField] private InventoryManager inventoryManager;

    public override void Interact()
    {
        inventoryManager.AddKey();
        Debug.Log("Key collected");
        gameObject.SetActive(false);
    }
}
