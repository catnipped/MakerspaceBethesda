using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public float fireRate = 0.1f;
    public float fireCooldown = 0f;
    public float gunSpread = 5f;

    public GameObject projectilePrefab;

    public Transform point;


    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButton("Fire"))
        {
            if (CanFire())
            {
                Fire();
            }
        }
    }

    //kollar om min cooldown är klar
    private bool CanFire()
    {
        return fireCooldown <= 0;
    }

    //"spawnar" en kula samt skjuter
    private void Fire()
    {
        Instantiate(projectilePrefab, point.position, AngleWithSpread(gunSpread));
        fireCooldown = fireRate;
    }

    //avancerad matte
    private Quaternion AngleWithSpread(float spread)
    {
        return (point.rotation * Quaternion.Euler(0, 0, Random.Range(-spread, spread)));
    }
}
