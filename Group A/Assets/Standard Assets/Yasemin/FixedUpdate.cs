using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RpgAdventure
{
    public class FixedUpdate : MonoBehaviour
    {
        public Transform toFollow;

        void FixedUpdateToFollow()
        {
            if (toFollow == null) { return; }
            transform.position = toFollow.position;
            transform.rotation = toFollow.rotation;
        }
    }
}
