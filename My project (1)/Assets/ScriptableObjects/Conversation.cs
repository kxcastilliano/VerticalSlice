using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Line
{ public Character character;
    [TextArea(2, 5)]
    public string text;
}



    [CreateAssetMenu(fileName = "Conversation", menuName = "ScriptableObjects/Conversation", order = 1)]
    public class Conversation: ScriptableObject
    {
        public Character speakerLeft;
        public Character speakerRight;
        public Line[] lines;
    public Question questions;
    public Conversation nextconversation;
    }

