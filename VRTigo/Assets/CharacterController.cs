using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public bool sprint = false;

    [Header("Movement Fields")]
    public float rotateValue;
    public float sprintSpeed;
    public float walkSpeed;
    public bool hasTele = false;

    void Start()
    {
         
    }

    void Update()
    {
        
    }

    public void Move(Vector2 direction)
    {
        //if (sprint)
        //{
        //    transform.Translate(transform.InverseTransformDirection(Camera.main.transform.right) * direction.x * walkSpeed);
        //    transform.Translate(transform.InverseTransformDirection(Camera.main.transform.forward) * direction.y * walkSpeed);
        //}

        //if sprinting or flying, modifier will increase the speed in the next step
        //float modifier = (sprint ? sprintSpeed : walkSpeed);
        float modifier = walkSpeed;

        //move the cameraRig
        transform.Translate(transform.InverseTransformDirection(Camera.main.transform.right) * direction.x * Time.deltaTime * modifier, Space.Self);
        transform.Translate(transform.InverseTransformDirection(Camera.main.transform.forward) * direction.y * Time.deltaTime * modifier, Space.Self);
    }


    /// <summary>
    /// Rotates the camera rig around the Y axis
    /// </summary>
    /// <param name="direction">Multiplier to determine rotation direction. Positive value to turn right, negative value to turn left</param>
    public void Rotate(float direction)
    {
        transform.Rotate(new Vector3(0, direction * rotateValue, 0));
    }
}
