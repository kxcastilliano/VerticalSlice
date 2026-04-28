using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DialogueLine", menuName = "ScriptableObjects/DialogueLine", order = 1)]
public class DialogueNode : ScriptableObject
{

    public string Line;
    public DialogueNode nextNode;
    public bool hasChoices;
    public DialogueChoice[] replychoices;

    [System.Serializable]
    public class DialogueChoice
    { public string ChoiceText;
        public DialogueNode nextNode;
    }
}
   


