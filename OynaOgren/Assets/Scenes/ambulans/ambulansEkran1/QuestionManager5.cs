using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class QuestionManager5 : MonoBehaviour
{
    public TextMeshProUGUI questionText; // Soru metni
    public Button[] answerButtons; // Cevap düðmeleri

    // Sorular ve cevaplar
    private string[] questions = { "Soru 2) Ambulansý aramak için hamgi numarayý tuþlamalýyýz?" };
    private string[] answers = { "A) 777", "B) 145", "C)112", "D) 121" };

    private void Start()
    {
        // Fare imlecini görünür yap
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        // Baþlangýçta ilk soruyu göster
        ShowQuestion(0);
    }

    public void ShowQuestion(int questionIndex)
    {
        // Soru metnini güncelle
        questionText.text = questions[questionIndex];

        // Cevap düðmelerini güncelle
        for (int i = 0; i < answerButtons.Length; i++)
        {
            answerButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = answers[i];
        }
    }

    // Her düðmeye týklandýðýnda çaðrýlacak iþlevler
    public void AnswerButtonClicked(int answerIndex)
    {
        // Cevabý kontrol et ve gerekirse iþlemleri yap
        Debug.Log("Seçilen cevap: " + answers[answerIndex]);
        // Diðer soruya geçmek için
         //SceneManager.LoadScene(3);
    }
}
