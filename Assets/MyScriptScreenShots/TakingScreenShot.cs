
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Windows;

public class TakingScreenShot : MonoBehaviour
{
    public Camera myCamera;
    public RenderTexture m_image;
    public Texture2D m_screenshot;

    public void ScreenShot ()
    {
        Debug.Log("Taking Screenshot");

        int resWidthN = 1920;
        int resHeightN = 1080;

        
        m_image = new RenderTexture(resWidthN, resHeightN, 24);
        myCamera.targetTexture = m_image;

        m_screenshot = new Texture2D(resWidthN, resHeightN, TextureFormat.RGB24, false);
        myCamera.Render();
        RenderTexture.active = m_image;
        m_screenshot.ReadPixels(new Rect(0, 0, resWidthN, resHeightN), 0, 0);
        myCamera.targetTexture = null;
        RenderTexture.active = null;
        byte[] bytes = m_screenshot.EncodeToPNG();
        string filename = ScreenShotName(resWidthN, resHeightN);

        System.IO.File.WriteAllBytes(filename, bytes);
        Debug.Log(string.Format("Took screenshot to: {0}", filename));

     // Application.OpenURL(filename);
     // Application.dataPath("");
     // JsonUtility.ToJson();
     // JsonUtility.FromJson("");
    }

    public string m_lastScreenshot = "";
    public string m_path = "";

    public string ScreenShotName(int width, int height)
    {
        string strPath = "";

        strPath = string.Format("{0}/screen_{1}x{2}_{3}.png",
                             m_path,
                             width, height,
                                       System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));
        m_lastScreenshot = strPath;

        return strPath;
    }

    public string GetProjectName()
    {
        string[] s = Application.dataPath.Split('/');
        string projectName = s[s.Length - 2];
        Debug.Log("project = " + projectName);
        return projectName;
    }

    [MenuItem("A/B &#_r")]
    public static void FolderCreation()
    {
        string path = "C:/Users/student106/Pictures";

        //https://docs.unity3d.com/ScriptReference/Application-temporaryCachePath.html
        Debug.Log("Hum:"+Application.temporaryCachePath);
    }
}
