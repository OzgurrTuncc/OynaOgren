using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string itfaiyeEkran; // Yönlendirilecek sahnenin adý

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Oyuncu bölgeye girdiðinde yeni sahneye yönlendir
            SceneManager.LoadScene(2);
        }
    }
}
