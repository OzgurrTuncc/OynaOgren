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

            // Temas edilen nesneyi yok edin veya istediğiniz işlemi gerçekleştirin
            other.gameObject.SetActive(false);

            // esyaAmount 20 ise menü sahnesine geçiş yap
            if (esyaText.esyaAmount >= 20)
            {
                SceneManager.LoadScene("menu"); // "menu" sahnesine geçiş yap
            }
        }
    }
}
