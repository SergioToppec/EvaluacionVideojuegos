using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class ControladorJuego : MonoBehaviour
{
    void Update()
    {

        if (Keyboard.current != null && Keyboard.current.rKey.wasPressedThisFrame)
        {
            Reiniciar();
        }

#if ENABLE_LEGACY_INPUT_MANAGER
        if (Input.GetKeyDown(KeyCode.R))
        {
            Reiniciar();
        }
#endif
    }

    private void Reiniciar()
    {
        Debug.Log("Reiniciando escena...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}