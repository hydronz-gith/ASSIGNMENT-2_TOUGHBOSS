using UnityEngine;

public class TimedDestroyCountdown : MonoBehaviour
{
    public float lifetime = 3f;
    private float timer;

    void Start()
    {
        timer = lifetime; // start the countdown at 3
    }

    void Update()
    {
        timer -= Time.deltaTime; // subtract real time every frame

        if (timer <= 0)
        {
            Destroy(gameObject);
        }
    }
}
