using UnityEngine;

public class ControlMomentumAngular : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocidadGiroInicial = 100f;
    public Transform brazoDerecho; 
    public Transform brazoIzquierdo;
    
    private float inerciaConBrazosExtendidos;
    public float inerciaConBrazosContraidos = 1f; // Ajusta este valor en el Inspector

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        
        // Guardar la inercia inicial
        inerciaConBrazosExtendidos = rb.inertia;
        
        rb.angularVelocity = velocidadGiroInicial;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Ocultar los brazos visualmente
            brazoDerecho.gameObject.SetActive(false);
            brazoIzquierdo.gameObject.SetActive(false);
            
            // Establecer manualmente la inercia para simular que los brazos están contraídos
            rb.inertia = inerciaConBrazosContraidos;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            // Mostrar los brazos de nuevo
            brazoDerecho.gameObject.SetActive(true);
            brazoIzquierdo.gameObject.SetActive(true);
            
            // Restablecer la inercia a su valor inicial
            rb.inertia = inerciaConBrazosExtendidos;
        }
    }
}
