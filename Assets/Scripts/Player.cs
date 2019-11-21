using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D body;
    public Animator animator;
    public float speed = 8.0f;

    void FixedUpdate()
    {
        Vector3 moveDirection = new Vector3(
            Input.GetAxis("Horizontal"), 
            Input.GetAxis("Vertical"),
            0.0f
        );
        Vector3 movement = moveDirection * speed * Time.fixedDeltaTime;
        
        body.AddForce(movement);

        animator.SetFloat("vertical_move", moveDirection.y);
        animator.SetFloat("horizontal_move", moveDirection.x);

        animator.SetBool("moving", moveDirection.magnitude > 0.0f);
    }
}
