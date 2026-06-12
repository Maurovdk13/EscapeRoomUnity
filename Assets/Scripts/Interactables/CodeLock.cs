using System.Collections;
using UnityEngine;
using TMPro;

public class CodeLock : MonoBehaviour
{
    [SerializeField] private TMP_InputField codeInput;
    [SerializeField] private TextMeshProUGUI resultText;
    [SerializeField] private GameObject doorToOpen;
    [SerializeField] private GameObject codePanel;

    [SerializeField] private string correctCode = "9264";

    public void CheckCode()
    {
        if (codeInput.text == correctCode)
        {
            resultText.text = "Correct";
            doorToOpen.SetActive(false);

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            StartCoroutine(HidePanelAfterDelay());
        }
        else
        {
            resultText.text = "Wrong";
        }
    }

    private IEnumerator HidePanelAfterDelay()
    {
        yield return new WaitForSeconds(3f);

        codePanel.SetActive(false);
    }
}