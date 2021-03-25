using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace RpgAdventure
{
    public class InventoryManager : MonoBehaviour
    {

        //public Dictionary<string, GameObject> inventory = new Dictionary<string, GameObject>();
        public List<InventorySlot> inventory = new List<InventorySlot>();


    
        public GameObject spikedWeaponSpawn;
        public GameObject spikedWeaponPrefab;
        public int inventorySize;
        public Transform inventoryPanel;
        public int itemSpawner;

        private void Awake()
        {
            inventorySize = inventoryPanel.childCount;
            CreateInventory(inventorySize);
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
