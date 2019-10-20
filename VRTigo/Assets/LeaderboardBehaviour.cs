using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderboardBehaviour : MonoBehaviour
{
    private List<Data> leaderboardScore;

    private List<Data> leaderboardTime;
    
    // Start is called before the first frame update
    void Start()
    {
        //read file
        //get json strings
        leaderboardScore = JsonUtility.FromJson<Data>( /* json by score */);
        leaderboardTime = JsonUtility.FromJson<Data>( /* json by time */);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //this method should be called when the game is finished
    void onGameFinish()
    {
        //update leaderboard data
        //add newest score, sort by score, remove lowest
        //add newest time, sort by time, remove lowest
        String jsonScore = JsonUtility.ToJson(leaderboardScore);
        String jsonTime = JsonUtility.ToJson(leaderboardTime);
        //write json strings to files
    }
}

public class Data
{
    public String name { get; set; }
    public int score { get; set;  }
    public Time time { get; set; }
}