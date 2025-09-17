using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

public class Concurrencia : MonoBehaviour
{
    [Header("Activa los metodos")]
    public bool useSincrono;
    public bool useThread;
    public bool useTask;
    public bool useCorutine;

    [Header("Cosas a mover")]
    public bool sincronoSphere;
    public bool threadSphere;
    public bool taskSphere;
    public bool corutineSphere;
    public bool coroutineSphere;

    //Accion a ejecutar en lo secundario
    private Queue<Action> mainThreadActions = new Queue<Action>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (useSincrono) MoveSincrono();
        if (useThread) MoveWithThread();
        /*if (useTask) MoveWithTask();
        if (useCorutine) MoveWithCorutine();*/

    }

    void MoveSincrono() {

    }

    private void MoveWithThread() {

    }
    /*
    private async MoveWithTask() {

    }

    private async MoveWithCorutine() {


    }
    */
    // Update is called once per frame
    void Update()
    {
        
    }
}
