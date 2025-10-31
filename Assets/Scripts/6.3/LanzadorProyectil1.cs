using UnityEngine;

public class LanzadorProyectil1 : MonoBehaviour
{
    public GameObject proyectilPrefab; 
    public Transform puntoDeLanzamiento; 
    public float velocidadInicialX = 10f;
    public float velocidadInicialY = 10f;

    public float destruirBala = 3f;

    // Referencia al Line Renderer
    private LineRenderer lr; 
    // Variables para predecir la trayectoria
    public int puntosDeTrayectoria = 30; // Cuántos puntos usaremos para dibujar la línea
    public float intervaloDeTiempo = 0.1f; // El tiempo entre cada punto
    
    void Start()
    {
        // Obtener el Line Renderer del mismo objeto
        lr = GetComponent<LineRenderer>();
        // Asegurarse de que el Line Renderer esté desactivado al inicio
        lr.enabled = false;
    }
    
    void Update()
    {
        // Detecta si se mantiene la tecla de espacio presionada
        if (Input.GetKey(KeyCode.Space))
        {
            // Muestra el Line Renderer y dibuja la trayectoria
            lr.enabled = true;
            DibujarTrayectoria();
        }
        
        // Detecta si se suelta la tecla de espacio
        if (Input.GetKeyUp(KeyCode.Space))
        {
            // Oculta el Line Renderer y lanza el proyectil
            lr.enabled = false;
            Lanzar();
        }
    }

    void Lanzar()
    {
        GameObject nuevoProyectil = Instantiate(proyectilPrefab, puntoDeLanzamiento.position, puntoDeLanzamiento.rotation);
        Rigidbody2D rb = nuevoProyectil.GetComponent<Rigidbody2D>();

        Destroy(nuevoProyectil, destruirBala);

        if (rb != null)
        {
            rb.linearVelocity = new Vector2(velocidadInicialX, velocidadInicialY);
        }
    }

    void DibujarTrayectoria()
    {
        // Calcula la velocidad inicial como un vector
        Vector2 velocidadInicial = new Vector2(velocidadInicialX, velocidadInicialY);
        // Ajusta la cantidad de puntos en el Line Renderer
        lr.positionCount = puntosDeTrayectoria;
        
        // Simula la trayectoria paso a paso y establece la posición de los puntos
        for (int i = 0; i < puntosDeTrayectoria; i++)
        {
            float tiempo = i * intervaloDeTiempo;
            // Ecuación de movimiento de un proyectil:
            // Posición_x = Posición_inicial_x + Velocidad_inicial_x * tiempo
            // Posición_y = Posición_inicial_y + Velocidad_inicial_y * tiempo + 0.5 * Gravedad * tiempo^2
            Vector2 punto = (Vector2)puntoDeLanzamiento.position + velocidadInicial * tiempo + 0.5f * Physics2D.gravity * (tiempo * tiempo);
            lr.SetPosition(i, punto);
        }
    }
}
