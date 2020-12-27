using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float _speed = 3;
    private float _xLimit = 6.9f;
    private GameManager _gameManager;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Empezando a trabajar en el script del 'Paddle'");
        Debug.Log($"Posición inicial {transform.position}");
        _gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Estoy en el método Update actualizándome una y otra vez");
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < _xLimit)
        {
            // Añadir Time.deltaTime para ajustar la velocidad de desplazamiento
            transform.position += Time.deltaTime * Vector3.right * _speed;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -_xLimit)
        {
            transform.position += Time.deltaTime * Vector3.left * _speed;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Bola en juego
            if (_gameManager.BallOnPlay == false)
            {
                _gameManager.BallOnPlay = true;
            }
            // Partida en juego
            if (_gameManager.GameStarted == false)
            {
                _gameManager.GameStarted = true;
            }
        }
    }
}
