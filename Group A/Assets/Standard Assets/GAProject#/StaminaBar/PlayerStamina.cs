using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStamina : MonoBehaviour
{
    //    public Rigidbody rb;
    public float staminaAmount = 100f;
    Animator animator;


    private void Start()
    {
        animator = GetComponent<Animator>();
        staminaAmount = 100f;
    }


    // Update is called once per frame
    void Update()
    {
        if (animator.GetBool("isRunning"))
        {
            //StaminaBar.instance.staminaBar.value = StaminaBar.instance.staminaBar.value;
            staminaAmount -= 0.2f;
            if (staminaAmount < 0) staminaAmount = 0;
        }
        else
        {
            staminaAmount += 0.1f;
            if (staminaAmount > 100) staminaAmount = 100;
        }
        StaminaBar.instance.staminaBar.value = staminaAmount;
    }

}
