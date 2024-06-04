using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public KameraSarsintisi kameraSarsintisi;
    public Transform guvenliBolge;
    public float startDelay = 5.0f; // Deprem ba�lamadan �nceki s�re
    public GameObject congratulationsText; // UI Text GameObject
    private bool depremDevam = false;
    private Transform playerTransform;

    void Start()
    {
        // Depremi belirli bir s�re sonra ba�lat
        Invoke("DepremBaslat", startDelay);

        // Oyuncu transformunu bul
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            playerTransform = player.transform;
        }
        else
        {
            Debug.LogError("Player bulunamad�!");
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
            Invoke("SonrakiSahneyeGec", 5.0f); // 5 saniye bekle ve sahneyi de�i�tir
        }
    }

    void SonrakiSahneyeGec()
    {
        SceneManager.LoadScene(0); // "NextScene" yerine ge�mek istedi�iniz sahnenin ad�n� yaz�n
    }
}
