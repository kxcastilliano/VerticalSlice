using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingManager : MonoBehaviour
{
    public static EndingManager Instance;

    public int friendshipPoints = 0;

    public int goodEndingThreshold = 3;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void AddFriendship(int amount)
    {
        friendshipPoints += amount;
        Debug.Log("Friendship: " + friendshipPoints);
    }

    public void CheckEnding()
    {
        if (friendshipPoints >= goodEndingThreshold)
        {
            SceneManager.LoadScene("GoodEnding");
        }
        else
        {
            SceneManager.LoadScene("BadEnding");
        }
    }
}
