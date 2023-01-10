using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateShopCanvas : MonoBehaviour {

    public GameObject shopCanvas;
    private string _tagToFind = "Player";

    void Start() {
        shopCanvas.SetActive(false);
    }

    public void ShowShopCanvas() {
        shopCanvas.SetActive(true);
    }
    public void PauseTime() {
        Time.timeScale = 0;
    }

    public void UnpauseTime() {
        Time.timeScale = 1;
    }

}
