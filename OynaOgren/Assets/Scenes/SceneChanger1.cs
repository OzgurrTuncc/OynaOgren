using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger1 : MonoBehaviour
{
    public string ambulansEkran; // Y�nlendirilecek sahnenin ad�

    private void OnTriggerEnter(Collider other)
    {
       
        
            // Oyuncu b�lgeye girdi�inde yeni sahneye y�nlendir
            SceneManager.LoadScene(7);
        
    }
}
