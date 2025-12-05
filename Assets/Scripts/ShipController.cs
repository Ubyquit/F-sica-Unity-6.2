
using UnityEngine;
using UnityEngine.InputSystem; // InputAction.CallbackContext

/// <summary>
/// Controla la nave del prototipo "Cargo Lifter".
/// Requisitos:
/// - Gravedad desactivada hasta el primer input (Espacio).
/// - Empuje vertical con AddForce mientras se mantiene Espacio.
/// - Desplazamiento lateral con A/D o Flechas (AddForce).
/// - Rotación Z congelada (sin giros).
/// - Feedback visual: cubo del propulsor cambia a amarillo mientras se impulsa.
/// - Caída suave: ajustar drag al soltar.
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
public class ShipController : MonoBehaviour
{
    [Header("Fuerzas")]
    [Tooltip("Magnitud de la fuerza vertical de propulsión (Newton).")]
    public float thrustForce = 15f;

    [Tooltip("Magnitud de la fuerza horizontal (Newton).")]
    public float lateralForce = 12f;

    [Header("Físicas")]
    [Tooltip("Gravedad base que se activará tras el primer input.")]
    public float baseGravityScale = 1f;

    [Tooltip("Arrastre (drag) mientras se impulsa; normalmente más bajo.")]
    public float dragWhileThrust = 0.5f;

    [Tooltip("Arrastre (drag) al soltar para caída suave; normalmente más alto.")]
    public float dragWhileFall = 2.0f;

    [Header("Feedback Visual")]
    [Tooltip("Renderer del cubo propulsor que cambia de color.")]
    public Renderer thrusterRenderer;

    [Tooltip("Color cuando el propulsor está activo (amarillo).")]
    public Color activeColor = Color.yellow;

    // --- Estado interno ---
    private Rigidbody2D rb;
    private Color originalColor = Color.white;

    // Flags de estado
    private bool hasGameStarted = false; // Gravedad suspendida al inicio
    private bool isThrusting = false;    // Se mantiene Espacio
    private float steerAxis = 0f;        // -1 .. +1 a partir de A/D o Flechas

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        // Congelar rotación en Z para evitar giros sobre el pivote
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;

        // Estado inicial: sin gravedad (suspensión)
        rb.gravityScale = 0f;

        // Drag inicial bajo para flote estático
        rb.drag = dragWhileThrust;

        // Guardar color original del propulsor
        if (thrusterRenderer != null && thrusterRenderer.material != null)
        {
            originalColor = thrusterRenderer.material.color;
        }
    }

    private void FixedUpdate()
    {
        // Aplicar fuerzas en el loop de física
        ApplyThrust();
        ApplySteer();
    }

    // === Eventos del Input System (Player Input -> Invoke Unity Events) ===

    /// <summary>
    /// Mapeado al evento de la acción "Thrust" (Keyboard/space).
    /// Recibe started/performed/canceled desde Input System.
    /// </summary>
    public void OnThrust(InputAction.CallbackContext context)
    {
        if (context.started || context.performed)
        {
            // Primer input: activar gravedad base
            if (!hasGameStarted)
            {
                hasGameStarted = true;
                rb.gravityScale = baseGravityScale;
            }

            isThrusting = true;

            // Feedback visual: propulsor activo
            SetThrusterColor(activeColor);

            // Mientras se impulsa, el drag suele ser más bajo
            rb.drag = dragWhileThrust;
        }
        else if (context.canceled)
        {
            isThrusting = false;

            // Feedback visual: propulsor apagado
            SetThrusterColor(originalColor);

            // Al soltar, aumentar drag para una caída más suave (evitar caída libre brusca)
            rb.drag = dragWhileFall;
        }
    }

    /// <summary>
    /// Mapeado al evento de la acción "Steer" (1D Axis: A/D o Flechas).
    /// </summary>
    public void OnSteer(InputAction.CallbackContext context)
    {
        if (context.performed || context.started)
        {
            // Leer eje: -1 (izquierda) a +1 (derecha)
            steerAxis = context.ReadValue<float>();
        }
        else if (context.canceled)
        {
            steerAxis = 0f;
        }
    }

    // === Lógica de movimiento ===

    private void ApplyThrust()
    {
        if (!isThrusting) return;

        // Empuje vertical continuo (F = m*a, AddForce modo Force para aceleración suave)
        rb.AddForce(Vector2.up * thrustForce, ForceMode2D.Force);
    }

    private void ApplySteer()
    {
        if (Mathf.Approximately(steerAxis, 0f)) return;

        // Fuerza lateral proporcional al eje
        rb.AddForce(Vector2.right * (steerAxis * lateralForce), ForceMode2D.Force);
    }

    private void SetThrusterColor(Color c)
    {
        if (thrusterRenderer == null) return;

        // material crea instancia, asegura que no se cambie el material compartido en otros objetos
        var mat = thrusterRenderer.material;
        if (mat != null)
        {
            mat.color = c;
        }
    }
}
