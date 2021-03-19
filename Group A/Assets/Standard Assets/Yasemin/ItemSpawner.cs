using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace RpgAdventure
{
    public class ItemSpawner : MonoBehaviour
    {
        public GameObject itemPrefab;
        public LayerMask targetLayers;
        public UnityEvent<GameObject> onItemPickup;
        //public float width = 100f;
        //public float height = 100f;

        //void Start()
        //{
           // will wait 2 seconds then call the function Spawn() every 0.3 seconds
       //     InvokeRepeating("Spawn", 7.0f, 0.7f);
       // }


        void Awake()
        {
            Instantiate(itemPrefab, transform);
            Destroy(transform.GetChild(0).gameObject);

            onItemPickup.AddListener(FindObjectOfType<InventoryManager>().OnItemPickUp);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (0 != (targetLayers.value & 1 << other.gameObject.layer))
            {
                onItemPickup.Invoke(itemPrefab);
            }
        }

        //void Spawn()
        //{
        //    GameObject myItem = Instantiate(itemPrefab) as GameObject;
        //     myItem.transform.parent = transform;
        //    myItem.transform.position = new Vector2(Random.Range(0, width), height);
        // }

        //void OnTriggerEnter(Collider other)
        //{
        //Debug.Log("Triggering!");
        //  if (0 != (targetLayers.value & 1 << other.gameObject.layer))
        //{
        //FindObjectOfType<InventoryManager>().AddItem(itemPrefab);//trigger on item spawner find prefab
        //Debug.Log("Adding Item");
        //      onItemPickup.Invoke(itemPrefab);
        //      Destroy(gameObject);
        //  }
        //}
    }
}