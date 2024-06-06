using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class QuestionManager1 : MonoBehaviour
{
    public TextMeshProUGUI questionText; 
    public Button[] answerButtons; 

    
    private string[] questions = { "Soru 2) �tfaiye arac�n�n �zerinde hangi ekipmanlar bulunur?" };
    private string[] answers = { "A) Futbol topu", "B) Merdiven", "C) Yol yap�m�", "D) Bisiklet" };
  
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
