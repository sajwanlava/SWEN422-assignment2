using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChangeButton : MonoBehaviour
{
    public Button button;
    public string levelName;
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

    void ButtonTest()
    {
        SceneManager.LoadScene(levelName);
    }
}
