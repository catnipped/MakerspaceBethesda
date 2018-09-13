﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanWalk : MonoBehaviour
{
    private int touchingObjects;

    public bool IsTouching()
    {
        return (touchingObjects > 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        touchingObjects++;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        touchingObjects--;
    }
}
