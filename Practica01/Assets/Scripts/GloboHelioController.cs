using UnityEngine;

public class GloboHelioController : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Velocidad del movimiento
    private Rigidbody2D rb;       // Referencia al Rigidbody2D

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Obtener el componente Rigidbody2D
    }

    void Update()
    {
        // Capturar entrada del usuario
        float moveX = Input.GetAxis("Horizontal"); // Movimiento horizontal
        float moveY = Input.GetAxis("Vertical");   // Movimiento vertical

        // Crear un vector de movimiento
        Vector2 movement = new Vector2(moveX, moveY);

        // Aplicar el movimiento horizontal
        transform.Translate(new Vector3(movement.x, 0f, 0f) * moveSpeed * Time.deltaTime);

        // Controlar el movimiento vertical
        if (moveY < 0) // Si se presiona "S" o flecha hacia abajo
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, -moveSpeed); // Mover hacia abajo
        }
        else if (moveY > 0) // Si se presiona "W" o flecha hacia arriba
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, moveSpeed); // Mover hacia arriba
        }
        else
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0f); // Detener movimiento vertical si no se presionan teclas
        }
    }
}
