using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;


    public GameObject continueButton;
    public GameObject choiceButton;

    //public AudioClip textNotification;
    // Start is called before the first frame update

    void Start()
    {
        StartCoroutine(Type());
        continueButton.SetActive(false);
        choiceButton.SetActive(false);
        choiceButton.SetActive(false);
    }

    void Update()
    {
        if(textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }
    IEnumerator Type()
    {

        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        continueButton.SetActive(true);
    }



    
    public void NextSentence()
    {
        continueButton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
            //AudioSource.PlayClipAtPoint(textNotification, Camera.main.transform.position);

        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
            choiceButton.SetActive(true);
        }
    }

}
