using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class esyaText : MonoBehaviour
{
    Text text;
    public static int esyaAmount;


   
    void Start()
    {
        text = GetComponent<Text>();
    }

   
    void Update()
    {
        text.text = esyaAmount.ToString();
    }
}
