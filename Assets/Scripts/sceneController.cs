﻿using UnityEngine;

public class sceneController : MonoBehaviour
{
    public GameObject circle;

    float deltaTime = 0.0f;

    void Start()
    {
        Invoke("SpawnCircle", 0.0f);
    }

    void SpawnCircle()
    {
        Instantiate(circle, new Vector3(0.0f, 0.0f, 3.97f), Quaternion.identity);
        Invoke("SpawnCircle", Random.Range(10.0f, 20.0f));
    }

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
    }
   
    /*
    void OnGUI()
    {
        int w = Screen.width, h = Screen.height;

        GUIStyle style = new GUIStyle();

        Rect rect = new Rect(0, 0, w, h * 2 / 100);
        style.alignment = TextAnchor.UpperLeft;
        style.fontSize = h * 2 / 100;
        style.normal.textColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        float msec = deltaTime * 1000.0f;
        float fps = 1.0f / deltaTime;
        string text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
        GUI.Label(rect, text, style);
    }
    */
}
