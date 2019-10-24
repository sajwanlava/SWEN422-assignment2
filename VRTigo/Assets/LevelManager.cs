using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

/// <summary>
/// Class that represents an end level teleporter
/// </summary>
public class LevelManager : MonoBehaviour
{
    //GameObject representing the player
    GameObject player;

    public int LevelEndTime = 3; //The time the player must be on the end level teleporter before it activates
    public float timerCount = 0; //The time the player has been on the end level teleporter consistently
    public Text gameText; //Text that represents the timer in a level
    public bool findScore = true; //Tracks level completion time and score if true

    /// <summary>
    /// Initialisation code for LevelManager, gets the player object of the game
    /// </summary>
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    /// <summary>
    /// Method that runs every frame, updates the timer of the game
    /// </summary>
    private void Update()
    {
        if (findScore) {
            timerCount += Time.deltaTime;
            gameText.text = timerCount.ToString("F2");
        }
    }

    /// <summary>
    /// Method ran when an object enters this object's collider.
    /// If object is the player, start end level countdown
    /// </summary>
    /// <param name="collision">The collider that activated this trigger</param>
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player")) 
        {
            StartCoroutine("LevelEndCountdown");
        }
    }

    /// <summary>
    /// Method ran when object exits this object's collider.
    /// Stops the end level countdown.
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerExit(Collider collision)
    {
        StopCoroutine("LevelEndCountdown");
    }

    /// <summary>
    /// An IEnumerator that is used to end the level.
    /// </summary>
    /// <returns>An updated IEnumerator with its time reduced by one second (unless the countdown reaches 0)</returns>
    private IEnumerator LevelEndCountdown() 
    {
        int counter = LevelEndTime;
        while (counter > 0)
        {
            yield return new WaitForSeconds(1);
            counter--;
        }
        //End the level
        //calculate the score
        if (findScore) {
            string score_name = SceneManager.GetActiveScene().name+".json";
            StreamWriter writer = new StreamWriter(name, true);
            writer.WriteLine(JsonUtility.ToJson(new Score(timerCount)));
            writer.Close();

            writer = new StreamWriter("lastTime.json");
            writer.Write(JsonUtility.ToJson(new Score(timerCount)));
            writer.Close();
        }
        SceneManager.LoadScene("Menu");
        yield return null;
    }
}
