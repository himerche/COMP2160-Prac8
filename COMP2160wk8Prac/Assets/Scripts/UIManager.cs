using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Transform canvas;

    private Text scoreText;

    static private UIManager instance;

    static public UIManager Instance
    {
        get
        {
            if(instance == null)
            {
                Debug.LogError("There is no UI Manager in the scene.");
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

    void Start()
    {
        canvas.transform.Find("Score");
    }

    void Update()
    {
        scoreText.text = $"Score: {Scorekeeper.Instance.CurrentScore}";
    }
}
