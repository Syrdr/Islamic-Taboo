using TMPro;
using UnityEngine;

public class CardInfoGenerator : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI mainBox;
    [SerializeField] private TextMeshProUGUI box1;
    [SerializeField] private TextMeshProUGUI box2;
    [SerializeField] private TextMeshProUGUI box3;
    [SerializeField] private TextMeshProUGUI box4;
    [SerializeField] private TextMeshProUGUI box5;
    [SerializeField] private GameObject questions;
    private QuestionMaker questionMaker;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        questions = GameObject.Find("QuestionMaker");
        questionMaker = questions.GetComponent<QuestionMaker>();
        int ind = UnityEngine.Random.Range(1, questionMaker.allPrompts.Length - 2);
        WordPrompts wordPrompt = questionMaker.allPrompts[ind];
        mainBox.text = wordPrompt.targetWord;
        box1.text = wordPrompt.bannedWords[0];
        box2.text = wordPrompt.bannedWords[1];
        box3.text = wordPrompt.bannedWords[2];
        box4.text = wordPrompt.bannedWords[3];
        box5.text = wordPrompt.bannedWords[4];
    }

    // Update is called once per frame
    void Update()
    {
    }
}
