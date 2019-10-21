using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ScoreboardManager : MonoBehaviour
{
    public Text levelOneTimeText;
    public Text levelTwoTimeText;
    public Text LastTimeText;

    private string levelOneData;
    private string levelTwoData;
    private Score lastTimeData;

    void Start()
    {
        StreamReader levelOne = new StreamReader("Level-1.json");
        StreamReader levelTwo = new StreamReader("Level-2.json");
        StreamReader lastTime = new StreamReader("lastTime.json");

        levelOneData = levelOne.ReadToEnd();
        levelTwoData = levelTwo.ReadToEnd();
        lastTimeData = JsonUtility.FromJson<Score>(lastTime.ReadToEnd());

        levelOne.Close();
        levelTwo.Close();
        lastTime.Close();

        //process level1 and 2


        LastTimeText.text = lastTimeData.time.ToString("F2");
    }


}
