﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour

{
    public Slider staminaBar;

    Animator animator;
    [SerializeField] Animator anim;
    private int maxStamina = 100;
    private int currentStamina;

    public static StaminaBar instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentStamina = maxStamina;
        staminaBar.maxValue = maxStamina;
        staminaBar.value = maxStamina;


    }

    public void UseStamina(int amount)
    {
        if (currentStamina - amount >= 0)
        {
            currentStamina -= amount;
            staminaBar.value = currentStamina;

            StartCoroutine(RegenStamina());
        }
        else
        {
//             Debug.Log("Not enough stamina"); // To be changed to be shown into screen
            anim.SetBool("isRunning", false);

        }

    }

    private IEnumerator RegenStamina()
    {
        yield return new WaitForSeconds(2);

        while (currentStamina < maxStamina)
        {
            currentStamina += maxStamina / 100;
            staminaBar.value = currentStamina;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
