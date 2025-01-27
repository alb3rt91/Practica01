using System.Collections;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    private SpriteRenderer blockRenderer;
    private Color originalColor;
    private AudioSource audioSource;

    void Start()
    {
        blockRenderer = GetComponent<SpriteRenderer>();
        originalColor = blockRenderer.color;
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pelota"))
        {
            Debug.Log("Colisión detectada con la pelota.");

            // Cambiar color a amarillo
            blockRenderer.color = Color.yellow;

            // Reproducir sonido
            if (audioSource != null)
            {
                audioSource.Play();
            }

            // Restaurar color después de 0.5 segundos
            StartCoroutine(ChangeColorBack());
        }
    }

    private IEnumerator ChangeColorBack()
    {
        yield return new WaitForSeconds(0.5f);
        Debug.Log("Restaurando color original.");
        blockRenderer.color = originalColor;
    }
}
