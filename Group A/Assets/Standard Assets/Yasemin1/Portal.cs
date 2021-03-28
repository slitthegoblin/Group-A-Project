using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.position = new Vector3(other.transform.position.x +10, other.transform.position.y + 10, other.transform.position.z);
            //setting pos of character to new set of coordinates - in that new set of coord u are taking current position then adding 10 to Y so he falls from y axis in air
        }
    }
}
