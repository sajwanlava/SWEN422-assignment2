using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChangeButton : MonoBehaviour
{
    public Button button;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(delegate { SceneChange(); });
    }

    // Update is called once per frame
    void SceneChange()
    {
        SceneManager.LoadScene(sceneName);
    }
}
