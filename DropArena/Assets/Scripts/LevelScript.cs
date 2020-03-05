﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScript: MonoBehaviour {

    void Start () {

    }

    void Update () {

    }

    public void LevelLoader () {

        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);

        int indexCounter = SceneManager.GetActiveScene ().buildIndex;

        //works if it is not the last scene, needs playing with
        if (indexCounter == 10) {
            UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit ();
        }

    }
}