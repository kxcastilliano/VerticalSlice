using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class DialogueDisplay : MonoBehaviour
{
    public Conversation conversation;
    public GameObject speakerleft;
    public GameObject speakerright;
    private SpeakerUI speakerUIleft;
    private SpeakerUI speakerUIright;

    private int activeLineIndex = 0;
    public static DialogueDisplay Instance
    {
        get; private set;
    }


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject); // Destroy duplicate
            return;
        }

    }
    void Start()
    {

        speakerUIleft = speakerleft.GetComponent<SpeakerUI>();
        speakerUIright = speakerright.GetComponent<SpeakerUI>();

        speakerUIleft.Speaker = conversation.speakerLeft;
        speakerUIright.Speaker = conversation.speakerRight;
    }
    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            AdvanceConversation();
        }
    }

    void AdvanceConversation()
    { if (activeLineIndex < conversation.lines.Length)
        {
            DisplayLine();
            activeLineIndex += 1;
        }
else {  speakerUIleft.Hide();
        speakerUIright.Hide();
        activeLineIndex = 0;}
    }

    void DisplayLine()
    { Line line = conversation.lines[activeLineIndex];
        Character character = line.character;
        if (speakerUIleft.SpeakerIs(character))
        {
            SetDialog(speakerUIleft, speakerUIright,line.text);
        }
        else { SetDialog(speakerUIright, speakerUIleft,line.text); }
    }
    void SetDialog( SpeakerUI activeSpeakerUI, SpeakerUI inactiveSpeakerUI,
        string text)
    { activeSpeakerUI.Dialog = text;
        activeSpeakerUI.Show();
        inactiveSpeakerUI.Hide();
    }
    
}
