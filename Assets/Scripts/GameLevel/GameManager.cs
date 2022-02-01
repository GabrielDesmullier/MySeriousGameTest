using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public bool hasKey;
    [SerializeField] private Movement player;
    [SerializeField] private GameObject endPanel;

    private void Awake()
    {
        hasKey = false;
    }

    public void EndGame()
    {
        player.DisableInput();
        endPanel.SetActive(true);
    }
}
