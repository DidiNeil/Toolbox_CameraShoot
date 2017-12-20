
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Windows;
using System;
using System.IO;

public class TakingScreenShot
{
    public Camera myCamera;
    public RenderTexture m_image;
    public Texture2D m_screenshot;

    //Prend un screenshot de la scene, en PNG
    public void ScreenShot ()
    {
        if (!Directory.Exists("C:/Users/student106/Pictures/Screen_DIDI_DIEGO_FRANçOIS"))
        {
            // Try to create the directory.
            DirectoryInfo di = Directory.CreateDirectory("C:/Users/student106/Pictures/Screen_DIDI_DIEGO_FRANçOIS");
        }

        Debug.Log("Taking Screenshot");

        int resWidthN = 1920;
        int resHeightN = 1080;

      /*  SceneView.
        var view = SceneView.currentDrawingSceneView;
        if (view != null)
        {
            var target = new GameObject();
            target.transform.position = NewCameraPosition;
            target.transform.rotation = NewCameraRotation;
            view.AlignViewToObject(target.transform);
            GameObject.DestroyImmediate(target);
        }*/

        m_image = new RenderTexture(resWidthN, resHeightN, 24);
        myCamera.targetTexture = m_image;

        m_screenshot = new Texture2D(resWidthN, resHeightN, TextureFormat.RGB24, false);
        myCamera.Render();
        RenderTexture.active = m_image;
        m_screenshot.ReadPixels(new Rect(0, 0, resWidthN, resHeightN), 0, 0);
        myCamera.targetTexture = null;
        RenderTexture.active = null;
        byte[] bytes = m_screenshot.EncodeToPNG();
       // string filename = ScreenShotName(resWidthN, resHeightN);

        File.WriteAllBytes("C:/Users/student106/Pictures/Screen_DIDI_DIEGO_FRANçOIS", bytes);
        Debug.Log(string.Format("Took screenshot to: {0}", "Screennnn"));

     // Application.OpenURL(filename);
     // Application.dataPath("");
     // JsonUtility.ToJson();
     // JsonUtility.FromJson("");
    }

    public string m_lastScreenshot = "";
    public string m_path = "";

    //Donne un nom au fichier en fonction de sa taille et de la date et du nom du projet
    /*
    public string ScreenShotName(int width, int height)
    {
        string strPath = "";

        strPath = string.Format(GetProjectName() +"" ,
                             m_path,
                             width, height,
                                       System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));
        m_lastScreenshot = strPath;

        return strPath;
    }
    */
    /*
    public string GetProjectName()
    {
        string[] s = Application.dataPath.Split('/');
        string projectName = s[s.Length - 2];
        Debug.Log("project = " + projectName);
        return projectName;
    }
    */


   /* [MenuItem("A/B &#_r")]
    public static void FolderCreation()
    {
        string path = "C:/Users/student106/Pictures";

        //https://docs.unity3d.com/ScriptReference/Application-temporaryCachePath.html
        Debug.Log("Hum:"+Application.temporaryCachePath);
    }*/
}
