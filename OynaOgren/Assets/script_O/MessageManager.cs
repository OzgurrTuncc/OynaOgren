using UnityEngine;
using TMPro;

public class MessageManager : MonoBehaviour
{
    public TMP_Text messageText;
    public float displayTime = 5f;

    private void Start()
    {
        // Yazýyý baþlangýçta göster
        DisplayMessage();

        // Belirli bir süre sonra yazýyý kaldýr
        Invoke("HideMessage", displayTime);
    }

    void DisplayMessage()
    {
        messageText.enabled = true; // Yazýyý göster
    }

    void HideMessage()
    {
        messageText.enabled = false; // Yazýyý gizle
    }
}
