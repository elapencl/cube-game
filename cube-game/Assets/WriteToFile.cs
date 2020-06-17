using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class WriteToFile : MonoBehaviour
{
    private String username = "Tsu";
    private String postURL = "http://localhost:8000/cube-game/PHP/fromunity.php";
    private void OnGUI()
    {
        GUIStyle buttonStyle = new GUIStyle(GUI.skin.button);
        buttonStyle.fontSize = 25;
        if (GUI.Button(new Rect(10, 10, 450, 80), "Send Information To File", buttonStyle))
        {
            StartCoroutine(SimplePostRequest(username));
        }
    }

    IEnumerator SimplePostRequest(string username)
    {
        List<IMultipartFormSection> wwwForm = new List<IMultipartFormSection>();
        wwwForm.Add(new MultipartFormDataSection("username", username));
        wwwForm.Add(new MultipartFormDataSection("age", "21"));
        wwwForm.Add(new MultipartFormDataSection("score", "125"));

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

    /**IEnumerator sendTextToFile()
    {
        bool succesful = true;
        UnityWebRequest form = UnityWebRequest;
        form.AddField("name", "Jasper Bloggs");
        form.AddField("age", 21);
        form.AddField("score", 125);
        WWW www = WWW("http://localhost:8000/fromunity.php", form);

        yield return www;
        if (www.error != null)
        {
            succesful = false;
        }
        else
        {
            Debug.Log(www.text);
            succesful = true;
        }
    }
    */
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}