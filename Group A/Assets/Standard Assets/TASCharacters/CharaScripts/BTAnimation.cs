using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTAnimation : MonoBehaviour
{

    Animator anim;
    Rigidbody Rb;

    // Update is called once per frame
    private void Start()
    {
        anim = GetComponent <Animator>();
        Rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        anim.SetFloat("vertical", Input.GetAxis("Vertical"));
        anim.SetFloat("horizontal", Input.GetAxis("Horizontal"));
    }
}
