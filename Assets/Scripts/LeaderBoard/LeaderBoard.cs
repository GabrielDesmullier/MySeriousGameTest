using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LeaderBoard : MonoBehaviour
{
    private TextAsset scoresData;
    private List<Score> scoresList;

    private void Awake()
    {
        scoresData = Resources.Load<TextAsset>("it-dev-unity-test-a-1");
    }

    public List<Score> GetSortedList()
    {
        GetScores();
        SortScores();
        return scoresList;
    }

    private void GetScores(){
        Scores scores = JsonUtility.FromJson<Scores>(scoresData.text);
        scoresList = new List<Score>(scores.scores);
    }

    private void SortScores()
    {
        scoresList = scoresList.OrderByDescending(x => x.score).ToList();
    }
}
