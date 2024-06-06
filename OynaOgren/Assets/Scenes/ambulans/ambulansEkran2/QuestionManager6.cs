using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class QuestionManager6 : MonoBehaviour
{
    public TextMeshProUGUI questionText; 
    public Button[] answerButtons;

    
    private string[] questions = { "Soru 3) Ambulansýn içinde genellikle ne bulunur?" };
    private string[] answers = { "A) Oyun konsolu", "B) Yatak ve týbbi ekipman", "C) Mutfak seti", "D) Spor aletleri" };
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
