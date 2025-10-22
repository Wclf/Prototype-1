﻿using UnityEngine;
using UnityEngine.UI;

public class CameraSwitch : MonoBehaviour
{
    public Camera[] cameras; // Array to hold the cameras
    private int currentCameraIndex;

    void Start()
    {
        // Disable all cameras except the first one (MainCamera)
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(i == 0);
        }
        currentCameraIndex = 0; // Start with the MainCamera
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            SwitchCamera();
        }
    }

    public void SwitchCamera()
    {
        // Disable the current camera
        cameras[currentCameraIndex].gameObject.SetActive(false);

        // Update the index to the next camera
        currentCameraIndex = (currentCameraIndex + 1) % cameras.Length;

        // Enable the new current camera
        cameras[currentCameraIndex].gameObject.SetActive(true);
    }
}