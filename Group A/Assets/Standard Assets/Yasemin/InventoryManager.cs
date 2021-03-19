using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RpgAdventure
{
    public class InventoryManager : MonoBehaviour
    {

        //public Dictionary<string, GameObject> inventory = new Dictionary<string, GameObject>();
        //public int inventorySize;
        public List<InventorySlot> inventory = new List<InventorySlot>(); //contains inventory naem and prefab
        public Transform inventoryPanel; //UI part change manage rand UI part in seperate for future 

        public int m_inventorySize;
        public int InventoryPanel;

        private void Awake()
        {
            m_inventorySize = inventoryPanel.childCount;
            CreateInventory(m_inventorySize);
        }

        private void CreateInventory(int size)
        {
            for (int i = 0; i < size; i++)
            {
                inventory.Add(new InventorySlot(i)); //adding inventory slot to my inventory
            }

        }

        internal void OnItemPickUp(GameObject arg0)
        {
            throw new NotImplementedException();
        }

        public void OnItemPickup(ItemSpawner spawner)
        {
            AddItemFrom(spawner);
        }

        private void AddItemFrom(ItemSpawner spawner)
        {
            var item = spawner.itemPrefab;
            var inventorySlot = GetFreeSlot();
            if (inventorySlot == null)//inventory full cant add item
            {
                Debug.Log("Inventory is Full");
                return;


            }

            var itemToPickUp = spawner.itemPrefab; //item to pick up the anme

            inventorySlot.Place(spawner.itemPrefab); // call from item prefab

            inventoryPanel
                .GetChild(inventorySlot.index)
                .GetComponentInChildren<Text>().text = spawner.itemPrefab.name; //if text red - right click lightbulb do usingunityengineui
               // .GetComponentInChildren<Text>().text = spawner.itemPrefab.name;

            Debug.Log("Added " + spawner.itemPrefab.name);//call item prefab from name 
            Destroy(spawner.gameObject); //need to destroy spawner to stop them from adding to it
            //throw new NotImplementedException();
        }

        //public void AddItem(GameObject item)
       // {
       // }

        private InventorySlot GetFreeSlot()
        {
            return inventory.Find(slot => slot.itemName == null);
        }
     }

    //public class InventorySlot
    //{
        //private int i;

       // public InventorySlot(int i)
       // {
       //     this.i = i;
       // }
   // }
}
