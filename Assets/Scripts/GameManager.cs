using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private int score = 0;

    public GameObject[] jellyPieces;

    public GameObject winText;

    public GameObject replayButton;

    void Start()
    {
        jellyPieces = GameObject.FindGameObjectsWithTag("JellyPiece");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {            
        score++;
        if (score >= jellyPieces.Length)
        {
            Win();
        }
    }

    public void Win()
    {

        winText.SetActive(true);
        replayButton.SetActive(true);
    }

    public void Replay()
    {
        SceneManager.LoadScene("GameScene");
    }
}
