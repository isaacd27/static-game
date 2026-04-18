#define IGNORE_INVALID_CHARACTERS
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


    using UnityEngine.EventSystems;
using System.Linq;
using System.Text;



public class Gamehandler : MonoBehaviour
{

    [SerializeField] private GameObject CryptMenu;
    [SerializeField] private GameObject ComputerMenu;
    [SerializeField] private GameObject MainMenu;
    [SerializeField] private GameObject pauseMenu;

    [SerializeField] private TMP_InputField t2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Cryptbook()
    {
        MainMenu.SetActive(false);
                CryptMenu.SetActive(true);
                ComputerMenu.SetActive(false);
    }

    public void Computer()
    {
        MainMenu.SetActive(false);
        CryptMenu.SetActive(false);
        ComputerMenu.SetActive(true);
    }

    public String getinput()
    {
        return t2.text;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (pauseMenu.activeSelf== false)
        {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if(MainMenu.activeSelf == true && ComputerMenu.activeSelf == false)
            {
                MainMenu.SetActive(false);
                CryptMenu.SetActive(true);
                ComputerMenu.SetActive(false);
            }
            else if(CryptMenu.activeSelf == true)
            {
                MainMenu.SetActive(true);
                CryptMenu.SetActive(false);
            }
        }

            if (Input.GetKeyDown(KeyCode.Minus))
            {
                if (MainMenu.activeSelf == true)
                {
                    MainMenu.SetActive(false);
                    CryptMenu.SetActive(false);
                    ComputerMenu.SetActive(true);
                }
                else
                {
                    CryptMenu.SetActive(false);
                    MainMenu.SetActive(true);
                    ComputerMenu.SetActive(false);
                }
            }


        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(pauseMenu.activeSelf == false)
            {
        
                    ComputerMenu.SetActive(false);
                    pauseMenu.SetActive(true);
            }
            else
            {
                
                    pauseMenu.SetActive(false);
                    if (MainMenu.activeSelf == false && CryptMenu.activeSelf == false)
                {
                    MainMenu.SetActive(true);
                }
            }
        }
    }

    public void anwsercheck(TMP_InputField i)
    {

        

    
    }


    

    public void VinDecryption(TMP_InputField i, TMP_InputField key,TMP_Text t)
    {
        /*char[]keychars = key.text.ToCharArray();
        double[] keyints= new double[keychars.Length];

        foreach (char c in keychars)
        {
            Console.Write(c);
            keyints[c]= Char.GetNumericValue(c) -1;
            Console.Write(keyints[c].ToString());
        }

        char[]inputchars = i.text.ToCharArray();
        double[] inputints = new double[inputchars.Length];

        foreach(char c in inputchars)
        {
            inputints[c] = Char.GetNumericValue(c);
        }*/



       // t.text = DecryptVigenere(i.text, key.text);

    }

        //ascii character codes my beloathed....

        
    
    }

    
