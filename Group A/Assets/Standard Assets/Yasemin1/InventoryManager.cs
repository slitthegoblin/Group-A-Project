using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



namespace RpgAdventure
{
    public class InventoryManager : MonoBehaviour
    {

        //public Dictionary<string, GameObject> inventory = new Dictionary<string, GameObject>();
        [SerializeField] List<Image> invenSlots = new List<Image>(); //array of images called inventory slot
        [SerializeField] List<Item> inventory = new List<Item>();

        public GameObject playerCollecting;
        public GameObject spikedWeaponSpawn;
        public GameObject spikedWeaponPrefab;

        public bool spikedWeapon;
       // private bool Destroy;


        public int inventorySize;
        public int inventoryManager;
        public Transform inventoryPanel;
        public int itemSpawner;
        InventorySlot inventorySlot;


        private void OnTriggerEnter(Collider collision)
        {
            print(collision.gameObject.name);
            if (collision.gameObject.name == "test")
                print("tester is working");


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
