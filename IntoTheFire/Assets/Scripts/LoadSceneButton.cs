using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneButton : MonoBehaviour
{
    public string sceneToLoad;
    [SerializeField] float loadDelay = 5f;
    //public ParticleSystem particles;

    public void loadSceneButton()
    {
        //particles.Play();
        //Debug.Log("Particles are showing up.");
        SceneManager.LoadScene(sceneToLoad);
    }

    /*public void playParticles()
    {
        particles.Play();
        Debug.Log("Particles are showing up.");
    }*/

    public void sceneDelay()
    {
        Invoke("loadSceneButton", loadDelay);
        Debug.Log("Loading new scene: " + sceneToLoad);
        //AudioSource.PlayClipAtPoint(celebrationSound, Camera.main.transform.position);
        
    }
}





//public KeyCode sceneLoadButton;
//[SerializeField] AudioClip celebrationSound;
//public ParticleSystem particles;


