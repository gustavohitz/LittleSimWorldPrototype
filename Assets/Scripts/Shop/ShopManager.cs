using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;


public class ShopManager : MonoBehaviour {
   
    public int [,] shopItems = new int[5, 5];
    public int startCoins = 600;
    public int currentCoins;
    public TextMeshProUGUI txtCoins;
    public Image redOutfitImage;
    public Image blueOutfitImage;
    public Image greyOutfitImage;
    
    void Start() {
        redOutfitImage.enabled = false;
        blueOutfitImage.enabled = false;
        greyOutfitImage.enabled = false;

        currentCoins = startCoins;
        txtCoins.text = currentCoins.ToString();

        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;

        shopItems[2, 1] = 100;
        shopItems[2, 2] = 200;
        shopItems[2, 3] = 300;
    }

    public void BuyItems() {
        GameObject refbutton = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if(currentCoins >= shopItems[2, refbutton.GetComponent<ButtonInfo>().itemID]) {
            SubtractCoins(shopItems[2, refbutton.GetComponent<ButtonInfo>().itemID]);
        }
    }
    void SubtractCoins(int price) {
        currentCoins -= price;
        txtCoins.text = currentCoins.ToString();
    }
    public void ActivateRedOutfitButton() {
        redOutfitImage.enabled = true;
    }
    public void ActivateBlueOutfitButton() {
        blueOutfitImage.enabled = true;
    }
    public void ActivateGreyOutfitButton() {
        greyOutfitImage.enabled = true;
    }

}
