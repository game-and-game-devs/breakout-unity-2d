using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private byte _bricksOnLevel;
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
