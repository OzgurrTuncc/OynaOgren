using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class QuestionManager7 : MonoBehaviour
{
    public TextMeshProUGUI questionText; // Soru metni
    public Button[] answerButtons; // Cevap d��meleri

    // Sorular ve cevaplar
    private string[] questions = { "Soru 4) Ambulans s�r�c�s� ne giyer?" };
    private string[] answers = { "A) Astronot k�yafeti", "B) Denizci �niformas�", "C) �� tak�m elbisesi", "D) Sa�l�k �al��an� �niformas� " };

    private void Start()
    {
        // Fare imlecini g�r�n�r yap
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        // Ba�lang��ta ilk soruyu g�ster
        ShowQuestion(0);
    }

    public void ShowQuestion(int questionIndex)
    {
        // Soru metnini g�ncelle
        questionText.text = questions[questionIndex];

        // Cevap d��melerini g�ncelle
        for (int i = 0; i < answerButtons.Length; i++)
        {
            answerButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = answers[i];
        }
    }

    // Her d��meye t�kland���nda �a�r�lacak i�levler
    public void AnswerButtonClicked(int answerIndex)
    {
        // Cevab� kontrol et ve gerekirse i�lemleri yap
        Debug.Log("Se�ilen cevap: " + answers[answerIndex]);
        // Di�er soruya ge�mek i�in
         //SceneManager.LoadScene(3);
    }
}
