using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearingcheck : MonoBehaviour
{

    public Noise targetNoiseMaker;

    // This just waits for a noise to happen
    public bool listenForNoise()
    {
        if (targetNoiseMaker == null)
        {
            return false;
        }
        else
        {
            float noiseLevel = targetNoiseMaker.noise;
            float distance = Vector3.Distance(transform.position, targetNoiseMaker.gameObject.transform.position);
            noiseLevel -= distance;
            if (noiseLevel > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}