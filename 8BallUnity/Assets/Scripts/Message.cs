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
        "LOL maybe.", //neg
        "I suppose.", //pos
        "I beg your finest pardon?", // neg
        "Yeah probably.", //pos
        "Definitely not.", //neg
        "Uhhh. Yes?", //pos
        "Oh yes, absolutely.", //pos
        "Fuck, man I don't know", //neg
        "Oh. No. Not in any universe." //neg
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


