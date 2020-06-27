using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebcamTexture : MonoBehaviour
{
    // Starts the default camera and assigns the texture to the current renderer
    void Start()
    {
        WebCamTexture webcamTexture = new WebCamTexture();
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }
}
