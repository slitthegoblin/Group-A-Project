using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace RpgAdventure
{
    public class InventorySlot : MonoBehaviour
    {
        public RawImage itemImage;
        public static List<InventorySlot> globalInv; //globalinv if u change on one it change on all


        public bool inventorySlot;
        public int index;

        public Item item;
        public int itemCount;

        //public string spikedWeapon;
        //private string spikedWeaponName;
        //public int spikedWeaponPrefab;

        // Start is called before the first frame update
        void Start()
        {
            if (globalInv == null) //if global list of inventory slots doesnt exist yet 
            {
                globalInv = new List<InventorySlot>(); //then make the list
            }
            globalInv.Add(this);
            Hide();
        }

        public void Show()
        { 
            itemImage.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f); // make the item normal size - scale it to 60%
        }

        public void Hide()
        {
            itemImage.transform.localScale = new Vector3(0, 0, 0); //scale item to 0 to make invisible
        }


        public InventorySlot(int index) 
        {
            this.index = index;
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