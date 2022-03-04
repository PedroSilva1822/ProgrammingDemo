using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextDemo : MonoBehaviour
{
    public TextMeshProUGUI button;
    public TextMeshProUGUI sceneText;

    public GameObject purpleCapsule;

    public bool gameWon = false;

    public CollisionDetecter collisionScript;// A public reference to the rigibody element script.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        button.text = "Press Here";

        if(collisionScript.hitCounter >= 2)
        {
            sceneText.text = "You win!!!";
            gameWon = true;

            purpleCapsule.SetActive(false);
        }
        else
        if(collisionScript.hitCounter < 2)
        {
            sceneText.text = "Hit the purple capsule to win the game";
        }
    }
}
