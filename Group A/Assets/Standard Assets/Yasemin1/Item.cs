using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public enum itemType { None, SpikedWeapon, Axe, Knife, Vile, Coin};
    public itemType thisItem;
    public int weight;
    public int damage; //then can change in inspector so different for every one
}
