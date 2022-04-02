using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
public class CheckConn : MonoBehaviour
{
    public GameObject ConnError;

    void Start()
    {
        ConnError.SetActive(false);
    }

    
    void Update()
    {
        StartCoroutine(CheckConnectionToMasterServer());
    }

    private IEnumerator CheckConnectionToMasterServer()
    {
        Ping pingMasterServer = new Ping("45.158.12.45");
        //Debug.Log(pingMasterServer.ip);
        float startTime = Time.time;
        while (!pingMasterServer.isDone && Time.time < startTime + 5.0f)
        {
            yield return new WaitForSeconds(1f);
        }
        if (pingMasterServer.isDone)
        {
            //Debug.Log("Internet Connection Succes");
            ConnError.SetActive(false);
        }
        else
        {
            //Debug.Log("No Internet Connection!");
            ConnError.SetActive(true);
        }
    }



}


