using UnityEngine;

public class ColisionMomentum : MonoBehaviour
{
    // Variables para la velocidad inicial
    public float velocidadCamion = 5f;
    public float velocidadCoche = 20f;

    // Se ejecuta al inicio
    void Start()
    {
        // Aplicar la velocidad al camión para que se mueva hacia la derecha
        // Obtener el componente Rigidbody2D y establecer su velocidad
        // El camión se moverá lentamente
        GameObject camion = GameObject.Find("Camion");
        Rigidbody2D rbCamion = camion.GetComponent<Rigidbody2D>();
        rbCamion.linearVelocity = Vector2.right * velocidadCamion;
        
        // Aplicar la velocidad al coche para que se mueva hacia la izquierda
        // Obtener el componente Rigidbody2D y establecer su velocidad
        // El coche se moverá rápidamente
        GameObject coche = GameObject.Find("Coche");
        Rigidbody2D rbCoche = coche.GetComponent<Rigidbody2D>();
        rbCoche.linearVelocity = Vector2.left * velocidadCoche;
    }
}
