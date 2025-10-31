using UnityEngine;

public class AplicadorDeFuerza : MonoBehaviour
{
    // Esta variable será visible en el Inspector de Unity
    // para que podamos aplicar la misma fuerza a ambos objetos
    public float magnitudDeFuerza = 50f; 

    // Variable para almacenar el componente Rigidbody 2D del objeto
    private Rigidbody2D rb;

    void Start()
    {
        // Obtener el componente Rigidbody 2D del GameObject
        rb = GetComponent<Rigidbody2D>();

        // Aplicar la fuerza al Rigidbody
        // Vector2.right es un vector que apunta en la dirección +x
        rb.AddForce(Vector2.right * magnitudDeFuerza);
    }
}
