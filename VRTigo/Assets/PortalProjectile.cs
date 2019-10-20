using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalProjectile : MonoBehaviour
{

    //give it a toggle based on which controller it comes from    
    public bool isPrimary;

    private float maxTime = 10.0f;
    private float curTime = 0.0f;
    private float minOverlapDistance = 5.5f;

    private GameObject portalReference;

    private void Update()
    {
        CheckAliveTime();
    }

    private void OnCollisionEnter(Collision collision)
    {

        GameObject hitObject = collision.gameObject;
        if (hitObject.tag.Equals("Portalable"))
        {
            RaycastHit hit;
            LayerMask mask = LayerMask.GetMask("Portalable");
            bool hitSuccess = Physics.Raycast(transform.position, hitObject.transform.position, out hit, Mathf.Infinity, mask);
            CreatePortal(isPrimary, collision, hit, hitSuccess);
        }
    }

    //Bug: Angle change fails when object is on a right angle
    private void CreatePortal(bool portalSwitch, Collision collision, RaycastHit hit, bool hitSuccess)
    {
        Debug.Log(hit.collider);
        if (portalReference == null)
            return;

        GameObject[] portals = GameObject.FindGameObjectsWithTag("Portal");
        foreach(GameObject portal in portals){
            if (portal != portalReference && Vector3.Distance(transform.position, portal.transform.position) < minOverlapDistance)
            {
                Destroy(gameObject);
                return;
            }
        }

        //enable the portal
        portalReference.SetActive(true);
        //set position
        portalReference.transform.position = collision.GetContact(0).point;

        //set rotation
        if (hitSuccess)
        {
            Debug.Log(hit.collider);
            portalReference.transform.rotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
            Vector3 norm = portalReference.transform.eulerAngles;
            Debug.Log(norm);
            norm.x = 0;
            norm.y = -norm.y;
            norm.z = 90;
            portalReference.transform.eulerAngles = norm;
        }

        Destroy(gameObject);
    }

    private void CheckAliveTime() 
    {
        curTime += Time.deltaTime;
        if (curTime >= maxTime)
            Destroy(gameObject);
    }

    public void SetPortalReference(GameObject portal) 
    {
        this.portalReference = portal;
    }
}
