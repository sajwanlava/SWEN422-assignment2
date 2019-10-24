using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

/// <summary>
/// The object that manages the text for the scoreboard
/// </summary>
public class ScoreboardManager : MonoBehaviour
{
    //Text UI objects that this class is managing
    public Text levelOneTimeText;
    public Text levelTwoTimeText;
    public Text LastTimeText;
    //The values being applied to the board
    private string levelOneData;
    private string levelTwoData;
    private Score lastTimeData;

    /// <summary>
    /// Ran on first frame, reads score values and sets the board to equal those values
    /// </summary>
    void Start()
    {
        //Reader objects that read from the json files holding the scores
        StreamReader levelOne = new StreamReader("Level-1.json");
        StreamReader levelTwo = new StreamReader("Level-2.json");
        StreamReader lastTime = new StreamReader("lastTime.json");
        //Reads files for their data and closes them
        levelOneData = levelOne.ReadToEnd();
        levelTwoData = levelTwo.ReadToEnd();
        lastTimeData = JsonUtility.FromJson<Score>(lastTime.ReadToEnd());
        levelOne.Close();
        levelTwo.Close();
        lastTime.Close();
        //Applies values to the UI text objects
        LastTimeText.text = lastTimeData.time.ToString("F2");
    }


}
