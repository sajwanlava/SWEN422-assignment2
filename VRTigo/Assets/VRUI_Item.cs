using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Utility class to ensure that the gameObject this is attached to has a box collider attached to it.
/// A box collider is required for the menu to function with the laser pointer.
/// </summary>
[RequireComponent(typeof(RectTransform))]
public class VRUI_Item : MonoBehaviour
{
    private BoxCollider boxCollider;
    private RectTransform rectTransform;
    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        ValidateCollider();
    }

    private void OnValidate()
    {
        ValidateCollider();
    }

    private void ValidateCollider()
    {
        rectTransform = GetComponent<RectTransform>();

        boxCollider = GetComponent<BoxCollider>();
        if (boxCollider == null)
        {
            boxCollider = gameObject.AddComponent<BoxCollider>();
        }

        boxCollider.size = rectTransform.sizeDelta;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "projectile")
        {
            button.onClick.Invoke();
            Destroy(collision.gameObject);
        }
    }
}