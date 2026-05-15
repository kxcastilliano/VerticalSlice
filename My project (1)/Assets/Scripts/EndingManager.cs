using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingManager : MonoBehaviour
{
    public static EndingManager Instance;

    public int friendshipPoints = 0;

    public int goodEndingThreshold = 3;
    public string firstcutscene;
    public string secondcutscene;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        
        SyncVisualScriptingVariables();
    }

    public void AddFriendship(int amount)
    {
        friendshipPoints += amount;
        Debug.Log("Friendship: " + friendshipPoints);
        SyncVisualScriptingVariables();
    }

    private void SyncVisualScriptingVariables()
    {
        Variables.Object(gameObject).Set("friendshippoints", friendshipPoints);
        Variables.Object(gameObject).Set("goodthreshold", goodEndingThreshold);
    }

    public void CheckEnding()
    {
        if (friendshipPoints >= goodEndingThreshold)
        {
            SceneManager.LoadScene(firstcutscene);
        }
        else
        {
            SceneManager.LoadScene(secondcutscene);
        }
    }
}
