using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class QuestionManager11 : MonoBehaviour
{
    public TextMeshProUGUI questionText;
    public Button[] answerButtons; 
    
    private string[] questions = { "Soru 3) Polis memuru ne giyer?" };
    private string[] answers = { "A) Pijama", "B) Polis �niformas�", "C) Kost�m", "D) Mayo" };

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
