﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {   bool isWalking = animator.GetBool("isWalking");
        bool isrunning = animator.GetBool("isRunning");
        bool forwardMovement = Input.GetKey("w");
        bool runMovement = Input.GetKey("left shift");


        if (!isWalking && forwardMovement)
        {
            animator.SetBool("isWalking", true);
        }

        if (isWalking && !forwardMovement)
        {
            animator.SetBool("isWalking", false);
        }

        if (!isrunning && (forwardMovement && runMovement))
        {
            animator.SetBool("isRunning", true);
        }

        if (isrunning && (!forwardMovement || !runMovement))

        {
            animator.SetBool("isRunning", false);
        }
    }
}
