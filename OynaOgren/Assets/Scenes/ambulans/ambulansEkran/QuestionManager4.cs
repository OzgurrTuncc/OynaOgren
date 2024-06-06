using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class QuestionManager4 : MonoBehaviour
{
    public TextMeshProUGUI questionText; 
    public Button[] answerButtons; 

   
    private string[] questions = { "Soru 1) Ambulans arac� ne zaman kullan�l�r?" };
    private string[] answers = { "A) Al��veri� yapmak i�in", "B) Hasta veya yaral� insanlar� hastaneye ta��mak i�in", "C) Okula gitmek i�in", "D) Tatil yapmak i�in" };

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
