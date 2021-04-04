using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikedWeaponPickup : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 100, transform.position.z);
        }
    }

}
