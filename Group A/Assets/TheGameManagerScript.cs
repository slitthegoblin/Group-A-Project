using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheGameManagerScript : MonoBehaviour
{

    public GameObject axeSpawn;
    public GameObject axePrefab;
    public GameObject knifeWeaponSpawn;
    public GameObject knifeWeaponPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(axePrefab, axeSpawn.transform.position, Quaternion.identity);
        Instantiate(knifeWeaponPrefab, knifeWeaponSpawn.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
