using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckTrigger : MonoBehaviour
{
    public UnityEvent hitEvent;

    void OnTriggerEnter2D(Collider2D collision)
    {
        hitEvent.Invoke();
    }
}
