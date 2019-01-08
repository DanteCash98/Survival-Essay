using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdater : MonoBehaviour
{
    public static void UpdateText(int amt, Text textComponent)
    {
        var UIInt = int.Parse(textComponent.text);
        UIInt += amt;
        textComponent.text = UIInt.ToString();
    }
}
