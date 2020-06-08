﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Controlador : MonoBehaviour
{
    public GameObject menu1;
    public GameObject menu1_1;
    public GameObject menu1_1_1;

    public GameObject menu1_2;
    public GameObject atras;

    public GameObject menu1_4;

    public GameObject menu2;
    public GameObject menu2_1;
    public GameObject menu2_1_1;

    public GameObject menu2_2;
    public GameObject atras2;

    
    public GameObject multiTarget;
    public GameObject camaraAR;

    public Toggle tipoMergeCube;
    public Toggle tipoCapturaTarget;
    static bool tipoARMerge=true;
    static bool tipoARCaptura=false;

    static bool tomatoLive = false;
    static bool calabazaLive = false;
    static bool giraSolLive = false;

    // Start is called before the first frame update

    public void CambiarEscena(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    //Controla el botón Atras del menú.
    public void Atras()
    {
        if (!menu1.active )
        {
            if (!menu1_1.active )
            {
                if (!menu1_1_1.active)
                {
                    //normal
                    menu1_2.SetActive(false);
                    menu1.SetActive(true);
                    atras.SetActive(false);

                    //ar
                    menu2_2.SetActive(false);
                    menu2.SetActive(true);
                    atras2.SetActive(false);
                }
                else
                {
                    //normal
                    menu1_1_1.SetActive(false);
                    menu1_1.SetActive(true);
                    //ar
                    menu2_1_1.SetActive(false);
                    menu2_1.SetActive(true);
                }
                
            }
            else{
                //normal
                menu1_1.SetActive(false);
                menu1.SetActive(true);
                atras.SetActive(false);

                //ar
                menu2_1.SetActive(false);
                menu2.SetActive(true);
                atras2.SetActive(false);
            }
        }
    }

    //Controla el botón Atras del menú modo AR.
    public void Atras2()
    {
        if (!menu2.active)
        {
            if (!menu2_1.active)
            {
                if (!menu2_1_1.active)
                {
                    menu2_2.SetActive(false);
                    menu2.SetActive(true);
                    atras2.SetActive(false);
                    //normal
                    menu1_2.SetActive(false);
                    menu1.SetActive(true);
                    atras.SetActive(false);
                }
                else
                {
                    //ar
                    menu2_1_1.SetActive(false);
                    menu2_1.SetActive(true);
                    //normal
                    menu1_1_1.SetActive(false);
                    menu1_1.SetActive(true);

                }
                
            }
            else
            {
                //ar
                menu2_1.SetActive(false);
                menu2.SetActive(true);
                atras2.SetActive(false);
                //normal
                menu1_1.SetActive(false);
                menu1.SetActive(true);
                atras.SetActive(false);
            }
        }
    }

    //Actualiza el tipo de Target ha usar.
    public void TipoDeAR()
    {
        if (tipoMergeCube.isOn)
        {
            tipoARCaptura = false;
            tipoARMerge = true;

        }else if (tipoCapturaTarget.isOn)
        {
            tipoARCaptura = true;
            tipoARMerge = false;
        }

    }

    
    public  bool GetTipoARMergecube()
    {
        return tipoARMerge;
    }

    public  bool GetTipoARcapturar()
    {
        return tipoARCaptura;
    }

    public void ActivarTomate()
    {
        tomatoLive = true;
        //desactivar el resto de plantas
        calabazaLive = false;
        giraSolLive = false;

    }

    public void ActivarCalabaza()
    {
        calabazaLive = true;
        //desactivar el resto de plantas
        tomatoLive = false;
        giraSolLive = false;
    }

    public void ActivarGiraSol()
    {
        giraSolLive = true;
        //desactivar el resto de plantas
        calabazaLive = false;
        tomatoLive = false;

    }

    public bool GetTomato()
    {
        return tomatoLive;
    }

    public bool GetCalabaza()
    {
        return calabazaLive;
    }

    public bool GetGirasol()
    {
        return giraSolLive;
    }

    public void Start()
    {
        menu1.SetActive(true);
        menu1_1.SetActive(false);
        menu1_1_1.SetActive(false);
        menu1_2.SetActive(false);
        menu1_4.SetActive(false);
        atras.SetActive(false);

        camaraAR.SetActive(false);
        multiTarget.SetActive(false);

        tipoCapturaTarget.isOn=false;
        tipoMergeCube.isOn = true;
    }
}
