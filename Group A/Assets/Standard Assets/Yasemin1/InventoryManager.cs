using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RpgAdventure
{
    public class InventoryManager : MonoBehaviour
    {

        //public Dictionary<string, GameObject> inventory = new Dictionary<string, GameObject>();
        public List<InventorySlot> inventory = new List<InventorySlot>();

        public int inventorySize;
        public Transform inventoryPanel;
        public int itemSpawner;
        public int spikedWeaponPrefab;

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

            var spikedWeaponToPickup = itemSpawner.spikedWeaponPrefab;  // this also not working?

            inventorySlot.Place(spikedWeaponToPickup);
            Debug.Log("Added " + spikedWeaponToPickup.name);
            Destroy(itemSpawner.spikedWeaponPrefab); //<- meant to be the game object which is the prefab either way dont work
        }


        private InventorySlot GetFreeSlot()
        {
            return inventory.Find(slot => slot.spikedWeapon == null);
        }


    }
}
