using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestTrigger : MonoBehaviour
{
    public Image image;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            image.transform.localScale = new Vector3(5, 5, 1.22f);
            Destroy(gameObject);
        }
    }
}
