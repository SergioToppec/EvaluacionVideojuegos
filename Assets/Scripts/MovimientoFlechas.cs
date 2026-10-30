using UnityEngine;
using UnityEngine.InputSystem; // Indispensable para que reconozca Keyboard

public class MovimientoFlechas : MonoBehaviour
{
    public float velocidad = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (Keyboard.current == null) return;

        float movimientoX = 0f;
        float movimientoY = 0f;

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            movimientoX = 1f;
        }
        else if (Keyboard.current.leftArrowKey.isPressed)
        {
            movimientoX = -1f;
        }
        else if (Keyboard.current.upArrowKey.isPressed)
        {
            movimientoY = 1f;
        }
        else if (Keyboard.current.downArrowKey.isPressed)
        {
            movimientoY = -1f;
        }

        Vector2 direccion = new Vector2(movimientoX, movimientoY);
        rb.linearVelocity = direccion * velocidad;

        if (direccion != Vector2.zero)
        {
            float angulo = Mathf.Atan2(movimientoY, movimientoX) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angulo);
        }
    }
}