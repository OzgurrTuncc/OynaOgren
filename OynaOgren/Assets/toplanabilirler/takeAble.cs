using UnityEngine;

public class BagTagInteraction : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Temas eden nesnenin etiketini kontrol edin
        if (other.CompareTag("takeAble"))
        {
            esyaText.esyaAmount += 1;
            // Temas edilen nesneyi yok edin veya istediðiniz iþlemi gerçekleþtirin
            other.gameObject.SetActive(false);
            //Debug.Log("Bag tag'ine sahip bir eþyaya temas edildi ve yok edildi."); // Ýsteðe baðlý olarak konsola bir mesaj yazdýrabilirsiniz
            // Buraya bag tag'ine sahip bir eþyaya temas edildiðinde gerçekleþmesini istediðiniz diðer iþlemleri ekleyebilirsiniz
        }
    }
}
