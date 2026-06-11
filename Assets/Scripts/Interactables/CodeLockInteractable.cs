using UnityEngine;

public class CodeLockInteractable : InteractableObject
{
    [SerializeField] private GameObject codePanel;

    public override void Interact()
    {
        codePanel.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}