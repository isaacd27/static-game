using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.Universal;
using System;


public class RankDeterminer: MonoBehaviour
{

    //public GameObject player;
    public TMP_Text rank;

    //SetSavedVariable SScore;
    string input;
    string ranktext = "NO RANK";
    string temprank;    // Start is called before the first frame update
    public static RankDeterminer Instance;
    public Gamehandler GH;


    private void Awake(){
    
        //code for making sure there are no copies
        //i forget how it is supposed to work
        // so  i'm disabing it for now

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        
    
    }
    void Start()
    {
        

       // PlayerController playerController = player.GetComponent<PlayerController>();


       // score = playerController.getscore();

        if (rank == null)
        {
            if (GameObject.Find("RankText").GetComponent<TMP_Text>() != null)
            {
                rank = GameObject.Find("RankText").GetComponent<TMP_Text>();
            }
        }

        if(GH == null)
        {
            
        }
        //might need to move to update
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (SceneManager.GetActiveScene() != SceneManager.GetSceneByName("SolvingScene"))
        {
            if (rank == null)
            {
                if (GameObject.Find("RankText").GetComponent<TMP_Text>() != null)
                {
                    rank = GameObject.Find("RankText").GetComponent<TMP_Text>();
                }
                else
                {
                    //return;
                }
            }
            else
            {
        
            if (input == "thanks for playing" || input == "Thanks for playing" || input == "THANKS FOR PLAYING")
        {
        
            rank.text = "USER: " + temprank + "\nADMIN: Looks right to me! why don't you go on that vacation now?";
        }else if (input == "THANK YOU FOR PLAYING CZA = AAAAAAA NGSMZN CQYEPD MLCP HBJZDIIE" || input == "thank you for playing cza = aaaaaaa ngsmzn cqyepd mlcp hbjzdiie")
                {
                    rank.text= "USER: " + temprank + "\nADMIN: I thought i told you to remove gibberish at the end! \nADMIN: You're fired!";
                }
        else if(input == "This is a super secret" || input == "THIS IS A SUPER SECERT" || input == "this is a super secret")
                {
                    rank.text= "USER: " + temprank + "\nADMIN: Where'd you find that message? good work! \nADMIN: you'll get a promotion after your vacation, for finding the secret ending."; 
                }

        else if (input == "vqc wfkjh vrtq pb drboezf yq kvn btmh, cacs'h qbv? ioq = zfjdzs zfosnbp -.- . -.-- = -- --- .-. ... . fmefny lckyca dwedvk 13,11,15,43,11,42 .---- -.... .---- ..... .---- ..--- ..--- ..... ..--- ----. ..--- .---- .---- ----.")
                {
                    //note: 
                    /*
                    1 = .----
                    2 = ..---
                    3 = ...--
                    4 = ....-
                    5 = .....
                    6 = -....
                    7 = --...
                    8 = ---..
                    9 = ----.
                    0 = -----
                    */

                    //hello ludum dare code readers.
                    //play the game properly
                    //then read the code.

                    rank.text= "USER: " + temprank + "\nADMIN:do you even know what this one says? \nADMIN: consider it a final challenge to figure it out.";
                }
        
        else if (input == "" || input == null)
                {
                    rank.text = "ADMIN: ??? \n ADMIN: you forgot to send anything at all!  you're fired!";
                }
        else
        {
            rank.text =  "USER: " + temprank + "\nADMIN: That looks like gibberish.\n ADMIN: remove any cipher names or keys during translation, they're only there to tell you what to do. \nADMIN:also, use spaces between words! \nADMIN: whenever possible, decode everything. \nADMIN: get back to the office and try again!";
        }
            
                
            
                
                


            }
        }
    }

public void gotonextscene(int sceneID)
    {
        input = GH.getinput();
        Debug.Log(input);
        temprank = input;
        SceneManager.LoadScene(sceneID);

    }

/*  void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
        
            score = player.GetComponent<PlayerController>().getscore();
            SceneManager.LoadScene(2);
        }

    
        
        //move to finale screen


        //SScore = score;
    }*/
}
