using UnityEngine;

public class Brick : MonoBehaviour
{   GameManager gameManager;
    [SerializeField] GameObject _explosionPrefab;
    // Start is called before the first frame update
        void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        if (gameManager != null)
        {
            // Añadir el número de bloques a destruir en el nivel
            gameManager.BricksOnLevel++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Añadimos la comprobación para asegurarnos que cargamos correctamente el
        // el gameManager Object
        if (gameManager != null)
        {
            // Reducir el número de bloques a destruir en el nivel
            gameManager.BricksOnLevel--;
        }
        
        // Al recibir la colision de la bola, se destroye el bloque "Brick"
        Destroy(gameObject);
    }
}
