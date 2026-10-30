using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoWASD : MonoBehaviour
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


        if (Keyboard.current.dKey.isPressed)
        {
            movimientoX = 1f;
        }
        else if (Keyboard.current.aKey.isPressed)
        {
            movimientoX = -1f;
        }
        else if (Keyboard.current.wKey.isPressed)
        {
            movimientoY = 1f;
        }
        else if (Keyboard.current.sKey.isPressed)
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