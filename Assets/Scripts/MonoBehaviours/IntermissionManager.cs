using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntermissionManager : MonoBehaviour
{
    [SerializeField] private Button continueButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (GameData.currentTeam)
        {
            case Teams.Green:
                GameData.currentTeam = Teams.Red;
                //continueButton.gameObject.GetComponent<Image>().color = Color.red;
                break;
            case Teams.Red:
                GameData.currentTeam = Teams.Green;
                //continueButton.gameObject.GetComponent<Image>().color = Color.green;
                break;
        }
        GameData.NumberOfPlayers--;
        GameData.dataModified = true;
        continueButton.onClick.AddListener(() => SceneManager.LoadScene("GameScene", LoadSceneMode.Single));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
