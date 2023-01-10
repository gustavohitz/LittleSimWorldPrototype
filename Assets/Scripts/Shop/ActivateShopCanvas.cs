using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateShopCanvas : MonoBehaviour {

    public GameObject shopCanvas;
    private string _tagToFind = "Player";

    void Start() {
        shopCanvas.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag(_tagToFind)) {
            ShowShopCanvas();
            PauseTime();
        }
    }
    void ShowShopCanvas() {
        shopCanvas.SetActive(true);
    }
    void PauseTime() {
        Time.timeScale = 0;
    }
    public void UnpauseTime() {
        Time.timeScale = 1;
    }

}
