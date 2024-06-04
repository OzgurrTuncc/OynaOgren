using UnityEngine;
using System.Collections;

public class KameraSarsintisi : MonoBehaviour
{
    public float sarsintiSiddeti = 0.1f;
    public float sarsintiSuresi = 1.0f;
    public bool sarsintiDevam = false;

    private Vector3 baslangicPozisyonu;

    void Start()
    {
        baslangicPozisyonu = transform.localPosition;
    }

    public void DepremBaslat()
    {
        sarsintiDevam = true;
        StartCoroutine(Sarsinti());
    }

    public void DepremDurdur()
    {
        sarsintiDevam = false;
    }

    IEnumerator Sarsinti()
    {
        while (sarsintiDevam)
        {
            transform.localPosition = baslangicPozisyonu + Random.insideUnitSphere * sarsintiSiddeti;
            yield return null;
        }
        transform.localPosition = baslangicPozisyonu;
    }
}
