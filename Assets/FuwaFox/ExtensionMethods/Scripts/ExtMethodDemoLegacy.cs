using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtMethodDemoLegacy : MonoBehaviour
{
    /*
     * This demo is simply reset the object transform to the origin when out of distance
     * this script is doing it in the normal way (not utilizing the extension method)
     */

    [SerializeField] private float boundaryDistance = 5;
    
    void Update()
    {
        
        if(Vector3.Distance(transform.position, Vector3.zero) > boundaryDistance)
        {
            this.transform.localPosition = new Vector3(0, 0, 0);
            this.transform.localRotation = Quaternion.identity;
            this.transform.localScale = Vector3.one;
        }
    }
}
