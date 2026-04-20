using UnityEngine;

public class playerController : MonoBehaviour
{
    Animator playerAnim;

    private void Awake()
    {
        playerAnim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            playerAnim.SetBool("PurpleSit", true);
        }
        else 
        {
            playerAnim.SetBool("PurpleSit", false);
        }
    }
    



}
