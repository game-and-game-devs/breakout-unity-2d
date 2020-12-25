using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Mantiene como variable privada dentro de la clase pero podemos
    // modificar dentro del Inspector
    [SerializeField] Rigidbody2D _rigidbody2D;

    // Para controlar el rebote y determinar su dirección y velocidad
    private Vector2 _moveDirection;
    private Vector2 _currenVelocity;

    [SerializeField] float _speed = 4;
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        // _rigidbody2D = GetComponent<Rigidbody2D>();
        // No Usamos deltaTime al no estar dentro de Update
        // _rigidbody2D.velocity = Vector2.up * _speed;
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
     Método de Unity que se usa parahacer cálculos con el motor de física
     */
    void FixedUpdate()
    {
        // Extraer la velocidad por frame, en este caso para conocer la última
        // velocidad antes del impacto
        _currenVelocity = _rigidbody2D.velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Colisiona la pelota con " + collision.transform);

        /*
         * Para asignarle la velocidad y dirección que tomará cuando haga la colisión
         * Necesitamos:
         * - La velocidad actual
         * - La "normal" del polígono en el que se hace el contacto
         * ("normal" = vector perpendícular a una superficie, es decir, un vector que crea 
         * un ángulo de 90º con respecto a la base de un polígono)
         */
        _moveDirection = Vector2.Reflect(_currenVelocity, collision.GetContact(0).normal);

        // Asignamos a la velocidad del rigidbody
        _rigidbody2D.velocity = _moveDirection;
        if (collision.transform.CompareTag("DeathLimit"))
        {
            Debug.Log("Abajo");
            // Destroy(gameObject);
            if(gameManager != null)
            {
                gameManager.PlayerLives--;
            }
        }
    }

    public void LaunchBall()
    {
        // Para no depender de su padre (Paddle) al soltar la bola
        // Si no se moverá con ello a la vez
        transform.SetParent(null);
        _rigidbody2D.velocity = Vector2.up * _speed;
    }
}
