using UnityEngine;
using UnityEngine.SceneManagement;

public class BagTagInteraction : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("takeAble"))
        {
            esyaText.esyaAmount += 1;

            
            other.gameObject.SetActive(false);

            
            if (esyaText.esyaAmount >= 20)
            {
                SceneManager.LoadScene(17);
            }
        }
    }
}
