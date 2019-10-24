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
    
    /// <summary>
    /// If portal collides with player teleport player to receiver facing away from the receiver's portal
    /// </summary>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer != LayerMask.NameToLayer("Player"))
            return;
        Vector3 portalToPlayer = player.position - transform.position;
        float rotationDiff = -Quaternion.Angle(transform.rotation, receiver.rotation);
        rotationDiff += 180;
        player.Rotate(Vector3.up, rotationDiff);
        player.position = receiver.position;// + (player.transform.forward * 4);
        characterController.hasTele = true;
    }


    private void OnCollisionExit(Collision other)
    {
        characterController.hasTele = false;
    }
}
