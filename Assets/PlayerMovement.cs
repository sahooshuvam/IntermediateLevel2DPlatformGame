using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    //private SpriteRenderer sp;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        //sp = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
      float inputX =  Input.GetAxis("Horizontal") * playerSpeed;
        rb.velocity = new Vector3(inputX, rb.velocity.y);
        animator.SetBool("Walk",inputX != 0);
        
    }
}
