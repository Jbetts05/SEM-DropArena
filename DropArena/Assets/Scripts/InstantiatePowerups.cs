﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePowerups : MonoBehaviour
{   

    private enum PowerUps{
        sizePowerup = 0,
        speedPowerup =  1,
        massPowerup = 2,
        nofallPowerup = 3,
        sizePowerdown = 4,
        speedPowerdown = 5,
        massPowerdown = 6,
        freezePowerDown = 7
    }
 
    // Current time
    private float _time;

    private boolean doesPowerupExist;

    // Positive powerups
    public GameObject sizePowerup;
    public GameObject speedPowerup;
    public GameObject massPowerup;
    public GameObject nofallPowerup;

    // Negative powerups
    public GameObject sizePowerdown;
    public GameObject speedPowerdown;
    public GameObject massPowerdown;
    public GameObject freezePowerDown;

    // Start is called before the first frame update
    void Start()
    {
        time = 0.0f;
        generatePowerup();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(
    }

    private void generatePowerup() {

    }
}
