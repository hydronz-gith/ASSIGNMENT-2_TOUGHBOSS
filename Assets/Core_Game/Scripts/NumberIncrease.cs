using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberIncrease : MonoBehaviour
{
    public TextMeshProUGUI numberText;
    int counter;


    public void ButtonPressed()
    {
       counter ++ ;
       numberText.text = counter + "";
    }
}
