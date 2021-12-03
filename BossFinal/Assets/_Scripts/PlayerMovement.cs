using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public CharacterController2D controller;
    float horizontalMove = 0f;
    public float Speed = 35f;
    bool jump = false;
    private float isFacing = 1;

    void Update()
    {
        // animator.SetBool("isGrounded", controller.m_Grounded);

        if (Math.Abs(Input.GetAxisRaw("Horizontal"))>= 0.5f)
        {
            isFacing = Input.GetAxisRaw("Horizontal");
        }
        
        if (!controller.m_Grounded)
        {
            horizontalMove = isFacing * Speed;
        }
        if (controller.m_Grounded)
        {
            horizontalMove = 0f;
        }
        if (Input.GetButtonDown("Jump"))
        {
            
            jump = true;
        }
        
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
