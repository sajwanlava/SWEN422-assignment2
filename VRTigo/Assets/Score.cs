/// <summary>
/// Class that holds the score and time of a level
/// </summary>
public class Score
{
    public float time;
    public float score;

    /// <summary>
    /// Creates a new score object with the input time
    /// </summary>
    /// <param name="time">The time of the current level that is to be applied to the score object</param>
    public Score(float time) {
        this.time = time;
    }
}
