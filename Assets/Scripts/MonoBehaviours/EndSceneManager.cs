using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndSceneManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI greenWins;
    [SerializeField] private TextMeshProUGUI redWins;
    [SerializeField] private TextMeshProUGUI draw;
    [SerializeField] private Button restartButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        restartButton.onClick.AddListener(RestartGame);
        if(GameData.greenScore > GameData.redScore)
        {
            greenWins.gameObject.SetActive(true);
            redWins.gameObject.SetActive(false);
            draw.gameObject.SetActive(false);
        }
        else if (GameData.redScore > GameData.greenScore)
        {
            redWins.gameObject.SetActive(true);
            greenWins.gameObject.SetActive(false);
            draw.gameObject.SetActive(false);
        }
        else
        {
            draw.gameObject.SetActive(true);
            greenWins.gameObject.SetActive(false);
            redWins.gameObject.SetActive(false);
        }
    }

    private void RestartGame()
    {
        GameData.NumberOfPlayers = 6;
        GameData.greenScore = 0;
        GameData.redScore = 0;
        GameData.currentTeam = Teams.Green;
        GameData.dataModified = false;
        SceneManager.LoadScene("StartScene", LoadSceneMode.Single);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}