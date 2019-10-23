using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Utility class to ensure that the gameObject this is attached to has a box collider attached to it.
/// A box collider is required for the menu to function.
/// </summary>
[RequireComponent(typeof(RectTransform))]
public class VRUI_Item : MonoBehaviour
{
    private BoxCollider boxCollider; //The box collider of the menu item that detects collision with shots
    private RectTransform rectTransform; //The transform of the menu item, used to create the box collider
    private Button button; //The button that is activated on being shot

    /// <summary>
    /// Called on first frame the object is active, assigns button to VR UI object
    /// </summary>
    private void Start()
    {
        button = GetComponent<Button>();
    }

    /// <summary>
    /// Called when this object is enabled, validates collider
    /// </summary>
    private void OnEnable()
    {
        ValidateCollider();
    }

    /// <summary>
    /// Called when this object is validated, validates collider
    /// </summary>
    private void OnValidate()
    {
        ValidateCollider();
    }

    /// <summary>
    /// Validates the collider, this makes sure the collider exists and sets it to the expected parameters
    /// </summary>
    private void ValidateCollider()
    {
        rectTransform = GetComponent<RectTransform>();

        //Gets collider, creates it if it doesn't exist
        boxCollider = GetComponent<BoxCollider>();
        if (boxCollider == null)
        {
            boxCollider = gameObject.AddComponent<BoxCollider>();
        }

        //Sets collider size to equal the size of the object's transform
        boxCollider.size = rectTransform.sizeDelta; 
        boxCollider.size = new Vector3(boxCollider.size.x, boxCollider.size.y, 1); //Sets z size to 1 as otherwise it would be 0
    }

    /// <summary>
    /// Called when object collides with this object's box collider. If the object has the tag "projectile", the button is activated
    /// </summary>
    /// <param name="collision">Collision of the object colliding with this object</param>
    private void OnCollisionEnter(Collision collision)
    {
        //If the object colliding is a projectile, activate button and destroy projectile
        if(collision.gameObject.tag == "projectile")
        {
            button.onClick.Invoke();
            Destroy(collision.gameObject);
        }
    }
}