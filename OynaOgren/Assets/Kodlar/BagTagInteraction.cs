using UnityEngine;

public class takeAble : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Eðer nesneyle temas eden diðer nesne bir oyuncu ise
        if (other.CompareTag("Player"))
        {
            // Bu nesneyi etkisiz hale getir (yok etme)
            gameObject.SetActive(false);
        }
    }
}
