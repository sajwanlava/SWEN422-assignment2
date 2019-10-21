using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class LevelManager : MonoBehaviour
{

    GameObject player;

    public int LevelEndTime = 3;
    public float timerCount = 0;
    public Text gameText;
    public bool findScore = true;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }

    private void Update()
    {
        if (findScore) {
            timerCount += Time.deltaTime;
            gameText.text = timerCount.ToString("F2");
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player")) 
        {
            StartCoroutine("LevelEndCountdown");
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        StopCoroutine("LevelEndCountdown");
    }

    private IEnumerator LevelEndCountdown() 
    {
        Debug.Log("Starting the countdown");
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
            writer.Write(JsonUtility.ToJson(new Score(timerCount)));
            writer.Close();

            writer = new StreamWriter("lastTime.json");
            writer.Write(JsonUtility.ToJson(new Score(timerCount)));
            writer.Close();
        }
        //teleport to the menu scene
        SceneManager.LoadScene("Menu");
        yield return null;
    }



}
