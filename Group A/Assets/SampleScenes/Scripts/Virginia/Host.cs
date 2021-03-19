using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Host : MonoBehaviour
{

    private GameObject Active_NPC = null;
    public Text text;
    private bool PastLine1;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Active_NPC != null)
        {
            if (!PastLine1 && Input.GetKeyDown(KeyCode.E))
            {
                text.text = Active_NPC.GetComponent<Client>().DisplayLine;
                PastLine1 = true;
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                Active_NPC.GetComponent<Client>().NextLine();
            }
            text.text = Active_NPC.GetComponent<Client>().DisplayLine;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
            other.gameObject.GetComponent<Client>().IsTalk = true;
        }
    }
    private void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.CompareTag("NPC"))
        {
            text.text = ("Press E to talk to an NPC");
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (collider.gameObject.GetComponent<Client>())
                {
                    Active_NPC = collider.gameObject;
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.gameObject.CompareTag("NPC")) return;
        if (Active_NPC != null) Active_NPC.GetComponent<Client>().IsTalk = false;
        text.text = "";
        Active_NPC = null;
        PastLine1 = false;
    }
}