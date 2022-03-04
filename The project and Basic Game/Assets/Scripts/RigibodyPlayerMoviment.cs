using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigibodyPlayerMoviment : MonoBehaviour
{
    /* public float moveSpeed;
    private Rigibody rigibody;*/

    public float moveSpeed;// Controls player movement speed.
    private Rigidbody rigibody;

    // Start is called before the first frame update
    private void Awake()
    {
        rigibody = GetComponent<Rigidbody>();//The moment the script is active, retrieve the rigibody component of the Gameobject.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Update is called once per frame
    private void FixedUpdate()//Prefered update when using anything resolving around physics. Ensures consistent functionality regardless of frame
    {
        rigibody.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, rigibody.velocity.y, Input.GetAxis("Vertical")) * moveSpeed; Debug.Log("Currently detecting" + rigibody);
    }
}
