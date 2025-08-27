using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VRWalk : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //Atributo
    public Transform vrCamera;

    //Variables de clase 
    public float angle = 30.0f;
    public float speed = 3.0f;
    public bool move;

    public CharacterController cc;
    void Start()
    {
        cc = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (vrCamera.eulerAngles.x >= angle && vrCamera.eulerAngles.x < 60)
        {
            move = true;
        }
        else
        {
            move = false;
        }
        if (move)
        {
            Vector3 direction = vrCamera.TransformDirection(Vector3.forward);
            cc.SimpleMove(direction * speed);
        }

    }
}
