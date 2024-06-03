using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class QuestionManager4 : MonoBehaviour
{
    public TextMeshProUGUI questionText; // Soru metni
    public Button[] answerButtons; // Cevap düðmeleri

    // Sorular ve cevaplar
    private string[] questions = { "Soru 1) Ambulans aracý ne zaman kullanýlýr?" };
    private string[] answers = { "A) Alýþveriþ yapmak için", "B) Hasta veya yaralý insanlarý hastaneye taþýmak için", "C) Okula gitmek için", "D) Tatil yapmak için" };

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
