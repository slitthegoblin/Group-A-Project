using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDestination : MonoBehaviour { 

    public int xPos;
    public int zPos;

    void OnTriggerEnter(Collider something)
{
        if (something.tag == "NPC")
        {
            xPos = Random.Range(150, 100);
            zPos = Random.Range(150, 100);
            this.gameObject.transform.position = new Vector3(xPos, 0.5f, zPos);
        }
}



}
