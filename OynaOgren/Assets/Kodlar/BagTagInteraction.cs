using UnityEngine;

public class takeAble : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // E�er nesneyle temas eden di�er nesne bir oyuncu ise
        if (other.CompareTag("Player"))
        {
            // Bu nesneyi etkisiz hale getir (yok etme)
            gameObject.SetActive(false);
        }
    }
}
