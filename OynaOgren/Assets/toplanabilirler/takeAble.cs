using UnityEngine;

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
            //Debug.Log("Bag tag'ine sahip bir e�yaya temas edildi ve yok edildi."); // �ste�e ba�l� olarak konsola bir mesaj yazd�rabilirsiniz
            // Buraya bag tag'ine sahip bir e�yaya temas edildi�inde ger�ekle�mesini istedi�iniz di�er i�lemleri ekleyebilirsiniz
        }
    }
}
