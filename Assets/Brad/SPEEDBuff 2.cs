using System.Collections;
using System.Collections.Generic;
using InfimaGames.LowPolyShooterPack;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerup/Speed")]
public class SPEEDBuff : powerUp
{
    public float walkingSPD;
    public float runningSPD;
    public override void Apply(GameObject target)
    {
        target.GetComponent<Movement>().speedWalking *= walkingSPD;
        target.GetComponent<Movement>().speedRunning *= runningSPD;
    }
}