using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger1 : MonoBehaviour
{
    public string ambulansEkran;

    private void OnTriggerEnter(Collider other)
    {
            SceneManager.LoadScene(7);
        
    }
}
