using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Player_Movement : MonoBehaviour
{
    CharacterController controller;

    public float walkSpd = 5;

    public float spdAvancement = 10;

    public float gravity = 9.8f;
    private float velocity = 0;


    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        if (controller.isGrounded)
        {
            velocity = 0;
        }
        else
        {
            velocity -= gravity * Time.deltaTime;
            controller.Move(new Vector3(0, velocity, 0));
        }



        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        controller.Move(new Vector3(horizontal * walkSpd * Time.deltaTime, 0, (vertical * walkSpd * Time.deltaTime) + (spdAvancement * Time.deltaTime)));

        
    }


}
