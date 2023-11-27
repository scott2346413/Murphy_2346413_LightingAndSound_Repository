using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class playNoiseOnGrab : MonoBehaviour
{
    [SerializeField] AudioSource noise;
    [SerializeField] ParticleSystem particles; 

    public void playNoise()
    {
        noise.Play();
        particles.Play();
    }
}
