using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class PortalCamera : MonoBehaviour
{
    public GameObject player;
    public Transform portal;
    public Transform otherPortal;
    
    
    private Transform playerCamera;
    public Collider cameraCollider;

    void Start()
    {
        playerCamera = player.GetComponent<Camera>().transform;
        //cameraCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerOffsetFromPortal = playerCamera.position - otherPortal.position;
        transform.position = portal.position + playerOffsetFromPortal;

        float angularDiffPortalRotations = Quaternion.Angle(portal.rotation, otherPortal.rotation);
        Quaternion portalRotationDifference = Quaternion.AngleAxis(angularDiffPortalRotations, Vector3.up);
        Vector3 newCameraDirection = portalRotationDifference * playerCamera.forward;
        transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);
    }

    private void OnCollisionEnter(Collision other)
    {
        GameObject collisionObject = other.gameObject;
//        if (collisionObject.layer == 0)
//        {
//            Debug.Log(other.gameObject.name);
//            collisionObject.layer = LayerMask.NameToLayer("PortalHiddenEffect");
//        }
//        else
//        {
//            collisionObject.layer = 0;
//        }
    }
}
  