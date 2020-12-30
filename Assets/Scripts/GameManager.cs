using UnityEngine;

public class GameManager : MonoBehaviour
{

    private float _gameTime = 0;
    [SerializeField] bool _gameStarted;
    public bool GameStarted
    {
        get => _gameStarted;
        set
        {
            _gameStarted = value;
            _gameTime = Time.time;
        }
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
                FindObjectOfType<Ball>().Launch();
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
                // Mostrar pantalla de derrota
                FindObjectOfType<UIController>().ActivePanel(FinishGameStateEnum.LOSE);
            } else
            {
                Debug.Log("Vidas: " + _playerLives);
                FindObjectOfType<Ball>().Reset();
            }
            FindObjectOfType<UIController>().UpdateUILives(_playerLives);

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
                _gameTime = Time.time - _gameTime;
                // Mostrar pantalla de victoria
                FindObjectOfType<UIController>().ActivePanel(FinishGameStateEnum.WIN, _gameTime);
                
                Debug.Log("Tiempo final: " + _gameTime);
            }
        }
    }

    void Start()
    {
        // Start columns in screen
        for (int i = 0; i <= 7; i++)
        {
            // Instantiate(_rockSmall, new Vector2(18, -1.5f), Quaternion.identity));
        }

        // Start obstacles
        // Instantiate(_rockSmall, new Vector2(18, -1.5f), Quaternion.identity));
    }
}
