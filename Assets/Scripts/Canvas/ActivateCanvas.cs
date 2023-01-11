using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateCanvas : MonoBehaviour {

    public GameObject canvas;
    public GameObject interactionIcon;

    private string _tagToCheck = "Player";
    private bool _canReadMessage = false;
    

    void Start() {
        canvas.SetActive(false);
        interactionIcon.SetActive(false);
    }
    void Update() {
        ReadMessage();
    }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag(_tagToCheck)) {
            interactionIcon.SetActive(true);
            _canReadMessage = true;
        }
    }
    void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag(_tagToCheck)) {
            interactionIcon.SetActive(false);
            _canReadMessage = false;
        }
    }
    void ReadMessage() {
        if(Input.GetKeyDown(KeyCode.Z) && _canReadMessage) {
            interactionIcon.SetActive(false);
            ShowCanvas();
            PauseTime();
        }
    }

    void ShowCanvas() {
        canvas.SetActive(true);
    }
    void PauseTime() {
        Time.timeScale = 0;
    }

    public void UnpauseTime() {
        Time.timeScale = 1;
    }
    
}
