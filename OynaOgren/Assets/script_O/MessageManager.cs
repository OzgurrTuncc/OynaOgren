using UnityEngine;
using TMPro;

public class MessageManager : MonoBehaviour
{
    public TMP_Text messageText;
    public float displayTime = 5f;

    private void Start()
    {
        // Yaz�y� ba�lang��ta g�ster
        DisplayMessage();

        // Belirli bir s�re sonra yaz�y� kald�r
        Invoke("HideMessage", displayTime);
    }

    void DisplayMessage()
    {
        messageText.enabled = true; // Yaz�y� g�ster
    }

    void HideMessage()
    {
        messageText.enabled = false; // Yaz�y� gizle
    }
}
