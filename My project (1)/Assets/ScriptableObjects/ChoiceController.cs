using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class ConversationChangeEvent : UnityEvent<Conversation> { }
public class ChoiceController : MonoBehaviour
{
    public Choice choice;
    public ConversationChangeEvent conversationChangeEvent;

    public static ChoiceController AddChoiceButton(Button choiceButtonTemplate, Choice choice, int index)
    {
        int buttonSpacing = 70;

        Button button = Instantiate(choiceButtonTemplate, choiceButtonTemplate.transform.parent);
        button.gameObject.SetActive(true);

        button.transform.localScale = Vector3.one;
        button.transform.localPosition = new Vector3(0, -index * buttonSpacing, 0);
        button.name = "Choice " + (index + 1);

        ChoiceController choiceController = button.GetComponent<ChoiceController>();
        choiceController.choice = choice;

        button.GetComponentInChildren<TextMeshProUGUI>().text = choice.text;
        button.onClick.AddListener(choiceController.MakeChoice);

        return choiceController;
    }

    public void Start()
    {
        if (conversationChangeEvent == null) { conversationChangeEvent = new ConversationChangeEvent();
            GetComponent<Button>();
           
        }
    }

    public void MakeChoice()
    {
        DialogueDisplay.Instance.ChangeConversation(choice.conversation);

        QuestionController qc = GetComponentInParent<QuestionController>();
        qc.Hide(choice.conversation);
    }
    
}
