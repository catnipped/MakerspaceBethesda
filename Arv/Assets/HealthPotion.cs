using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    public float healthRestored;

    public override string Tostring()
    {
        return string.Format("{0}, has {1}¨of {2} charges remaining It's value per KG is {3}", displayName, charges, maxCharges, GetGoldPerWeight());
    }
    public override void ApllyPotionEffect()
    {
        Debug.Log(string.Format("restored: {0} health", healthRestored));
    }
}
