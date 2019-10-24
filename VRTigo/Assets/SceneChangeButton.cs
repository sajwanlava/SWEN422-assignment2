using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Button that changes the scene of the game using the scene's name (Scene must be added to game in build settings)
/// </summary>
public class SceneChangeButton : MonoBehaviour
{
    public Button button; //The button that changes scene when pressed
    public string levelName; //The name of the level that the game will change to

    /// <summary>
    /// Start is called before the first frame update, gets the button in the current game object and sets this script to run if the button is pressed.
    /// </summary>
    void Start()
    {
        //Gets button attachted to component
        button = GetComponent<Button>();
        //Adds listener to button, causing it to run ChangeLevel() when pressed
        button.onClick.AddListener(delegate { ChangeLevel(); });
    }

    /// <summary>
    /// Changes the level to a level with the same name as the one associated with this button.
    /// </summary>
    void ChangeLevel()
    {
        SceneManager.LoadScene(levelName);
    }
}
