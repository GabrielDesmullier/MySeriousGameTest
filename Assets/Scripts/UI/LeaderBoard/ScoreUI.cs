using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TMP_Text playerName;
    [SerializeField] private TMP_Text score;
    [SerializeField] private Image devPicto;

    public void Initialise(Score scoreEntry)
    {
        playerName.text = scoreEntry.name;
        score.text = scoreEntry.score.ToString();
        if (!scoreEntry.dev) devPicto.enabled = false;
    }
}
