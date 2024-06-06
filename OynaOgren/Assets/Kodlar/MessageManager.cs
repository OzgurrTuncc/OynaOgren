using UnityEngine;
using TMPro;

public class MessageManager : MonoBehaviour
{
    public TMP_Text messageText;
    public float displayTime = 5f;

    private void Start()
    {
        
        DisplayMessage();

       
        Invoke("HideMessage", displayTime);
    }

    void DisplayMessage()
    {
        messageText.enabled = true; 
    }

    void HideMessage()
    {
        messageText.enabled = false; 
    }
}
