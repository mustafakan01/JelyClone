﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Obstacle")
        {
            Debug.Log("change");
            GhostJelly.instance.ChangePosOfTheGhost();
        }
    }
}
