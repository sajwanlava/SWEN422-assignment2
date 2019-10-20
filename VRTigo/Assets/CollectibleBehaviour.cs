using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using Valve.VR.InteractionSystem;

public class CollectibleBehaviour : MonoBehaviour
{
    public float rotateX = 0;
    public float rotateY = 0;
    public float rotateZ = 0;

    public int value = 300;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateX, rotateY, rotateZ);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.gameObject.SetActive(false);
            ScoreBehaviour.instance.score += value;
        }
    }
}
