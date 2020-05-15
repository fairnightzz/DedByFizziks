﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterController : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed;

    public Animator aniMan;
    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }
    void PlayerMovement()
    {
        if (Input.GetKeyDown("left shift"))
        {
            Speed *= 2;

        }
        if (Input.GetKeyUp("left shift"))
        {
            Speed /= 2;
        }
        float hor = Input.GetAxis("Vertical")*Speed;
        float ver = Input.GetAxis("Horizontal")*Speed;
        Vector3 playerMovement = new Vector3(ver, 0f, hor) * Time.deltaTime;
        this.transform.Translate(playerMovement, Space.Self);
        aniMan.SetFloat("Forward/Backward Speed", hor);
        aniMan.SetFloat("SideToSide Speed", ver);

    }
}
