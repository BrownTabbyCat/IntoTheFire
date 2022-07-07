using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextMessageOpen : MonoBehaviour
{
    public GameObject textMessages;

    public void OpenTexts()
    {
        if (textMessages != null)
        {
            textMessages.SetActive(true);
        }
    }
}
