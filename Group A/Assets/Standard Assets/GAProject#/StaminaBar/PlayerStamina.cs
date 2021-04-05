using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RpgAdventure
{
    public class PlayerStamina : MonoBehaviour
    {
        //    public Rigidbody rb;
        public float staminaAmount = 100f;
        Animator animator;
        InventoryManager inventoryManager;

        private void Start()
        {
            animator = GetComponent<Animator>();
            staminaAmount = 100f;
            inventoryManager = GetComponent<InventoryManager>();
        }


        // Update is called once per frame
        void Update()
        {
            if (animator.GetBool("isRunning"))
            {
                //StaminaBar.instance.staminaBar.value = StaminaBar.instance.staminaBar.value;
                int totalWeight = inventoryManager.GetTotalweight();
                staminaAmount -= 0.2f * totalWeight;
                if (staminaAmount < 0) staminaAmount = 0;
                if (staminaAmount == 0) animator.SetBool("isRunning", false);
            }
            else
            {
                staminaAmount += 0.1f;
                if (staminaAmount > 100) staminaAmount = 100;
            }
            StaminaBar.instance.staminaBar.value = staminaAmount;
        }

    }
}

