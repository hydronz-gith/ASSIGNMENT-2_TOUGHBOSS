using System.Collections;
using UnityEngine;

public class TimedDestroyCoroutine : MonoBehaviour
{
    public float lifetime = 3f;

    void Start()
    {
        StartCoroutine(DestroyAfterDelay());
    }

    IEnumerator DestroyAfterDelay()
    {
        yield return new WaitForSeconds(lifetime);
        Destroy(gameObject);
    }
}
