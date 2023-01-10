using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopOwnerBase : MonoBehaviour {

    private string _tagToFind = "Player";
    private ActivateShopCanvas _activateShopCanvas;
    
    public bool canTalkToPlayer = false;


    void Start() {
        _activateShopCanvas = GetComponent<ActivateShopCanvas>();
    }
    void Update() {
        TalkToPlayer();
    }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag(_tagToFind)) {
            canTalkToPlayer = true;
        }
    }

    void TalkToPlayer() {
        if(Input.GetKeyDown(KeyCode.Z) && canTalkToPlayer) {
            _activateShopCanvas.ShowShopCanvas();
            _activateShopCanvas.PauseTime();
        }
    }
    
}
