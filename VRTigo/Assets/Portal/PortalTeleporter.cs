using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTeleporter : MonoBehaviour
{

    public Transform player;
    public Transform playerCamera;
    public Transform receiver;

    private bool playerIsOverlapping = false;
    private CharacterController characterController;


    private void Start()
    {
        characterController = player.gameObject.GetComponent<CharacterController>();
    }
    

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.layer != LayerMask.NameToLayer("Player"))
            return;


        Vector3 portalToPlayer = player.position - transform.position;
        float rotationDiff = -Quaternion.Angle(transform.rotation, receiver.rotation);
        rotationDiff += 180;
        Debug.Log(rotationDiff);
        player.Rotate(Vector3.up, rotationDiff);

        //Vector3 positionOffest = Quaternion.Euler(0f, rotationDiff, 0f) * portalToPlayer;


        player.position = receiver.position;// + (player.transform.forward * 4);


        characterController.hasTele = true;
        
        
    }


    private void OnCollisionExit(Collision other)
    {
        characterController.hasTele = false;
    }
}
