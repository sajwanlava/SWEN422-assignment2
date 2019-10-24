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
    }

    // Update is called once per frame
    void Update()
    {
        float angularDiffPortalRotations = Quaternion.Angle(portal.rotation, otherPortal.rotation);
        Quaternion portalRotationDifference = Quaternion.AngleAxis(angularDiffPortalRotations, Vector3.up);
        Vector3 newCameraDirection = portalRotationDifference * playerCamera.forward;
        transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);
    }

}
  