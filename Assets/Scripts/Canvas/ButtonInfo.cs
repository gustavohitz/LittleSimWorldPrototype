using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour {

    public Text txtPrice;
    public GameObject shopManager;
    public int itemID;
   

    void Update() {
        txtPrice.text = shopManager.GetComponent<ShopManager>().shopItems[2, itemID].ToString();
    }
}
