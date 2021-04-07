using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace RpgAdventure
{
    public class TheGameManagerScript : MonoBehaviour
    {

        public GameObject axeSpawn;
        public GameObject axePrefab;
        public GameObject knifeWeaponSpawn;
        public GameObject knifeWeaponPrefab;
        public GameObject spikedWeaponSpawn;
        public GameObject spikedWeaponPrefab;
        public GameObject vileSpawn;
        public GameObject vilePrefab;
        public UnityEvent<ItemSpawner> OnItemPickup;

        // Start is called before the first frame update
        void Start()
        {
            Instantiate(axePrefab, axeSpawn.transform.position, Quaternion.identity);
            Instantiate(knifeWeaponPrefab, knifeWeaponSpawn.transform.position, Quaternion.identity);
            Instantiate(spikedWeaponPrefab, spikedWeaponSpawn.transform.position, Quaternion.identity);
            Instantiate(vilePrefab, vileSpawn.transform.position, Quaternion.identity);
        }
    }
}



