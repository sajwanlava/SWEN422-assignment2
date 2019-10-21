using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{

    GameObject player;

    public int LevelEndTime = 3;
    public float timerCount = 0;
    public Text gameText;
    public bool findScore = true;
    public bool showBestTime = false;
    private float bestTime = 0;

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
            if (bestTime < timerCount) {
                bestTime = timerCount;
            }
            gameText.text = "Best Time: " + bestTime.ToString("F2") + "\n Last Time: " + timerCount.ToString("F2");
        }
        //teleport to the menu scene
        SceneManager.LoadScene("Menu");
        yield return null;
    }



}
