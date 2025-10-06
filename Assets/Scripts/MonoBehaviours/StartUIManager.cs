using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartUIManager : MonoBehaviour
{
    [SerializeField] private Button StartButton;
    [SerializeField] private Button rulesButton;
    [SerializeField] private Button rulesPopupExitButton;
    [SerializeField] private TMP_InputField NumOfPlayers;
    [SerializeField] private AudioSource buttonClickSound;
    [SerializeField] private float timer;
    [SerializeField] private Canvas rulesPopup;
    private bool startTimer = false;
    //get an audiosource to play an mp3 sound on button click
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartButton.onClick.AddListener(() =>
        {
            buttonClickSound.Play();
            startTimer = true;
            StartButton.interactable = false;
        });
        rulesButton.onClick.AddListener(ShowRules);
    }


    private void ShowRules()
    {
        buttonClickSound.Play();
        rulesButton.interactable = false;
        rulesPopup.gameObject.SetActive(true);
        rulesPopupExitButton.onClick.AddListener(CloseRules);

    }

    void Update()
    {
        if(Convert.ToInt16(NumOfPlayers.text) > 10)
        {
            NumOfPlayers.text = "10";
        }
        else if (Convert.ToInt16(NumOfPlayers.text) < 2)
        {
            NumOfPlayers.text = "2";
        }
        if (startTimer)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                GameData.NumberOfPlayers = Convert.ToInt16(NumOfPlayers.text) * 2;
                SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
            }
        }
    }

    public void CloseRules()
    {
        rulesPopupExitButton.onClick.RemoveAllListeners();
        buttonClickSound.Play();
        rulesButton.interactable = true;
        rulesPopup.gameObject.SetActive(false);
    }
}
