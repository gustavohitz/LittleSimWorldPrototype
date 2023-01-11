using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopOwnerBase : MonoBehaviour {

    private string _tagToCheck = "Player";
    private ActivateCanvas _activateCanvas;
    
    public bool canTalkToPlayer = false;
    public GameObject canvas;


    void Start() {
        _activateCanvas = GetComponent<ActivateCanvas>();
        canvas.SetActive(false);
    }
    void Update() {
        TalkToPlayer();
    }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag(_tagToCheck)) {
            canTalkToPlayer = true;
        }
    }
    void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag(_tagToCheck)) {
            canTalkToPlayer = false;
        }
    }

    void TalkToPlayer() {
        if(Input.GetKeyDown(KeyCode.Z) && canTalkToPlayer) {
            canvas.SetActive(true);
            PauseTime();
        }
    }
    void PauseTime() {
        Time.timeScale = 0;
    }
}
