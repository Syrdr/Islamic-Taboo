using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private float timer;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI greenScoreText;
    [SerializeField] private TextMeshProUGUI redScoreText;
    [SerializeField] private TextMeshProUGUI turnText;
    [SerializeField] private Button correctButton;
    [SerializeField] private Button skipButton;
    [SerializeField] private Button incorrectButton;
    [SerializeField] private GameObject startingCard;
    [SerializeField] private AudioSource correctClick;
    [SerializeField] private AudioSource incorrectClick;
    [SerializeField] private AudioSource skipClick;
    private bool firstCard = true;
    [SerializeField] private GameObject cardPrefab;
    private GameObject currentCard;
    private Transform location;
    private Vector3 mainSpot = new Vector3(0, 0, 0);
    [SerializeField] private Button endTimeButton;
    private int skips;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        skips = 3;
        timer = Timer.timeRemaining;
        correctButton.onClick.AddListener(OnCorrectButtonClick);
        incorrectButton.onClick.AddListener(OnIncorrectButtonClick);
        skipButton.onClick.AddListener(OnSkipButtonClick);
        location = startingCard.transform.parent;
        endTimeButton.onClick.AddListener(() =>
        {
            timer = 0;
        });
        switch(GameData.currentTeam)
        {
            case Teams.Green:
                turnText.text = "Green Turn";
                turnText.color = Color.green;
                break;
            case Teams.Red:
                turnText.text = "Red Turn";
                turnText.color = Color.red;
                break;
        }
    }

    private void OnIncorrectButtonClick()
    {
        incorrectClick.Play();
        DestroyAndReplace();
        ChangeCurrentTeamScore(-1);
    }

    private void OnSkipButtonClick()
    {
        if (skips > 0)
        {
            skipClick.Play();
            skips--;
            DestroyAndReplace();
        }
    }

    private void OnCorrectButtonClick()
    {
        correctClick.Play();
        DestroyAndReplace();
        ChangeCurrentTeamScore(1);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            if (GameData.NumberOfPlayers > 0)
            {
                SceneManager.LoadScene("IntermissionScene", LoadSceneMode.Single);
                /*switch (GameData.currentTeam)
                {
                    case Teams.Green:
                        GameData.currentTeam = Teams.Red;
                        break;
                    case Teams.Red:
                        GameData.currentTeam = Teams.Green;
                        break;
                }
                GameData.NumberOfPlayers--;
                GameData.dataModified = true;
                SceneManager.LoadScene("GameScene", LoadSceneMode.Single);*/
            } else
            {
                SceneManager.LoadScene("EndScene", LoadSceneMode.Single);
            }
        }
        timerText.text = "Time: " + Mathf.Round(timer).ToString();
        greenScoreText.text = "Green Score: " + GameData.greenScore.ToString();
        redScoreText.text = "Red Score: " + GameData.redScore.ToString();
    }

    private void DestroyAndReplace()
    {
        if (firstCard)
        {
            firstCard = false;
            //startingCard.SetActive(false);
            Destroy(startingCard);
            location.position = mainSpot;
            currentCard = Instantiate(cardPrefab, mainSpot, location.rotation, location);
            currentCard.transform.position += new Vector3(0, 48, 0);

        }
        else
        {
            Destroy(currentCard);
            location.position = mainSpot;
            currentCard = Instantiate(cardPrefab, mainSpot, location.rotation, location);
            currentCard.transform.position += new Vector3(0, 48, 0);
        }
    }


    private void ChangeCurrentTeamScore(int change)
    {
        if (GameData.currentTeam == Teams.Green)
        {
            GameData.greenScore += change;
        }
        else if(GameData.currentTeam == Teams.Red)
        {
            GameData.redScore += change;
        }
    }
}