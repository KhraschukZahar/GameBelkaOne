﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class AudioOnStartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource> ().Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
