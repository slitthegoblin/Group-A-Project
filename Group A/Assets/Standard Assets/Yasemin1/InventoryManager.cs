using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



namespace RpgAdventure
{
    public class InventoryManager : MonoBehaviour
    {

        //public Dictionary<string, GameObject> inventory = new Dictionary<string, GameObject>();
        public List<InventorySlot> inventory = new List<InventorySlot>();

        public GameObject playerCollecting;
        public GameObject spikedWeaponSpawn;
        public GameObject spikedWeaponPrefab;

        public bool spikedWeapon;


        public int inventorySize;
        public int inventoryManager;
        public Transform inventoryPanel;
        public int itemSpawner;
        InventorySlot inventorySlot;

        private void Awake()
        {
            inventorySize = inventoryPanel.childCount;
            CreateInventory(inventorySize);
        }


        void OnTriggerEnter(Collider other)
        {
            //playerCollecting = other.gameObject;
            if (playerCollecting.tag == "Player")
            {

                inventorySlot = playerCollecting.GetComponent < InventorySlot > ();
                inventorySlot.inventorySlot.
                Destroy(gameObject);
            }

        }

        private void CreateInventory(int size)
        {
            for (var i = 0; i < size; i++)
            {
                inventory.Add(new InventorySlot(i));
            }
        }

        public void OnItemPickup(GameObject spikedWeapon)
        {
            AddItem(spikedWeapon);
        }



                private void AddItem(GameObject spikedWeapon)
        {

            var inventorySlot = GetFreeSlot();
            if (inventorySlot == null)
            {
                Debug.Log("Inventory full");
                return;
            }
        }


        private InventorySlot GetFreeSlot()
        {
            return inventory.Find(slot => slot.spikedWeapon == null);
        }


    }
}
