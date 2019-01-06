using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEconomy : MonoBehaviour
{
    static Text goldText;
    // Start is called before the first frame update
    private void Start()
    {
        goldText = GetComponent<Text>();
    }

    public static void UpdateGold(int amt)
    {
        Debug.Log(goldText.text);
        var goldInt = int.Parse(goldText.text);
        goldInt += amt;
        goldText.text = goldInt.ToString();
    }
}
