using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    public class Host : MonoBehaviour
    {
        private GameObject Active_NPC = null;
        public Text text;
        private bool PastLine1;

        public bool playerCanTalkToNpcNr1 = false;
        public bool playerCanTalkToNpcNr2 = false;
        public bool playerCanTalkToNpcNr3 = false;
        public bool playerCanTalkToNpcNr4 = false;


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (playerCanTalkToNpcNr1 == true)
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
            else if(playerCanTalkToNpcNr2 == true)
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
        else if (playerCanTalkToNpcNr3 == true)
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
        else if (playerCanTalkToNpcNr4 == true)
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

            if(vile1 == true && vile2 == true && vile3 == true)
            {
            gameFinished.gameObject.SetActive(true);
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

        //Test

        private void OnTriggerExit(Collider other)
        {
            if (!other.gameObject.CompareTag("NPC")) return;
            if (Active_NPC != null) Active_NPC.GetComponent<Client>().IsTalk = false;
            text.text = "";
            Active_NPC = null;
            PastLine1 = false;
        }

        //GINTARE

        [SerializeField] public Host host;

        public bool vile1 = false;
        public bool vile2 = false;
        public bool vile3 = false;
    public GameObject gameFinished;

        GameObject questItem;

        // List<Item> inventory = new List<Item>();


        public void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "HerbalFlower") // if requierment1 is in the inventory
            {
                host.playerCanTalkToNpcNr1 = true; // set qest bool to true
                vile1 = true;
            }
            else if (collision.gameObject.tag == "FlourBag")
            {
                host.playerCanTalkToNpcNr4 = true;
                vile3 = true;
            }
            else if (collision.gameObject.tag == "Coins")
            {
                host.playerCanTalkToNpcNr3 = true;
            }
            else if (collision.gameObject.tag == "Drinks")
            {
                host.playerCanTalkToNpcNr2 = true;
                vile2 = true;
            }
        }
    }