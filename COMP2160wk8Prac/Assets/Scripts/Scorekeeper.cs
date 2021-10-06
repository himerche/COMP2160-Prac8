using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{
    public int pointsPerPickup = 10;

    private int currentScore = 0;

    public int CurrentScore
    {
        get
        {
            return currentScore;
        }
    }

    static private Scorekeeper instance;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentScore);
    }
    static public Scorekeeper Instance
    {
        get
        {
            if(instance == null)
            {
                Debug.LogError("There is no Scorekeeper in the scene.");
            }
            return instance;
        }
    }

    void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }

        currentScore = 0;
    }

    public void PickupCoin()
    {
        currentScore += pointsPerPickup;
    }
}
