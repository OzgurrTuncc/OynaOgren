using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string itfaiyeEkran; // Y�nlendirilecek sahnenin ad�

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Oyuncu b�lgeye girdi�inde yeni sahneye y�nlendir
            SceneManager.LoadScene(2);
        }
    }
}
