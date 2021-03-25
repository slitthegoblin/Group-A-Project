﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikedWeaponPickup : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

}
