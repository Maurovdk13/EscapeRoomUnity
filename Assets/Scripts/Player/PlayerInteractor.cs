using UnityEngine;
using TMPro;

public class PlayerInteractor : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;
    [SerializeField] private float interactDistance = 3f;
    [SerializeField] private GameObject interactionText;

    private void Update()
    {
        interactionText.SetActive(false);

        Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);

        Debug.DrawRay(ray.origin, ray.direction * interactDistance, Color.red);

        if (Physics.Raycast(ray, out RaycastHit hitInfo, interactDistance))
        {
            InteractableObject interactable = hitInfo.collider.GetComponent<InteractableObject>();

            if (interactable != null)
            {
                interactionText.SetActive(true);

                Debug.Log("Looking at: " + interactable.name);

                if (Input.GetKeyDown(KeyCode.E))
                {
                    interactable.Interact();
                }
            }
        }
    }
}