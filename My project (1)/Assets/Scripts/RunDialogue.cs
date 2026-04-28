using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static NewDialogueEvent;
  public class DialogueAdvancer : MonoBehaviour
    {
        [SerializeField] private DialogueNode nextLine;

        // Button hooks up to this method
        public void ChooseDialogue()
        {
            EventBus.Trigger(EventNames.NewDialogueEvent, nextLine);
        }

        public void PrintHello()
        {
            Debug.Log("proceed");
        }
    }

