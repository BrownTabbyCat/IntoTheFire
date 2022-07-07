using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scrolling : MonoBehaviour
{
    public RawImage houseFire;
    public float x;
    public float y;

    // Update is called once per frame
    void Update()
    {
        houseFire.uvRect = new Rect(houseFire.uvRect.position + new Vector2(x, y) * Time.deltaTime, houseFire.uvRect.size);
    }
}
