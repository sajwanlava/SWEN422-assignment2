using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeOnTouch : MonoBehaviour
{
    public Collider col;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        col = gameObject.GetComponent<Collider>();
    }

    void OnTriggerEnter(Collider col)
    {
        SceneManager.LoadScene(sceneName);
    }
}
