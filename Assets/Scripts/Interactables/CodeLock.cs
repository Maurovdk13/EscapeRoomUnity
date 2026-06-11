using UnityEngine;
using TMPro;

public class CodeLock : MonoBehaviour
{
    [SerializeField] private TMP_InputField codeInput;
    [SerializeField] private TextMeshProUGUI resultText;
    [SerializeField] private GameObject doorToOpen;

    [SerializeField] private string correctCode = "9264";

    public void CheckCode()
    {
        if (codeInput.text == correctCode)
        {
            resultText.text = "Correct";
            doorToOpen.SetActive(false);
        }
        else
        {
            resultText.text = "Wrong";
        }
    }
}