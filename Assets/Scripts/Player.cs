using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D body;
    public SpriteRenderer sprite;
    public Animator animator;
    public float speed = 8.0f;

    Vector3 moveDirection = Vector3.zero;
    bool isDead = false;
    string lastAnimation = "";


    void Update()
    {
        UpdateAnimator();
    }

    void FixedUpdate()
    {
        moveDirection = new Vector2(
            Input.GetAxisRaw("Horizontal"), 
            Input.GetAxisRaw("Vertical")
        );
        
        body.velocity = moveDirection * speed * Time.fixedDeltaTime;
    }

    void UpdateAnimator()
    {
        if (isDead) {
            sprite.flipX = false;
            SetAnimation("Player_die");
        }
        if (moveDirection.y < 0.0f) {
            sprite.flipX = false;
            SetAnimation("Player_walk_down");
        }
        else if (moveDirection.y > 0.0f) {
            sprite.flipX = false;
            SetAnimation("Player_walk_up");
        }
        else if (moveDirection.x > 0.0f) {
            sprite.flipX = false;
            SetAnimation("Player_walk_right");
        }
        else if (moveDirection.x < 0.0f) {
            sprite.flipX = true;
            SetAnimation("Player_walk_right");
        }

        else if (lastAnimation == "Player_walk_up") {
            sprite.flipX = false;
            SetAnimation("Player_idle_up");
        }
        else if (lastAnimation == "Player_walk_down") {
            sprite.flipX = false;
            SetAnimation("Player_idle_down");
        }
        else if (lastAnimation == "Player_walk_right") {
            SetAnimation("Player_idle_right");
        }
    }

    void SetAnimation(string stateName)
    {
        animator.Play(stateName);
        lastAnimation = stateName;
    }
}
