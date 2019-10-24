using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

/// <summary>
/// Class that represents a VR controller
/// </summary>
public class VRController : MonoBehaviour
{
    //The overall player controller
    private CharacterController playerController;

    //SteamVR Actions
    public SteamVR_Action_Vector2 move;
    public SteamVR_Action_Boolean sprint;
    public SteamVR_Action_Boolean rotateLeft;
    public SteamVR_Action_Boolean rotateRight;
    public SteamVR_Action_Single fire;
    public SteamVR_Action_Boolean menu;

    //The projectile shot by the VR controllers
    public GameObject shotPrefab;
    //The left and right controllers
    public GameObject rightController;
    public GameObject leftController;
    //The speed of shots fired by the controller
    public float shotSpeed;
    //Booleans that hold if the left and right controllers have fired, used to make each controller fire once per trigger pull
    public bool leftFired;
    public bool rightFired;
    //Removes single shot per trigger pull restriction, enabling rapid fire. Used for testing and for fun
    public bool rapidFire;
    //The threshold that the trigger must exceed before firing
    public float fireThreshold = 0.5f;

    //The portals that the left and right controllers create
    public GameObject portalLeft;
    public GameObject portalRight;

    //The materials for projectiles fired by the left and right controllers
    public Material projLeftMaterial;
    public Material projRightMaterial;

    //The colour of the left and right projectiles
    public Color projLeftColour;
    public Color projRightColour;

    //Portals cannot be created when switched off, used in hub
    public bool allowPortalCreation = true;

    //Projectile fired sound effect
    private AudioSource sound;

    /// <summary>
    /// Called to initialise variables upon starting the program
    /// </summary>
    private void Awake()
    {
        playerController = GameObject.Find("[CameraRig]").GetComponent<CharacterController>();
        sound = GetComponent<AudioSource>();
    }

    /// <summary>
    /// Update method that is called every frame. Handles movement and portal shots.
    /// </summary>
    void Update()
    {
        //Performs left rotation if left rotation button is pressed
        if (rotateLeft.GetStateDown(SteamVR_Input_Sources.LeftHand))
        {
            playerController.Rotate(-1.0f);
        }

        //Performs left rotation if right rotation button is pressed
        if (rotateRight.GetStateDown(SteamVR_Input_Sources.LeftHand))
        {
            playerController.Rotate(1.0f);
        }

        //Performs Movement based on trackpad touch
        if (move.GetAxis(SteamVR_Input_Sources.LeftHand) != Vector2.zero)
        {
            playerController.Move(move.GetAxis(SteamVR_Input_Sources.LeftHand));
        }

        //Sprint
        if (sprint.GetState(SteamVR_Input_Sources.LeftHand))
        {
            playerController.sprint = true;
        }
        else
        {
            playerController.sprint = false;
        }

        //Fire right portal
        //Check if trigger value is greater than threshold
        if (fire.GetAxis(SteamVR_Input_Sources.RightHand) > fireThreshold)
        {
            //If right controller hasn't fired since trigger value has exceeded threshold (or if rapid fire is enabled)
            if(!rightFired || rapidFire)
            {
                sound.Play();
                rightFired = true; //Mark that right controller has fired
                GameObject shot = Instantiate(shotPrefab); //Create shot
                //Set the material and colours of the projectile
                shot.GetComponent<MeshRenderer>().material = projRightMaterial;
                shot.GetComponentInChildren<Light>().color = projRightColour;
                //Set the projectile as primary
                shot.GetComponent<PortalProjectile>().isPrimary = true;
                //Set the portal reference of the projectile
                shot.GetComponent<PortalProjectile>().SetPortalReference(portalRight);
                //Set transform of the projectile to equal the controller
                shot.transform.position = rightController.transform.position;
                //Propel the projectile forwards
                shot.GetComponent<Rigidbody>().AddForce(rightController.transform.forward * shotSpeed, ForceMode.Impulse);
            }
        }
        else
        {
            //If trigger is below threshold, set right controller to have not fired so it is fired when trigger is pulled again
            rightFired = false;
        }

        //Fire left portal
        //Check if trigger value is greater than threshold
        if (fire.GetAxis(SteamVR_Input_Sources.LeftHand) > fireThreshold)
        {
            //If left controller hasn't fired since trigger value has exceeded threshold (or if rapid fire is enabled)
            if (!leftFired || rapidFire)
            {
                sound.Play();
                leftFired = true; //Mark that left controller has fired
                GameObject shot = Instantiate(shotPrefab); //Create shot
                //Set the material and colours of the projectile
                shot.GetComponent<MeshRenderer>().material = projLeftMaterial;
                shot.GetComponentInChildren<Light>().color = projLeftColour;
                //Set the projectile as not primary
                shot.GetComponent<PortalProjectile>().isPrimary = false;
                //Set the portal reference of the projectile
                shot.GetComponent<PortalProjectile>().SetPortalReference(portalLeft);
                //Set transform of the projectile to equal the controller
                shot.transform.position = leftController.transform.position;
                //Propel the projectile forwards
                shot.GetComponent<Rigidbody>().AddForce(leftController.transform.forward * shotSpeed, ForceMode.Impulse);
            }
        }
        else
        {
            //If trigger is below threshold, set left controller to have not fired so it is fired when trigger is pulled again
            leftFired = false;
        }

        //Debug log to check menu button is pressed
        if (menu.GetStateDown(SteamVR_Input_Sources.LeftHand))
        {
            Debug.Log("Menu hook");
        }
    }
}
