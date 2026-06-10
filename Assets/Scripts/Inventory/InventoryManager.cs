using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    private bool hasKey;

    public bool HasKey
    {
        get { return hasKey; }
    }

    public void AddKey()
    {
        hasKey = true;

        Debug.Log("Key added to inventory");
    }
}