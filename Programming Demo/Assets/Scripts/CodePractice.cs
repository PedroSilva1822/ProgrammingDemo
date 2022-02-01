using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodePractice : MonoBehaviour
{
    public GameObject playerCharacter;
    public int frames;
    // Start is called before the first frame update
    void Start()
    {
        frames += 1;
    }

    // Update is called once per frame
    void Update()
    {
   
        print("numbers " + frames);

    }
}
