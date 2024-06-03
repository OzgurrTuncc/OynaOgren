using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections; // Sahne y�netimi i�in eklenmesi gereken k�t�phane

public class ButtonColorChanger8 : MonoBehaviour
{
    private Button button;
    private bool clicked = false;
    private float waitTime = 2f;

    private Color greenColor = Color.green;
    private Color redColor = Color.red;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ChangeButtonColor);
    }

    private void ChangeButtonColor()
    {
        if (clicked)
            return;

        if (button.CompareTag("dogru"))
        {
            button.image.color = greenColor;
            StartCoroutine(WaitAndLoadScene());
            /*SceneManager.LoadScene("Sahne3"); // "Sahne3" yerine ge�mek istedi�in sahnenin ad�n� yaz*/
        }
        else if (button.CompareTag("yanlis"))
        {
            button.image.color = redColor;
            GameObject[] correctButtons = GameObject.FindGameObjectsWithTag("dogru");
            foreach (GameObject correctButton in correctButtons)
            {
                correctButton.GetComponent<Button>().image.color = greenColor;
            }
        }

        clicked = true;
    }
    private IEnumerator WaitAndLoadScene()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(9); // Yeni sahnenin ad�n� yaz
    }
}


