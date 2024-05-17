using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class buttonPopup : MonoBehaviour
{
    public TextMeshProUGUI text;
    public void clicked()
    {
        text.enabled = true;
        text.text = "Button Clicked";
    }
}
