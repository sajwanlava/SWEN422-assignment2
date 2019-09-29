using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPressTest : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(delegate { ButtonTest(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ButtonTest(){
        Debug.Log("Button Pressed");
    }
}
