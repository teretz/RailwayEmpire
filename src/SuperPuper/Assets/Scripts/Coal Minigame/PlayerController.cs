using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Scene _scene;
    [SerializeField] private int _score;
    [SerializeField] private int _lostCoalScore;
    [SerializeField] private Transform _playerPosition1;
    [SerializeField] private Transform _playerPosition2;
    [SerializeField] private Transform _playerPosition3;
    [SerializeField] private Transform _playerPosition4;
    [SerializeField] private TextMeshProUGUI _scoreScreen;
    [SerializeField] private TextMeshProUGUI _lostScoreScreen;
    public float time = .25f;

    private void Update()
    {
        Move(time);
    }

    public void AddScore(int points)
    {
        _score += points;
        _scoreScreen.text = "Score: " + _score;
        if (_score == 25)
        {
            print("WIN NAHUI, TI POBEDIL EBANA");
        }
    }
    public void AddLostScore(int points)
    {
        _lostCoalScore += points;
        _lostScoreScreen.text = "Lost Coals: " + _lostCoalScore;
        if (_lostCoalScore == 10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            print("TI EBLAN, POPROBUY ESHE RAZ");
        }
        
    }

    void Move(float duration)
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.DOMove(_playerPosition1.position,duration);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.DOMove(_playerPosition2.position,duration);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.DOMove(_playerPosition3.position,duration);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.DOMove(_playerPosition4.position,duration);
        }
    }
}