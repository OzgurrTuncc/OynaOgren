using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class QuestionManager : MonoBehaviour
{
    public TextMeshProUGUI questionText;
    public Button[] answerButtons; 

    
    private string[] questions = { "Soru 1) �tfaiye arac� hangi acil durumda kullan�l�r?" };
    private string[] answers = { "A) Yang�n s�nd�rme", "B) Su ta��ma", "C) Yol yap�m�", "D) ��p toplama" };

    private void Start()
    {
        
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        
        ShowQuestion(0);
    }

    public void ShowQuestion(int questionIndex)
    {
        
        questionText.text = questions[questionIndex];

        
        for (int i = 0; i < answerButtons.Length; i++)
        {
            answerButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = answers[i];
        }
    }

    
    public void AnswerButtonClicked(int answerIndex)
    {
        
        Debug.Log("Se�ilen cevap: " + answers[answerIndex]);
       
    }
}
