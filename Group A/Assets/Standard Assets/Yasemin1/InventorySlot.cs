using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RpgAdventure
{

    public class InventorySlot : MonoBehaviour
    {


        public int index;
        public string spikedWeapon;
        private string spikedWeaponName;
        public int spikedWeaponPrefab;


        public InventorySlot(int index)
        {
            this.index = index;
        }

        public void Place(GameObject spikedWeapon)
        {
            spikedWeaponName = spikedWeapon.name; //not sure
            GameObject spikedWeaponPrefab = spikedWeapon;
        }

    }

}