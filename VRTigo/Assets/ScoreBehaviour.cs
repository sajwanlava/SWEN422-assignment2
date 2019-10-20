using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBehaviour : MonoBehaviour

{
    public Text text;
    public int score = 0;
    public static ScoreBehaviour instance;
    
    void Start()
    {
        instance = this;
        text = gameObject.GetComponent<Text>();
        text.text = "Score: " + score;
    }
    
    // Update is called once per frame
    void Update()
    {
        text.text = "Score: " + score;
    }
}
