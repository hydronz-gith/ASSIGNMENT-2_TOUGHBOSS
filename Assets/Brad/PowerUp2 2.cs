using UnityEngine;

public class PowerUp2 : MonoBehaviour
{
    public powerUp powerupEffect;
    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }

    void Pickup(Collider player)
    {
        Destroy(gameObject);
        powerupEffect.Apply(player.gameObject);
    }
}
