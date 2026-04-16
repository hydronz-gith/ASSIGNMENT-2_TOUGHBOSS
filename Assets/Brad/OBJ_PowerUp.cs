using UnityEngine;

public class OBJ_PowerUp : MonoBehaviour
{
    public powerUp powerupEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        powerupEffect.Apply(collision.gameObject);
    }
}
