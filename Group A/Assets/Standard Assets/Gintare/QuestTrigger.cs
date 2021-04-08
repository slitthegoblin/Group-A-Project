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
            if (other.gameObject.tag == "QuestT1")
            {
                image.transform.localScale = new Vector3(1, 1, 1);
                Destroy(gameObject);
            }
            else if (other.gameObject.tag == "QuestT2")
            {
                image.transform.localScale = new Vector3(1, 1, 1);
                Destroy(gameObject);
            }
            else if (other.gameObject.tag == "QuestT3")
            {
                image.transform.localScale = new Vector3(1, 1, 1);
                Destroy(gameObject);
            }
            else if (other.gameObject.tag == "QuestT4")
            {
                image.transform.localScale = new Vector3(1, 1, 1);
                Destroy(gameObject);
            }
            else if (other.gameObject.tag == "QuestT5")
            {
                image.transform.localScale = new Vector3(1, 1, 1);
                Destroy(gameObject);
            }
            else if (other.gameObject.tag == "QuestT6")
            {
                image.transform.localScale = new Vector3(1, 1, 1);
                Destroy(gameObject);
            }
            else if (other.gameObject.tag == "QuestT7")
            {
                image.transform.localScale = new Vector3(1, 1, 1);
                Destroy(gameObject);
            }
        }
        
    }
}
