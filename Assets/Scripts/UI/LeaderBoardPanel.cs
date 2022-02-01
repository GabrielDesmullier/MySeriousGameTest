using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaderBoardPanel : MonoBehaviour
{
    private LeaderBoard leaderBoard;
    [SerializeField] private GameObject scorePrefab;
    [SerializeField] private Transform scoresContent;

    private void Awake()
    {
        leaderBoard = FindObjectOfType<LeaderBoard>();
    }

    private void Start()
    {
        DisplayScores();
    }

    public void DisplayScores()
    {
        foreach (Transform score in scoresContent)
        {
            GameObject.Destroy(score.gameObject);
        }
        List<Score> scoresList = leaderBoard.GetSortedList();
        foreach(Score score in scoresList)
        {
            GameObject newScore = Instantiate(scorePrefab, scoresContent);
            newScore.GetComponent<ScoreUI>().Initialise(score);
        }
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("SampleScene");
    }


}
