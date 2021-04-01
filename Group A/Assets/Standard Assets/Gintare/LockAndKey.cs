using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockAndKey : MonoBehaviour
{
    //[SerializeField] public bool locked = false;
    //[SerializeField] GameObject requierment1;
    [SerializeField] Host questClass;
    GameObject questItem;
    
    List<Item> inventory = new List<Item>();

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Vile") // if requierment1 is in the inventory
        {
            if(collision.gameObject.tag ("Vile") == questItem) // if requierment1 i sthe right item
            {
                questClass.playerCanTalkToNpcNr1 = true; // set qest bool to true
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
