using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public bool onGround;
    void Start()
    {
       onGround = false; 
    }

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
        print("Space key was released");
      if (GetComponent<Rigidbody>() != null)
      {
        GetComponent<Rigidbody>().useGravity = true;
      }
        }
      if(Input.GetKeyDown(KeyCode.A))
      {
      if (onGround){
        Vector3 fuerza = new Vector3(0, 500, 0);
        GetComponent<Rigidbody>().AddForce(fuerza);
      }
    }
    }
    private void OnCollisionEnter(Collision c){
        Debug.Log("colision");
        onGround = true;
    }
      private void OnCollisionStay(Collision c){
        onGround = true;
    }
      private void OnCollisionExit(Collision c){
        onGround = false;
        Debug.Log("Libre");
    }
}
