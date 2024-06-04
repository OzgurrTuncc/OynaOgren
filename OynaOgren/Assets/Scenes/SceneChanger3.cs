using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger3 : MonoBehaviour
{
    public string ambulansEkran; // Yönlendirilecek sahnenin adý

    private void OnTriggerEnter(Collider other)
    {
       
        
            // Oyuncu bölgeye girdiðinde yeni sahneye yönlendir
            SceneManager.LoadScene(12);
        
    }
}
