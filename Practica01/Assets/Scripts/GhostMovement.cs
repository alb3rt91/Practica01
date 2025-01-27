using UnityEngine;

public class GhostMovement : MonoBehaviour
{
    public float moveSpeed = 5f;  // Velocidad del movimiento del fantasma

    void Update()
    {
        // Obtener el input del teclado para los cursores
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Crear un vector para mover al fantasma
        Vector2 movement = new Vector2(horizontal, vertical).normalized;

        // Mover el fantasma
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
