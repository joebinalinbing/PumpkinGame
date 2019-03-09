using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public float health = 100f;
    public string name = "Wizard";
    public void PlayerInfo()
    {

        Debug.Log("Player Name is: " + name + "Players Health is: " + health);
    }

}
