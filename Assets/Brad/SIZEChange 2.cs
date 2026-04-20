using System.Collections;
using System.Collections.Generic;
using InfimaGames.LowPolyShooterPack;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerup/Size")]
public class SIZEchange : powerUp
{
    public float size;
    public override void Apply(GameObject player)
    {
        player.transform.localScale *= size;
    }
}
