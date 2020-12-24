using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] byte _playerLives = 4;
    [SerializeField] byte _bricksOnLevel;
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
