using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace RpgAdventure
{
    public class InventorySlot : MonoBehaviour
    {
        
        public Text itemLabel;
        public RawImage itemImage;
        public static List<InventorySlot> globalInv;
        public Button dropItemButton;
        public InventoryManager playerInventory;

        //global inv stores everything in the inventory slots - we have 4 inv slots so it stores all 4
        //if u make changes to the global inv it makes changes to all inv slots
        //global inv makes inventory slots accessible from all the other inv slots 
        //if u reference global inv in inv manager u can access all inv slots available (use unity to make changes)
        //static = this object is the same across all instances of inv slots

        public bool inventorySlot;
        public int index;

        public Item item;
        public int itemCount;
        //in inv managfer creatre another one saying if collides witrh potion find inv slot with potion whatever the item count is add 1

        //public string spikedWeapon;
        //private string spikedWeaponName;
        //public int spikedWeaponPrefab;

        // Start is called before the first frame update
        void Start()
        {
            if (globalInv == null) //if global list of inventory slots doesnt exist yet 
            {
                globalInv = new List<InventorySlot>(); //then make the list
            }
            globalInv.Add(this);
            Hide();
            dropItemButton.onClick.AddListener(DropItemEventHandler);
        }

        public void DropItemEventHandler()
        {
            //When drop item button is clicked, do this shit
            if(itemCount > 0)
            {
                DropItem();
            }
        }
        public void DropItem()
        {
            Decrement();
            if(itemCount == 0)
            {
                Hide();
                GameObject newItem = Instantiate(item.gameObject, new Vector3(playerInventory.transform.position.x, playerInventory.transform.position.y+3, playerInventory.transform.position.z), Quaternion.identity);
                newItem.name = ("Dropped" + newItem.name);
            }
        }



        public void Show()
        { 
            itemImage.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f); // make the item normal size - scale it to 60%
        }

        public void Hide()
        {
            itemImage.transform.localScale = new Vector3(0, 0, 0); //scale item to 0 to make invisible
        }


        public void Increment()
        {
            itemCount += 1;
            try //try catch because not all inventory slots have a label
            {
                itemLabel.text = itemCount.ToString();
            }
            catch
            {
                //do nothing if no label
            }
            
        }

        public void Decrement()
        {
            itemCount -= 1;
            try //try catch because not all inventory slots have a label
            {
                if (itemCount > 0){
                    itemLabel.text = itemCount.ToString();
                }
            }
            catch
            {
                //do nothing if no label
            }

        }

        public InventorySlot(int index) 
        {
            this.index = index;

        }


        public void Use()
        {

            Decrement();

            // do stuff here to use item in game
            // i.e. decrement item counter etc
        }

        //public void Use(GameObject obj)
        //{
            //spikedWeaponName = spikedWeapon.name; //not sure
            //GameObject spikedWeaponPrefab = spikedWeapon;
        //}

    }

}