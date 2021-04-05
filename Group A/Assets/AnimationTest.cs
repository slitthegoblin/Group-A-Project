using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTest : MonoBehaviour
{
    [SerializeField] Animator anim;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision other)
    {
        print(other.gameObject.tag);

        if (other.gameObject.tag == "NPC")
        {
            print("No collision");
        }
    }
}