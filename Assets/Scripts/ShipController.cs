using UnityEngine;
using UnityEngine.InputSystem;

public class ShipController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float thrustForce = 12f;     // Fuerza vertical
    public float lateralForce = 8f;     // Fuerza horizontal

    [Header("Thruster Visual")]
    public Renderer thrusterRenderer;  // Cubo del propulsor
    public Color activeColor = Color.yellow;

    private Rigidbody2D rb;
    private Color originalColor;

    private bool gravityEnabled = false;

    private float steerInput = 0f;
    private bool thrusting = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        // Guardar el color base del propulsor
        if (thrusterRenderer != null)
            originalColor = thrusterRenderer.material.color;

        // Estado inicial sin gravedad
        rb.gravityScale = 0f;
        rb.drag = 0f;

        // Evitar rotación
        rb.freezeRotation = true;
    }

    void FixedUpdate()
    {
        // Propulsión vertical
        if (thrusting)
        {
            rb.AddForce(Vector2.up * thrustForce, ForceMode2D.Force);
        }

        // Movimiento lateral
        if (Mathf.Abs(steerInput) > 0.1f)
        {
            rb.AddForce(Vector2.right * steerInput * lateralForce, ForceMode2D.Force);
        }
    }

    // ===========================
    // INPUT SYSTEM EVENTS
    // ===========================

    public void OnThrust(InputAction.CallbackContext context)
    {
        // Activar gravedad al primer input
        if (!gravityEnabled)
        {
            gravityEnabled = true;
            rb.gravityScale = 1f;
        }

        // PRESIONAR
        if (context.started)
        {
            thrusting = true;
            rb.drag = 0f;

            if (thrusterRenderer != null)
                thrusterRenderer.material.color = activeColor;
        }

        // SOLTAR
        else if (context.canceled)
        {
            thrusting = false;

            // Caída suave
            rb.drag = 2.5f;

            if (thrusterRenderer != null)
                thrusterRenderer.material.color = originalColor;
        }
    }

    public void OnSteer(InputAction.CallbackContext context)
    {
        // Vector horizontal A/D o ← →
        steerInput = context.ReadValue<float>();
    }
}
