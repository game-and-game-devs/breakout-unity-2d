using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float _speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Empezando a trabajar en el script del 'Paddle'");
        Debug.Log($"Posición inicial {transform.position}");
        // transform.position += new Vector3(-1, 0, 0);
        // transform.position += Vector3.right;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Estoy en el método Update actualizándome una y otra vez");
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // Añadir Time.deltaTime para ajustar la velocidad de desplazamiento
            transform.position += Time.deltaTime * Vector3.right * _speed;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Time.deltaTime * Vector3.left * _speed;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
    }
}
