using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Message : MonoBehaviour
{
    public static Message Instance;
    public int fateMessage;
    public string messageToDisplay;
    public TextMeshProUGUI

    public string[] answers = new string[]
    {
        "For sure man.",
        "LOL maybe.",
        "I suppose.",
        "I beg your finest pardon?",
        "Yeah probably.",
        "Definitely not.",
        "Uhhh. Yes?",
        "Oh yes, absolutely.",
        "Fuck, man I don't know",
        "Oh. No. Not in any universe."
    };

    public TMPro.TextMeshPro answerText;

    public void GetRandomAnswer()
    {
        int randomIndex = Random.Range(0, answers.Length);

        if (answerText != null)
        {
            answerText.text = answers[randomIndex];
        }
        else
        {
            Debug.LogWarning("Answer Text UI element not assigned!");
        }

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}


