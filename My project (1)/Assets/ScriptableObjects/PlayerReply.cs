using System;
using UnityEngine;
using Unity.VisualScripting;

public class PlayerReply : MonoBehaviour
{
    
    //---------------------------------------------------------------------
    // Variables
    //---------------------------------------------------------------------
    [Inspectable] public string line;
    [Inspectable] public DialogueNode nextNode;
}

