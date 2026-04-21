using UnityEngine;

public class CatLay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] public SpriteRenderer spriteRenderer;
    [SerializeField] private Animator animator;

    
    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetBool("CatLay", true);
        }
        else
        {
            animator.SetBool("CatLay", false);
        }
    }
}
