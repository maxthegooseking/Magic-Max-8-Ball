using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Message : MonoBehaviour
{
    public static Message Instance;
    public int fateMessage;
    public string messageToDisplay;
    public TextMeshProUGUI textUI;
    public KeyCode Space;

    public string[] answers = new string[]
    {
        "For sure man.", //pos
        "I suppose.",
        "Yeah probably.",
        "Uhhh. Yes?",
        "Oh, without a doubt.",
        "I think so.",
        "Yes.",
        "Mhm",
        "Dude YES",

        "I beg your pardon?", //neg
        "LOL maybe.",
        "Definitely not.",
        "Fuck, I don't know",
        "No. Not in any universe.",
        "Not sure...",
        "Nope!",
        "HELL no.",
        "Try again"

    };

//public string answerText;

    public void GetRandomAnswer()
    {
        int randomIndex = Random.Range(0, answers.Length);

        if (textUI != null)
        {
            textUI.text = answers[randomIndex];
        }
        else
        {
            Debug.LogWarning("Answer Text UI element not assigned!");
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetRandomAnswer();
        }
    }
    private void FateMessageGenerate()
    {
        textUI.SetText(messageToDisplay);
    }


}


