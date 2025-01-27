using UnityEngine;

public class KiteMovement : MonoBehaviour
{
    public float speed = 5f;        // Velocidad de movimiento horizontal
    public float tiltSpeed = 5f;    // Velocidad de inclinación de la cometa
    public GameObject cola;         // Referencia a la cola

    void Update()
    {
        // Movimiento horizontal de la cometa
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horizontalInput * speed * Time.deltaTime);

        // Inclinación de la cometa
        float verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.forward * verticalInput * tiltSpeed * Time.deltaTime);

        // Movimiento de la cola con el viento
        SimulateWind();
    }

    void SimulateWind()
    {
        // Movimiento de la cola (simulando el viento) con una función seno
        float wind = Mathf.Sin(Time.time * 3f) * 0.1f;
        cola.transform.localPosition = new Vector3(wind, cola.transform.localPosition.y, 0);
    }
}
