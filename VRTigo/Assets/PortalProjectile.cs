using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalProjectile : MonoBehaviour
{

    //give it a toggle based on which controller it comes from    
    public bool isPrimary;

    private float maxTime = 10.0f;
    private float curTime = 0.0f;

    private void Update()
    {
        CheckAliveTime();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Detected");
        GameObject hit = collision.gameObject;
        if (hit.tag.Equals("Portalable"))
            CreatePortal(isPrimary);
    }

    private void CreatePortal(bool portalSwitch)
    {
        Debug.Log("Acceptable Surface");

        //Create the portal in here
        //true = right controller, false = left controller

        Destroy(gameObject);
    }

    private void CheckAliveTime() 
    {
        curTime += Time.deltaTime;
        if (curTime >= maxTime)
            Destroy(gameObject);
    }
}
