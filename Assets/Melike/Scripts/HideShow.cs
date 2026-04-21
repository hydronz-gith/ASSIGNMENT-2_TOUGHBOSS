using UnityEngine;

public class HideShow : MonoBehaviour
{
    public GameObject Doll;

    public GameObject originalObject;
    public GameObject targetObject;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(originalObject, targetObject.transform.position, originalObject.transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Destroy(this.gameObject);
        }
    }

    public void hide()
    {
        Doll.SetActive(false);
    }
    public void show()
    {
        Doll.SetActive(true);
    }

}
