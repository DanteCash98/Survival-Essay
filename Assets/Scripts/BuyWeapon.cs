using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyWeapon : MonoBehaviour
{
    public int price = 100;
    public Text buyText;
    public Text goldAmountText;
    
    private bool inBuyRange = false;
    private int goldAmount;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetType() != typeof(CharacterController)) return;
        
        goldAmount = int.Parse(goldAmountText.text);
        buyText.text = "Press [E] to buy " + gameObject.name + "\nPrice: " + price + " Gold";
        inBuyRange = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.GetType() != typeof(CharacterController)) return;

        buyText.text = "";
        inBuyRange = false;
    }

    private void Update()
    {
        if (inBuyRange && Input.GetKeyDown(KeyCode.E))
        {
            if(goldAmount >= price)
            {
                ReplaceWeapon();
            }
        }
    }

    private void ReplaceWeapon()
    {
        
    }
}
