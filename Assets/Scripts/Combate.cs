using UnityEngine;

public class CombatePico : MonoBehaviour
{
    public string nombreAtacante = "Azul";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Espalda"))
        {
            if (collision.transform.parent != transform.parent)
            {
                GameObject jugadorEliminado = collision.transform.parent.gameObject;

                Debug.Log(">Presiona la tecla [R] para reiniciar la partida ");

                jugadorEliminado.SetActive(false); // para este desaparece el jugador
            }
        }
    }
}