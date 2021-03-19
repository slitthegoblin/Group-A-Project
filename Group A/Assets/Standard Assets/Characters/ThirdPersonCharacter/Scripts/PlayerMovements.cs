using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    float playerDistanceX;
    float playerDistanceY;

    Animator anim;
    CharacterController controller;
    Vector3 playV;
    bool groundedPlayer;
    float playSpeed = 3.5f;
    float jumpH = 2.5f;
    float gravityV = -10.2f;
    bool isrunning;
    bool facingleft;
    bool facingright;
    bool isMovingLeft;
    bool isMovingRight;



    private string turnInputAxis = "Horizontal";



    public float rotationRate = 360;







    // Start is called before the first frame update
    void Start()
    {

        controller = gameObject.GetComponent<CharacterController>();
        anim = gameObject.GetComponent<Animator>();
    }



    // Update is called once per frame
    void Update()
    {
        if (controller != null)
        {



            float turnAxis = Input.GetAxis(turnInputAxis);



            groundedPlayer = controller.isGrounded;
            print(groundedPlayer);



            if (groundedPlayer && playV.y <= 0)
            {
                playV.y = -0.5f;
            }



            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            controller.Move(move * Time.deltaTime * playSpeed);



            if (move != Vector3.zero)
            {
                gameObject.transform.forward = move;
            }



            if (Input.GetButtonDown("Jump") && groundedPlayer)
            {
                playV.y = Mathf.Sqrt(jumpH * -3.0f * gravityV);
            }



            if (Input.GetButtonDown("Jump") && groundedPlayer)
            {
                playV.y += Mathf.Sqrt(jumpH * -3.0f * gravityV);
            }



            playV.y += gravityV * Time.deltaTime;
            controller.Move(playV * Time.deltaTime);



            //ApplyInput(turnAxis);
        }

        if (isMovingLeft && facingright)
        {
            flip();
        }
        else if (isMovingRight && !facingleft)
        {
            flip();
        }



        Movement();
    }



    // private void ApplyInput(float turnInput)
    //{
    //  Turn(turnInput);
    //}



    //private void Turn(float input)
    //{
    //  transform.Rotate(0, input * rotationRate * Time.deltaTime, 0);
    //}



    void flip()
    {
        facingright = !facingright;
        facingleft = !facingleft;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
        transform.eulerAngles = new Vector3(0, 180, 0);

    }




    void Movement()
    {



        if (controller.isGrounded)
        {
            if (Input.GetKey(KeyCode.D))
            {
                isrunning = !isrunning;
            }

            anim.SetBool("run", isrunning);



            if (Input.GetKey(KeyCode.P))
            {
                anim.SetBool("jump", true);
            }
            else
            {
                anim.SetBool("jump", false);
            }



            if (Input.GetKey(KeyCode.A))
            {
                anim.SetBool("runtwo", true);
            }
            else
            {
                anim.SetBool("runtwo", false);
            }



            //if (Input.GetKeyDown(KeyCode.L))
            //{
            //    anim.SetBool("climbing", true);
            //}
            //else
            //{
            //    anim.SetBool("climbing", false);
            //}
        }
    }
}
