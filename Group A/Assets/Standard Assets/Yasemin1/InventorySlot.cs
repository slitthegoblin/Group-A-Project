using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace RpgAdventure
{
    public class InventorySlot : MonoBehaviour
    {

        public static List<InventorySlot> globalInv; //globalinv if u change on one it change on all

        public bool inventorySlot;
        public int index;

        public Item item;
        public int itemCount;

        //public string spikedWeapon;
        //private string spikedWeaponName;
        //public int spikedWeaponPrefab;


        public InventorySlot(int index)
        {
            this.index = index;
            if (globalInv == null)
            {
                globalInv = new List<InventorySlot>();
            }
            globalInv.Add(this);
        }


        public void Use()
        {
            // do stuff here to use item in game
            // i.e. decrement item counter etc
        }

        //public void Use(GameObject obj)
        //{
            //spikedWeaponName = spikedWeapon.name; //not sure
            //GameObject spikedWeaponPrefab = spikedWeapon;
        //}

    }

}