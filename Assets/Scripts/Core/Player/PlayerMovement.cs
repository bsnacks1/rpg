using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
    walk,
    attack,
    interact
}
public class PlayerMovement : MonoBehaviour
{
    public PlayerState currentState;
    public float moveSpeed;
    public Rigidbody2D rb;
    public Animator anim;
    // private void moveSpeed = 2.0f;


    Vector2 movement;

    void Start()
    {
        currentState = PlayerState.walk;
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        // STUFF FOR PLAYER STATE PLEASE PAY ATTENTION
        // anim.SetFloat("Horizontal", 0);
        // anim.SetFloat("Vertical", -1);
    }

    // Update is called once per frame
    // Input
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.sqrMagnitude);
    }

    // Movement
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        SprintCheck();
    }

    void SprintCheck()
    {
        if (Input.GetKey(KeyCode.LeftShift) || (Input.GetKey(KeyCode.RightShift)))
        {
            moveSpeed = 3.0f;
        }
        else
            moveSpeed = 2.0f;
    }
}

