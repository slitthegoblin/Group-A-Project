using UnityEngine;
using System.Collections;
public class PointAtoB : MonoBehaviour
{
    public Transform Destination;
    private Vector3 from;
    private Vector3 to;
    public float PointAtoBback = 10f;
    Animator anim;
    public GameObject NPC1;




    void Start()
    {
        from = transform.position;
        to = Destination.position;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        transform.position = Vector3.Lerp(from, to,
         Mathf.SmoothStep(0f, 1f,
          Mathf.PingPong(Time.time / PointAtoBback, 1f)
        ));

    }

    }
