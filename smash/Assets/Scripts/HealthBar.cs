using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public PlayerController player; // jugador a seguir
    public Image fill; // tu imagen "Fill"

    void Update()
    {
        if (player != null)
        {
            fill.fillAmount = player.health / 100f;
        }
    }
}

