﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision) {
        GameObject.Find("DoodleHead").SetActive(false);
        GameController.GameOver();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
