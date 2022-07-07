using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneButton : MonoBehaviour
{
    public string sceneToLoad;
    [SerializeField] float loadDelay = 5f;

    public void loadSceneButton()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void sceneDelay()
    {
        Invoke("loadSceneButton", loadDelay);
        Debug.Log("Loading new scene: " + sceneToLoad);
        //AudioSource.PlayClipAtPoint(celebrationSound, Camera.main.transform.position);
        //particles.Play();
    }
}





//public KeyCode sceneLoadButton;
//[SerializeField] AudioClip celebrationSound;
//public ParticleSystem particles;


