using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] bool _gameStarted;
    public bool GameStarted
    {
        get => _gameStarted;
        set => _gameStarted = value;
    }
    [SerializeField] bool _ballOnPlay;
    public bool BallOnPlay
    {
        get => _ballOnPlay;
        set {
            _ballOnPlay = value;
            if (_ballOnPlay)
            {
                Debug.Log("Empezamos a lanzar la bola");
                FindObjectOfType<Ball>().LaunchBall();
            }
        }
    }
    [SerializeField] byte _playerLives = 4;
    public byte PlayerLives
    {
        get => _playerLives;
        set
        {
            _playerLives = value;
            if (_playerLives == 0)
            {
                Debug.Log("Juego perdido");
                Destroy(GameObject.Find("Ball"));
            }

        }
    }
    [SerializeField] byte _bricksOnLevel;
    public byte BricksOnLevel
    {
        get => _bricksOnLevel;
        set
        {
            _bricksOnLevel = value;
            if (_bricksOnLevel == 0)
            {
                Debug.Log("Has ganado el nivel");
                Destroy(GameObject.Find("Ball"));
                // TODO Mostrar pantalla de victoria
                // TODO Medir tiempo de juego
            }
        }
    }
}
