using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticles : MonoBehaviour
{
    public ParticleSystem particles;

    public void playParticles()
   {
       particles.Play();
       Debug.Log("Particles are showing up.");
   }
}
