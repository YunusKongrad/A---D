using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ArayuzAnlatim : MonoBehaviour
{
    public InputField OyuncuAdiI, KarakterAdiI, NickI;
    public GameObject anamenuPanel, loadingPanel, hosgeldinizPanel, levelbasiPanel, 
                        oyunekraniPanel, slideryuzPanel, slidersifirPanel, sayacsifirPaneli, 
                        pausePanel, nasiloynanirPanel, creditsPanel;
    public Slider LoadBAR, HasarBAR, SayacBAR;
    public Text OyuncuAdiT, KarakterAdiT, NickT;

    private void Start()
    {
        LoadBAR.maxValue = 5f;
        LoadBAR.minValue = 0f;
        LoadBAR.value = 5f;
        LoadBAR.interactable = false;
        HasarBAR.minValue = 0;
        HasarBAR.maxValue = 100;
        HasarBAR.value = 50;
        HasarBAR.interactable = false;
        SayacBAR.minValue = 0;
        SayacBAR.maxValue = 60;
        SayacBAR.value = 60;
        SayacBAR.interactable = false;
    }
    public void MenuBaslaButonFonk()
    {
        anamenuPanel.SetActive(false);
        loadingPanel.SetActive(true);
    }

    private void Update()
    {
        if (loadingPanel.activeInHierarchy == true)
        {
            if (LoadBAR.value > 0)
            {
                LoadBAR.value -= Time.deltaTime;
            }
            else
            {
                loadingPanel.SetActive(false);
                
                OyuncuAdiT.text = OyuncuAdiI.text;
                KarakterAdiT.text = KarakterAdiI.text;
                NickT.text = NickI.text;

                hosgeldinizPanel.SetActive(true);
            }
        }
        if (oyunekraniPanel.activeInHierarchy == true)
        {
            if (SayacBAR.value > 0)
            {
                SayacBAR.value -= Time.deltaTime;
            }
            else
            {
                oyunekraniPanel.SetActive(false);
                sayacsifirPaneli.SetActive(true);
            }
            
            if (Input.GetKeyDown(KeyCode.A))
            {
                HasarBAR.value += 5;
            }
            else if(Input.GetKeyDown(KeyCode.D))
            {
                HasarBAR.value -= 5;
            }
        }

        // if (HasarBAR.value == 100)
        // {
        //     oyunekraniPanel.SetActive(false);
        //     slideryuzPanel.SetActive(true);
        // }
        //
        // if (HasarBAR.value == 0)
        // {
        //     oyunekraniPanel.SetActive(false);
        //     slidersifirPanel.SetActive(true);
        // }
    }

    public void HosgeldinDevamButonFonk()
    {
        hosgeldinizPanel.SetActive(false);
        LoadBAR.value = 5;
        levelbasiPanel.SetActive(true);
    }

    public void LevelBasiButonFonk()
    {
        levelbasiPanel.SetActive(false);
        SayacBAR.value = 60;
        HasarBAR.value = 50;
        oyunekraniPanel.SetActive(true);
    }
    
    // public void OyunEkraniFonk()
    // {
    //     oyunekraniPanel.SetActive(false);
    // }
    
    public void AnaMenuButon()
    {
        creditsPanel.SetActive(false);
        nasiloynanirPanel.SetActive(false);
        pausePanel.SetActive(false);
        sayacsifirPaneli.SetActive(false);
        slideryuzPanel.SetActive(false);
        slidersifirPanel.SetActive(false);
        anamenuPanel.SetActive(true);
    }

    public void YenidenOynaButon()
    {
        creditsPanel.SetActive(false);
        nasiloynanirPanel.SetActive(false);
        sayacsifirPaneli.SetActive(false);
        slideryuzPanel.SetActive(false);
        slidersifirPanel.SetActive(false);
        HasarBAR.value = 50;
        SayacBAR.value = 60;
        oyunekraniPanel.SetActive(true);
    }

    public void aa()
    {
        if (HasarBAR.value == 100)
        {
            oyunekraniPanel.SetActive(false);
            slideryuzPanel.SetActive(true);
        }
        else if(HasarBAR.value == 0)
        {
            oyunekraniPanel.SetActive(false);
            slidersifirPanel.SetActive(true);
        }
    }

    // public void bb()
    // {
    //     if (SayacBAR.value<0) 
    //     {
    //         oyunekraniPanel.SetActive(false);
    //         sayacsifirPaneli.SetActive(true);
    //     }
    //     
    // }

    public void PauseButon()
    {
        oyunekraniPanel.SetActive(false);
        pausePanel.SetActive(true);
    }

    public void OyunaDonButon()
    {
        pausePanel.SetActive(false);
        oyunekraniPanel.SetActive(true);
    }

    public void NasilOynanir()
    {
        anamenuPanel.SetActive(false);
        nasiloynanirPanel.SetActive(true);
    }

    public void Exit()
    {
        slideryuzPanel.SetActive(false);
        slidersifirPanel.SetActive(false);
        sayacsifirPaneli.SetActive(false);
        pausePanel.SetActive(false);
    }
}