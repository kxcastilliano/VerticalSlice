using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningDialogue : MonoBehaviour
{
   
   
    [SerializeField] private DialogueController _dialogue;
    [SerializeField] private DialogueNode _dialogueStartNode;

    private DialogueNode _currentNode;
    private int _currentLine = 0;
    private bool _runningDialogue;
    private bool _waitingForPlayerResponse;

    private void Start()
    {
        _currentNode = _dialogueStartNode;
    }

    private void Update()
    {
        if (!_waitingForPlayerResponse && Input.GetKeyDown(KeyCode.Space))
            {
                AdvanceDialogue();
            }
          
        else
        {
            EndDialogue();
        }
    }

    private void AdvanceDialogue()
    {
        _runningDialogue = true;
        

        if (_currentLine < _currentNode._lines.Length)
        {
            
            _dialogue.ShowDialogue(_currentNode._lines[_currentLine]);
            _currentLine++;
        }
        else if (_currentNode._playerReplyOptions != null && _currentNode._playerReplyOptions.Length > 0)
        {
            
            _waitingForPlayerResponse = true;
            _dialogue.ShowPlayerOptions(_currentNode._playerReplyOptions);
        }
        else
        {
            
            EndDialogue();
        }
    }

    private void EndDialogue()
    {
        _runningDialogue = false;
        _waitingForPlayerResponse = false;
        _currentNode = _dialogueStartNode;
        _currentLine = 0;
        _dialogue.HideDialogue();
      
    }

    public void SelectedOption(int option)
    {
        _currentLine = 0;
        _waitingForPlayerResponse = false;

        _currentNode = _currentNode._npcReplies[option];
        AdvanceDialogue();
    }
}
