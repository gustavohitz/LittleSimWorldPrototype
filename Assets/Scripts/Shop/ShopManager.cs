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
    public Image originalOutfitImage;
    public Button redButton;
    public Button blueButton;
    public Button greyButton;
    public AudioClip coinSFX;

    
    
    void Start() {
        redOutfitImage.enabled = false;
        blueOutfitImage.enabled = false;
        greyOutfitImage.enabled = false;
        originalOutfitImage.enabled = true;

        currentCoins = startCoins;
        txtCoins.text = currentCoins.ToString();

        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;

        shopItems[2, 1] = 100;
        shopItems[2, 2] = 200;
        shopItems[2, 3] = 300;
    }

    void Update() {
        DeactivateGreyButton();
        DeactivateBlueButton();
        DeactivateRedButton();
    }

    public void BuyItems() {
        GameObject refbutton = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if(currentCoins >= shopItems[2, refbutton.GetComponent<ButtonInfo>().itemID]) {
            SubtractCoins(shopItems[2, refbutton.GetComponent<ButtonInfo>().itemID]);
        }
    }

    void DeactivateGreyButton() {
        if(currentCoins < 300) {
            greyButton.interactable = false;
        }
    }

    void DeactivateBlueButton() {
        if(currentCoins < 200) {
            blueButton.interactable = false;
        }
    }    

    void DeactivateRedButton() {
        if(currentCoins < 100) {
            redButton.interactable = false;
        }
    }
       
    void SubtractCoins(int price) {
        currentCoins -= price;
        txtCoins.text = currentCoins.ToString();
        AudioManager.instance.PlayOneShot(coinSFX);
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
