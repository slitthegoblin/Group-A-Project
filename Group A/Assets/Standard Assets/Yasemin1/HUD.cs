using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HUD : MonoBehaviour
{
    [SerializeField] bool canOpen;
    GameObject personCollecting;

    InventoryManager playerInventory;
    void OnCollisionEnter2D(Collision2D collision)
    {
        personOpening = collision.gameObject;
        if (personOpening.tag == "Player")
        {
            playerInventory = personOpening.GetComponent<PlayerInventory>();

            if (playerInventory.GetHasKey())
            {
                OpenDoor();
            }
        }
        //assign our player our game oject to a reference variable
    }
    //collision is happening, calling this method by putting name and it doesnt require any arguments,
    void OpenDoor()
    {
        print("player opened door");
        Destroy(gameObject); //destroys door but uncheck can open and wont be destroyed
    }
