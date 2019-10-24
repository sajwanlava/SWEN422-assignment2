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
    public Text lastTimeText;
    //The values being applied to the board
    private Score levelOneData;
    private Score levelTwoData;
    private Score lastTimeData;

    /// <summary>
    /// Ran on first frame, reads score values and sets the board to equal those values
    /// </summary>
    void Start()
    {
        //Reader objects that read from the json files holding the scores
        StreamReader lastTime = new StreamReader("lastTime.json");
        //Reads files for their data and closes them
        levelOneData = findBestScore("Level-1.json");
        levelTwoData = findBestScore("Level-2.json");
        lastTimeData = JsonUtility.FromJson<Score>(lastTime.ReadToEnd());
        lastTime.Close();
        //Applies values to the UI text objects
        levelOneTimeText.text = formatTime(levelOneData);
        levelTwoTimeText.text = formatTime(levelTwoData);
        lastTimeText.text = formatTime(lastTimeData);
    }
    
    private Score findBestScore(string path)
    {
        StreamReader reader = new StreamReader(path);
        string line = reader.ReadLine();
        Score timeData = JsonUtility.FromJson<Score>(line);
        while (line != null) 
        {
            string nextLine = reader.ReadLine();
            if (nextLine == null) break;
            Score nextTimeData = JsonUtility.FromJson<Score>(nextLine);
            if (timeData.time > nextTimeData.time)
            {
                timeData = nextTimeData;
            }
            line = nextLine;
        }
        reader.Close();
        return timeData;
    }

    public string formatTime(Score score)
    {
        return score.time.ToString("F2");
    }


}
