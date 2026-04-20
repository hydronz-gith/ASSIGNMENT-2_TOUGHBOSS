using UnityEngine;

public class Input
{
    public bool meep_Input;

private void OnEnable()
{
 if (meepButton) == null)
 {
  meepButton = new meepButton();
  meepButton.Meepbutton.meepmeep.performed += i => meep_Input = true;
}
}
public void HandleMeep()
{
if (meep_Input)
{
meep_Input = false;
AudioSource.PlayClipAtPoint(clickSound, transform.position);
}
}
}
