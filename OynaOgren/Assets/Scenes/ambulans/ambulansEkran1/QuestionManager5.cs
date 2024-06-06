using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class QuestionManager5 : MonoBehaviour
{
    public TextMeshProUGUI questionText; 
    public Button[] answerButtons; 


    private string[] questions = { "Soru 2) Ambulansý aramak için hamgi numarayý tuþlamalýyýz?" };
    private string[] answers = { "A) 777", "B) 145", "C)112", "D) 121" };

   

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
        
        Debug.Log("Seçilen cevap: " + answers[answerIndex]);
       
        
    }
}
