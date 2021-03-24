﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeWeaponPickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            Destroy(gameObject);
        }
    }
}
