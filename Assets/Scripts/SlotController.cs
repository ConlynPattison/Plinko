using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SlotController : MonoBehaviour
{
    public int slotNumber;
    public int pointValue;
    public TextMeshProUGUI scoreText;

    private static int _score;

    private void Start()
    {
        _score = 0;
        scoreText.SetText("Score: " + _score);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"entered {slotNumber} worth {pointValue} points");
        UpdateScore();
    }

    private void UpdateScore()
    {
        _score += pointValue;
        scoreText.SetText("Score: " + _score);
    }
}
