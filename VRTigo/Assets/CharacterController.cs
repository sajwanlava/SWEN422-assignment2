using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class that handles movement for the player
/// </summary>
public class CharacterController : MonoBehaviour
{
    //Boolean that indicates if the player is sprinting
    public bool sprint = false;

    [Header("Movement Fields")]
    public float rotateValue;
    public float sprintSpeed;
    public float walkSpeed;
    public bool hasTele = false;

    /// <summary>
    /// Moves the player
    /// </summary>
    /// <param name="direction">The direction that the player is to be moved in</param>
    public void Move(Vector2 direction)
    {
        float modifier = walkSpeed;
        //Move the cameraRig
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
