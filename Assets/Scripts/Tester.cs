using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    float power = 2.4f;
    double health = 3.5;
    int score = 44;
    string name = "Wizards";
    bool isAlive = false;
    // Start is called before the first frame update
    void Start()
    {
        Player wizard = new Player();
        wizard.PlayerInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
