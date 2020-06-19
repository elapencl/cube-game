using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LogCollisions : MonoBehaviour
{
    
    private String message = "Message for log";
    private String postURL = "/fromunity.php";
    // Start is called before the first frame update

    void Start()
    {
        Debug.Log("Logging collisions enabled");
    }

    // Update is called once per frame

    public void sendToLog(String message)
    {
       
        StartCoroutine(PostRequest(message));
    }

    IEnumerator PostRequest(String message)
    {
        Debug.Log("Sending post request");
        List<IMultipartFormSection> wwwForm = new List<IMultipartFormSection>();
        wwwForm.Add(new MultipartFormDataSection("message", message));

        UnityWebRequest www = UnityWebRequest.Post(postURL, wwwForm);

        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.LogError(www.error);
        }
        else
        {
            Debug.Log("Logged successfully");
        }
    }
}
