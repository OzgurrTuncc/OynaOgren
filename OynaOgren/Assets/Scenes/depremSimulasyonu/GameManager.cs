using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public KameraSarsintisi kameraSarsintisi;
    public Transform guvenliBolge;
    public float startDelay = 5.0f; 
    public GameObject congratulationsText; 
    private bool depremDevam = false;
    private Transform playerTransform;

    void Start()
    {
        
        Invoke("DepremBaslat", startDelay);

        
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            playerTransform = player.transform;
        }
        else
        {
            Debug.LogError("Player bulunamadý!");
        }
    }

    void Update()
    {
        if (depremDevam && Vector3.Distance(playerTransform.position, guvenliBolge.position) < 1.0f)
        {
            DepremDurdur();
            TebriklerGoster();
        }
    }

    void DepremBaslat()
    {
        if (kameraSarsintisi != null)
        {
            kameraSarsintisi.DepremBaslat();
            depremDevam = true;
        }
    }

    void DepremDurdur()
    {
        if (kameraSarsintisi != null)
        {
            kameraSarsintisi.DepremDurdur();
            depremDevam = false;
        }
    }

    void TebriklerGoster()
    {
        if (congratulationsText != null)
        {
            congratulationsText.SetActive(true);
            Invoke("SonrakiSahneyeGec", 5.0f); 
        }
    }

    void SonrakiSahneyeGec()
    {
        SceneManager.LoadScene(0); 
    }
}
