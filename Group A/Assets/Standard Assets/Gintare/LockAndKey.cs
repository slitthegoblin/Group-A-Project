﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RpgAdventure
{
    public class LockAndKey : MonoBehaviour
    {
        //[SerializeField] public bool locked = false;
        //[SerializeField] GameObject requierment1;
        [SerializeField] public Host host;
        
        GameObject questItem;

        List<Item> inventory = new List<Item>();

        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                //check the global inventory and maek sure it contains hte object "vile 1, tag the viles as seperate things
                //if vile 1 is == true then need to set the questClass to true 
            }
        }
        public void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Vile") // if requierment1 is in the inventory
            {
                //           if(collision.gameObject.tag ("Vile") == questItem) // if requierment1 i sthe right item
                {
                    //               questClass.playerCanTalkToNpcNr1 = true; // set qest bool to true
                }
            }
        }
    }
}
