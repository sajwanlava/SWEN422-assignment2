﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class VRController : MonoBehaviour
{
    private CharacterController playerController;

    public SteamVR_Action_Vector2 move;
    public SteamVR_Action_Boolean sprint;
    public SteamVR_Action_Boolean rotateLeft;
    public SteamVR_Action_Boolean rotateRight;
    public SteamVR_Action_Single fire;
    public SteamVR_Action_Boolean menu;
    public GameObject shotPrefab;
    public GameObject rightController;
    public float shotSpeed;
    public bool fired;
    public bool rapidFire;
    public float fireThreshold = 0.5f;

    private void Awake()
    {
        playerController = GameObject.Find("[CameraRig]").GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //rotate left
        if (rotateLeft.GetStateDown(SteamVR_Input_Sources.LeftHand))
        {
            playerController.Rotate(-1.0f);
        }

        //rotate right
        if (rotateRight.GetStateDown(SteamVR_Input_Sources.LeftHand))
        {
            playerController.Rotate(1.0f);
        }

        //movement
        if (move.GetAxis(SteamVR_Input_Sources.LeftHand) != Vector2.zero)
        {
            playerController.Move(move.GetAxis(SteamVR_Input_Sources.LeftHand));
        }

        //sprint
        if (sprint.GetState(SteamVR_Input_Sources.LeftHand))
        {
            playerController.sprint = true;
        }
        else
        {
            playerController.sprint = false;
        }

        if (fire.GetAxis(SteamVR_Input_Sources.RightHand) > fireThreshold)
        {
            if(!fired || rapidFire)
            {
                fired = true;
                GameObject shot = Instantiate(shotPrefab);
                shot.transform.position = rightController.transform.position;
                shot.GetComponent<Rigidbody>().AddForce(rightController.transform.forward * shotSpeed, ForceMode.Impulse);
            }
            Debug.Log(fire.GetAxis(SteamVR_Input_Sources.RightHand));
        }
        else{
            fired = false;
        }

        if (menu.GetStateDown(SteamVR_Input_Sources.LeftHand))
        {
            Debug.Log("Menu hook");
        }
    }
}
