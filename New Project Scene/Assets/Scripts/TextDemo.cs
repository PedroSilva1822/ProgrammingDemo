using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextDemo : MonoBehaviour
{
    public TextMeshProUGUI sceneText;
    public TextMeshProUGUI numberText;

    public GameObject orangeCylinder;


    public CollisionDetecter collisionScript;//A public reference to the rigibody movement script.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        numberText.text = collisionScript.hitCounter.ToString();

        
        if (collisionScript.hitCounter >= 5)
        {
            sceneText.text = "The player has won!!!";
            /*orangeCylinder.setActive(false);*/
            Destroy(orangeCylinder);//The player object will be removed from the scene.
            WinFunction();
        }
        else   
        if(collisionScript.hitCounter < 5)
        {
            sceneText.text = "Hit the orange cylinder to win";

        }

        void WinFunction()
        {
            print("I have been called!");
        }
    }
}
