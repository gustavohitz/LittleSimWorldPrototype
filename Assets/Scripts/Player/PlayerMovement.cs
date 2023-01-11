using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 3f;
    public Rigidbody2D rb2d;
    public Animator animator;
    public Color newColor;
    public SpriteRenderer _spriteRenderer;

    Vector2 movement;

    void Start() {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }


    void Update() {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        SetAnimationUp();
        ChangeColor();
    }

    void FixedUpdate() {
        MovingPlayer();
    }

    void MovingPlayer() {
        rb2d.MovePosition(rb2d.position + movement.normalized * speed * Time.fixedDeltaTime);
    }

    void SetAnimationUp() {
        if(Time.timeScale != 0) {
            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Speed", movement.sqrMagnitude);
        }    

        if(movement.x == 1 || movement.x == -1 || movement.y == 1 || movement.y == -1) {
            animator.SetFloat("LastHorizontal", movement.x);
            animator.SetFloat("LastVertical", movement.y);
        }
        
    }

    void ChangeColor() {
        if(Input.GetKeyDown(KeyCode.X)) {
            _spriteRenderer.color = Color.red;
        }
    }
    
}
