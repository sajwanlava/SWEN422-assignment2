using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Test class that checked if shooting at buttons worked as intended
/// </summary>
public class ButtonPressTest : MonoBehaviour
{
    public Button button; //The button that triggers this script

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        //Gets button and adds listener so ButtonTest() is called when button is interacted with
        button = GetComponent<Button>();
        button.onClick.AddListener(delegate { ButtonTest(); });
    }

    /// <summary>
    /// Prints to debug that the button has been pressed
    /// </summary>
    void ButtonTest(){
        Debug.Log("Button Pressed");
    }
}
