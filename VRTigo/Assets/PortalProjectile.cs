using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class that represents a portal creating projectile in VRtigo
/// </summary>
public class PortalProjectile : MonoBehaviour
{

    //give it a toggle based on which controller it comes from  
    public bool isPrimary;

    //Time values used to destroy the object if it has been around for long enough
    private float maxTime = 10.0f; //Length of time to pass before projectile is destroyed
    private float curTime = 0.0f; //Length of time the projectile has been around for

    //The closest distance that two portals can be to each other
    private float minOverlapDistance = 5.5f;

    //The portal that the projectile will move to the current location upon colliding with a portalable surface
    private GameObject portalReference;

    /// <summary>
    /// Method that's called every frame, checks the length of time the projectile has existed for.
    /// </summary>
    private void Update()
    {
        CheckAliveTime();
    }

    /// <summary>
    /// Run when the projectile collides with a surface, creates portal if surface can hold portals.
    /// </summary>
    /// <param name="collision">Collision object for the object that it collided with.</param>
    private void OnCollisionEnter(Collision collision)
    {
        //Checks if object is a portalable surface, does nothing if it isn't
        GameObject hitObject = collision.gameObject;
        if (hitObject.tag.Equals("Portalable"))
        {
            //Raycasts towards object that was hit from the projectile, this is used to get the angle to turn the portal to
            RaycastHit hit;
            LayerMask mask = LayerMask.GetMask("Portalable");
            bool hitSuccess = Physics.Raycast(transform.position, (hitObject.transform.position -transform.position).normalized, out hit, Mathf.Infinity, mask); //bool holds if the raycast hit an object
            //Draw the raycast in debug
            Debug.DrawRay(transform.position, hit.normal, Color.red, Mathf.Infinity);
            //Create a portal at the hit position at an angle so the portal is running along the object
            CreatePortal(isPrimary, collision, hit, hitSuccess);
        }
    }

    /// <summary>
    /// Moves the portal in question to a location based on a collision and raycast
    /// </summary>
    /// <param name="portalSwitch">Used to check if the portal is primary</param>
    /// <param name="collision">The collision object that holds information of when the projectile collided with the portalable surface</param>
    /// <param name="hit">Raycast towards the hit surface, used for rotation</param>
    /// <param name="hitSuccess">True if the raycast hit an object</param>
    private void CreatePortal(bool portalSwitch, Collision collision, RaycastHit hit, bool hitSuccess)
    {
        //Does nothing if the portal being moved to this location doesn't exist
        if (portalReference == null)
            return;

        //Plays the sound of a portal being created (if sound is attached to object)
        GetComponent<AudioSource>().Play();

        //Checks distance from portals other than the one being moved, if any is too close than the portal is not moved and the projectile is destroyed
        GameObject[] portals = GameObject.FindGameObjectsWithTag("Portal"); //Gets all instances of portals
        foreach(GameObject portal in portals){
            //Checks if the portal is different from the portal to be created and if so, how close this projectile is to that portal. 
            if (portal != portalReference && Vector3.Distance(transform.position, portal.transform.position) < minOverlapDistance)
            {
                Destroy(gameObject);
                return;
            }
        }
        
        //If the raycast was successful, update position and rotation of the portal
        if (hitSuccess)
        {
            //Move portal to where the projectile collided with the surface
            portalReference.transform.position = collision.GetContact(0).point;

            //Rotate portal so it is facing away from the object hit by the raycast
            portalReference.transform.right = hit.normal;

            //Update x and z rotations so portal is vertical and oriented in portrait
            Vector3 norm = portalReference.transform.eulerAngles;
            norm.x = 0;
            norm.z = 90;
            portalReference.transform.eulerAngles = norm;
        }

        //Destroys the projectile
        Destroy(gameObject);
    }

    /// <summary>
    /// Checks the time the projectile has existed for, destroys it if it has existed for too long
    /// </summary>
    private void CheckAliveTime() 
    {
        curTime += Time.deltaTime; //Adds time between last frame and this frame to time the object has been around for
        if (curTime >= maxTime)
            Destroy(gameObject);
    }

    /// <summary>
    /// Sets the portal that this projectile holds.
    /// </summary>
    /// <param name="portal">The portal that will be created by this projectile.</param>
    public void SetPortalReference(GameObject portal) 
    {
        portalReference = portal;
    }
}
