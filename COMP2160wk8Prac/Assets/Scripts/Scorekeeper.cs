using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{
    public int pointsPerPickup = 10;

    private int currentScore = 0;

    static private Scorekeeper instance;

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
    }

    public void AddPointsToScore()
    {
        currentScore += pointsPerPickup;
    }
}
