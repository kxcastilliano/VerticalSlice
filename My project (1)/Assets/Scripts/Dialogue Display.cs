using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;

public class DialogueDisplay : MonoBehaviour
{
    public Conversation conversation;
    public GameObject speakerleft;
    public GameObject speakerright;
    private SpeakerUI speakerUIleft;
    private SpeakerUI speakerUIright;
    public UnityEngine.Events.UnityEvent<Question> questionEvent;
    public ConversationChangeEvent conversationChangeEvent;
    private int activeLineIndex = 0;
    private bool conversationStarted = false;
    public static DialogueDisplay Instance
    {
        get; private set;
    }


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

    }
    public void ChangeConversation(Conversation nextConversation)
    {
        conversation = nextConversation;
        conversationStarted = false;
        activeLineIndex = 0;
 AdvanceLine();
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
            AdvanceLine();
        }
    }

    private void Initialize()
    {
        conversationStarted = true;
        activeLineIndex = 0;
        speakerUIleft.Speaker = conversation.speakerLeft;
        speakerUIright.Speaker = conversation.speakerRight;
    }

    void AdvanceLine()
    {  if (conversation == null) return;
        if (conversationStarted) Initialize();
        
        
        if (activeLineIndex < conversation.lines.Length)
        {
            DisplayLine();
            activeLineIndex += 1;
        }
else { AdvanceConversation(); }
    }

    void DisplayLine()
    { Line line = conversation.lines[activeLineIndex];
        Character character = line.character;
        if (speakerUIleft.SpeakerIs(character))
        {
            SetDialog(speakerUIleft, speakerUIright,line.text, line.expression);
        }
        else { SetDialog(speakerUIright, speakerUIleft,line.text, line.expression); }
       
    }
    void SetDialog(SpeakerUI activeSpeakerUI, SpeakerUI inactiveSpeakerUI, string text, Sprite expression)
    { activeSpeakerUI.Dialog = text;
        activeSpeakerUI.SetPortrait(expression);
        activeSpeakerUI.Show();
        inactiveSpeakerUI.Hide();
    }

    private void AdvanceConversation()
    {
        if (conversation.isLastInteraction)
        {
            EndingManager.Instance.CheckEnding();
        }
 else if (conversation.questions != null)
        {
            questionEvent.Invoke(conversation.questions);
        }
        else if (conversation.nextconversation)
        {
            conversationChangeEvent.Invoke(conversation.nextconversation);
        }
      
    }
}
