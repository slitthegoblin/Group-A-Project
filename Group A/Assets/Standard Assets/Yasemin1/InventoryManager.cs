using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



namespace RpgAdventure
{
    public class InventoryManager : MonoBehaviour
    {

        //public Dictionary<string, GameObject> inventory = new Dictionary<string, GameObject>();
        [SerializeField] List<InventorySlot> invenSlots = new List<InventorySlot>(); //array of images called inventory slot
        [SerializeField] List<Item> inventory = new List<Item>();

        //public GameObject playerCollecting;
        //public GameObject spikedWeaponSpawn;
        //public GameObject spikedWeaponPrefab;
        //public GameObject AxeSpawn;
        //public GameObject AxePrefab;
        //public GameObject KnifeWeaponSpawn;
        //public GameObject KnifeWeaponPrefab;

        public bool spikedWeapon;
        //private bool Destroy;


        public int inventorySize;
        public int inventoryManager;
        public Transform inventoryPanel;
        public int itemSpawner;
        InventorySlot inventorySlot;

        public void Update()
        {
            if (Input.GetKey(KeyCode.P))
            {
                InventorySlot.globalInv.ForEach(invSlot => {
                    if (invSlot.item.thisItem == Item.itemType.Vile)
                    {
                        invSlot.Decrement();
                    }
                });
            };

            if (Input.GetKey(KeyCode.O))
            {
                InventorySlot.globalInv.ForEach(invSlot => {
                    if (invSlot.item.thisItem == Item.itemType.Coin)
                    {
                        invSlot.Increment();
                    }
                });
            };

        }

        public int GetTotalweight()
        {
            int totalweight = 0;
            InventorySlot.globalInv.ForEach(invSlot => { 
                if(invSlot.itemCount > 0)
                {
                    totalweight += invSlot.item.weight;
                }
            });
            return totalweight;
        }

        private void OnTriggerEnter(Collider collision)
        {

            print(collision.gameObject.name);
            if (collision.gameObject.name == "test")
                print("tester is working");

            //switch faster than lots of if 
            print("Run in to " + collision.gameObject.name);
            switch (collision.gameObject.name)  //switch - check the name of the object hte character is colliding with
            {
            case "SpikedWeapon": //each of the lines that start with case, checks the name and runs the code below
                //print("run into spiked weapon"); //print to check if working in console
                InventorySlot.globalInv.ForEach(invSlot => {  //loop through all inv slots and find the one that corresponds to the item the player has collided with
                    if (invSlot.item.thisItem == Item.itemType.SpikedWeapon)
                    {
                        invSlot.Show(); //show the item in the inventory
                        invSlot.Increment();
                    }
                });
                break;
            case "Axe":
                //print("run into axe");
                InventorySlot.globalInv.ForEach(invSlot => {
                    if (invSlot.item.thisItem == Item.itemType.Axe)
                    {
                        invSlot.Show();
                        invSlot.Increment();
                    }
                });
                break;
            case "KnifeWeapon":
                //print("run into knife");
                InventorySlot.globalInv.ForEach(invSlot => {
                    if (invSlot.item.thisItem == Item.itemType.Knife)
                    {
                        invSlot.Show();
                        invSlot.Increment();
                    }
                });
               break;
            case "Vile1":
                //print("collect vile1");
                    InventorySlot.globalInv.ForEach(invSlot => {
                    if (invSlot.item.thisItem == Item.itemType.Vile)
                    {
                        invSlot.Show();
                        invSlot.Increment();
                    }
                });
                break;
            case "Coin":
                //print("collect coin");
                InventorySlot.globalInv.ForEach(invSlot => {
                    if (invSlot.item.thisItem == Item.itemType.Coin)
                    {
                    for(int i = 0; i <50; i++)
                        {
                            invSlot.Increment();
                        }
                    }
                });
                    break;
            }


            //if (collision.gameObject.name == "SpikedWeapon(Clone)")
            //{   //two equals to compare and one = is to set
            //    Item toAddtoInventory = new Item();
            //    toAddtoInventory.thisItem = Item.itemType.SpikedWeapon; //thing on end is field within that class
            //    inventory.Add(toAddtoInventory);


                
            //}


           //var placeHolder = collision.gameObject.GetComponent<Item>();
            //if list for item objects and have list for hotbar images - if itemobject index is 0 then image list it image = spiked weapoan.active.true)
            //print(placeHolder.thisItem);
        }
        



        //private void CreateInventory(int size)
        //{
        //    for (var i = 0; i < size; i++)
        //    {
        //        inventory.Add(new InventorySlot(i));
        //    }
        //}

        //public void OnItemPickup(GameObject spikedWeapon)
        //{
        //    AddItem(spikedWeapon);
        //}

    }
}
