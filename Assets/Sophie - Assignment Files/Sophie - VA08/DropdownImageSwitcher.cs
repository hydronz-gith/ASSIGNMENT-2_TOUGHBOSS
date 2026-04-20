using UnityEngine;
using UnityEngine.UI;

public class DropdownImageSwitcher : MonoBehaviour
{
    public Image targetImage;
    public Sprite[] imageOptions;

    // Update is called once per frame
    public void OnDropdownChanged(int index)
    {
        if(index >= 0 && index < imageOptions.Length)
            targetImage.sprite = imageOptions[index];
    }
}
