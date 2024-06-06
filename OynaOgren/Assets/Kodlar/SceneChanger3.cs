using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger3 : MonoBehaviour
{
    public string ambulansEkran;

    private void OnTriggerEnter(Collider other)
    {
            SceneManager.LoadScene(12);
        
    }
}
