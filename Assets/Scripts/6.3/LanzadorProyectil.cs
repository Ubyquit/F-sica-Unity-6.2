using UnityEngine;

public class LanzadorProyectil : MonoBehaviour
{
    // Objeto que será lanzado
    public GameObject proyectilPrefab; 
    // Referencia al punto de lanzamiento
    public Transform puntoDeLanzamiento; 
    // Velocidad inicial en X
    public float velocidadInicialX = 10f; 
    // Velocidad inicial en Y
    public float velocidadInicialY = 10f; 

    // Este método se ejecuta en cada frame
    void Update()
    {
        // Detecta si se presiona la tecla de espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Llama a la función que lanza el proyectil
            Lanzar();
        }
    }

    void Lanzar()
    {
        // Instancia un nuevo proyectil en la posición y rotación del punto de lanzamiento
        GameObject nuevoProyectil = Instantiate(proyectilPrefab, puntoDeLanzamiento.position, puntoDeLanzamiento.rotation);
        // Obtiene el Rigidbody2D del nuevo proyectil
        Rigidbody2D rb = nuevoProyectil.GetComponent<Rigidbody2D>();

        // Verifica que el Rigidbody2D exista
        if (rb != null)
        {
            // Aplica la velocidad inicial al proyectil
            // Vector2 representa un vector 2D con coordenadas x e y
            rb.linearVelocity = new Vector2(velocidadInicialX, velocidadInicialY);
        }
    }
}
