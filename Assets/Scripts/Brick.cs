using UnityEngine;

public class Brick : MonoBehaviour
{
    GameObject gameManagerObject;
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        // Buscamos el script "GameManager" para comunicarnos con el
        // Lo asignamos en un GameObject para tener acceso a sus componentes
        gameManagerObject = GameObject.Find("GameManager");

        // Añadimos la comprobación para asegurarnos que cargamos correctamente el
        // el gameManager Object
        if (gameManagerObject == null)
        {
            Debug.Log("Objecto no encontrado");
        }
        else
        {
            // Nos permite acceder al GameManager y a su información
            gameManager = gameManagerObject.GetComponent<GameManager>();
            // Reducir el número de bloques a destruir en el nivel
            gameManager.bricksOnLevel++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Buscamos el script "GameManager" para comunicarnos con el
        // Lo asignamos en un GameObject para tener acceso a sus componentes
        gameManagerObject = GameObject.Find("GameManager");

        // Añadimos la comprobación para asegurarnos que cargamos correctamente el
        // el gameManager Object
        if (gameManagerObject == null)
        {
            Debug.Log("Objecto no encontrado");
        }
        else
        {
            // Nos permite acceder al GameManager y a su información
            gameManager = gameManagerObject.GetComponent<GameManager>();
            // Reducir el número de bloques a destruir en el nivel
            gameManager.bricksOnLevel--;
        }
        
        // Al recibir la colision de la bola, se destroye el bloque "Brick"
        Destroy(gameObject);
    }
}
