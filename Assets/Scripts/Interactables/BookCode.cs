using UnityEngine;

public class BookCode : InteractableObject
{
    [SerializeField] private string codeText = "Code: 1234";

    public override void Interact()
    {
        Debug.Log(codeText);
    }
}