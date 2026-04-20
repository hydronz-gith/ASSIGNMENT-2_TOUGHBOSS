using UnityEngine;

public class CollisionSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public AudioClip collisionSound;

    void OnCollisionEnter(Collision collision)
    {
        // get collision point
        Vector3 spawnPos = collision.contacts[0].point;

        // spawn object there
        GameObject obj = Instantiate(objectToSpawn, spawnPos, Quaternion.identity);
        Destroy(obj, 3f); // auto clean up after 3 seconds

        // play sound
        AudioSource.PlayClipAtPoint(collisionSound, spawnPos);
    }
}     

