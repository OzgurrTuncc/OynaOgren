using UnityEngine;
using UnityEngine.SceneManagement;

public class BagTagInteraction : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Temas eden nesnenin etiketini kontrol edin
        if (other.CompareTag("takeAble"))
        {
            esyaText.esyaAmount += 1;

            // Temas edilen nesneyi yok edin veya istedi�iniz i�lemi ger�ekle�tirin
            other.gameObject.SetActive(false);

            // esyaAmount 20 ise men� sahnesine ge�i� yap
            if (esyaText.esyaAmount >= 20)
            {
                SceneManager.LoadScene("menu"); // "menu" sahnesine ge�i� yap
            }
        }
    }
}
