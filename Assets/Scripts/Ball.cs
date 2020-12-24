using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Mantiene como variable privada dentro de la clase pero podemos
    // modificar dentro del Inspector
    [SerializeField] Rigidbody2D _rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        // _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.velocity = Vector2.up;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Colisiona la pelota con " + collision.transform.name);
    }
}
