using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalProjectile : MonoBehaviour
{

    //give it a toggle based on which controller it comes from    
    public bool isPrimary;

    private float maxTime = 10.0f;
    private float curTime = 0.0f;

    private GameObject portalReference;

    private void Update()
    {
        CheckAliveTime();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Detected");
        GameObject hit = collision.gameObject;
        if (hit.tag.Equals("Portalable"))
            CreatePortal(isPrimary, collision);
    }

    private void CreatePortal(bool portalSwitch, Collision collision)
    {
        Debug.Log("Acceptable Surface");


        if (portalReference == null)
            return;

        //enable the portal
        portalReference.SetActive(true);
        portalReference.transform.position = collision.GetContact(0).point;
        
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
