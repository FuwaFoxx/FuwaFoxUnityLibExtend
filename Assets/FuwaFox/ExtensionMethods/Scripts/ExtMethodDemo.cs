using FuwaFox.Extensions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtMethodDemo : MonoBehaviour
{
    /*
     * This script shows how you can use extension method to reset transform!
     * 
     * First, you include||using the namespace FuwaFox.Extensions
     * and it will be available in your script!
     * (sometimes you can just let the system include for you.)
     * 
     * This demo is simply reset the object transform to the origin when out of distance
     * compare this to the script ExtMethodDemoLegacy.cs
     */

    [SerializeField] private float boundaryDistance = 5;

    void Update()
    {

        if (Vector3.Distance(transform.position, Vector3.zero) > boundaryDistance)
        {
            // This ResetTransform() is an extension method defined in FuwaFoxExtensions
            this.transform.ResetTransform();
        }
    }
}
