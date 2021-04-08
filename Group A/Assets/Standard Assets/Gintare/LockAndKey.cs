using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RpgAdventure
{
    public class LockAndKey : MonoBehaviour
    {
        [SerializeField] public Host host;
        
        GameObject questItem;

       // List<Item> inventory = new List<Item>();


        public void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Vile") // if requierment1 is in the inventory
            {
            
                    host.playerCanTalkToNpcNr1 = true; // set qest bool to true
             
            }

        }
    }
}
