using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Setting : MonoBehaviour
{
    Resolution[] rsl;
    List<string> resoulutions;
    public Dropdown dropdown;
    bool isFullScreen;

    public void Awake()
    {
        resoulutions = new List<string>();
        rsl = Screen.resolutions;
        foreach(var i in rsl)
        {
            resoulutions.Add(i.width + "x" + i.height);
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(resoulutions);
    }




    public void FullScreenToggle()
    {
        isFullScreen = !isFullScreen;
        Screen.fullScreen = isFullScreen;
    }

    public AudioMixer am;

    public void AudioVolume(float sliderValue)
    {
        am.SetFloat("masterVolume", sliderValue);
    }

    public void ResolutionS(int res)
    {
        Screen.SetResolution(rsl[res].width, rsl[res].height, isFullScreen);
    }





}
