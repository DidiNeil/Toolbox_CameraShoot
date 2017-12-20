
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Windows;
using System;
using System.IO;

[System.Serializable]
public class TakingScreenShot : MonoBehaviour
{
    public Camera myCamera;
    public RenderTexture m_image;
    public Texture2D m_screenshot;

 List<Spot> mySpotList = new List<Spot>();
 public TakingScreenShot(){

     Spot myspot = new Spot();
     myspot.angle = new Vector3(0,0,0);
     myspot.position = new Vector3(0,2,0);
     mySpotList.Add(myspot);
     myspot.angle = new Vector3(1, 10, 5);
     myspot.position = new Vector3(10, 2, 20);
     mySpotList.Add(myspot);
     myspot.angle = new Vector3(5, 9, 47);
     myspot.position = new Vector3(9, 82, 70);
     mySpotList.Add(myspot);
     myspot.angle = new Vector3(7, 4, 2);
     myspot.position = new Vector3(58, 55, 4);
     mySpotList.Add(myspot);
     myspot.angle = new Vector3(0, 0, 4);
     myspot.position = new Vector3(89, 2, 0);
     mySpotList.Add(myspot);

     ScreenShot("C:/Users/student106/Pictures/Screen_DIDI_DIEGO_FRANçOIS", mySpotList);



 }

    //Prend un screenshot de la scene, en PNG
    public void ScreenShot (string _path , List<Spot> shotSpots)
    {
        //  _path = "C:/Users/student106/Pictures/Screen_DIDI_DIEGO_FRANçOIS";

        if (!Directory.Exists(_path))
        {
            // Try to create the directory.
            DirectoryInfo di = Directory.CreateDirectory(_path);
        }

        Instantiate(myCamera);
      /*      
        foreach (Spot sp in shotSpots)
        {
            myCamera.transform.position = sp.position;
            myCamera.transform.eulerAngles = sp.angle;

            Debug.Log("Taking Screenshot" + sp.position );

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


            File.WriteAllBytes(_path, bytes);
            Debug.Log(string.Format("Took screenshot to: {position}", "Screennnn" + sp.position));
        }

       

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

        
       // string filename = ScreenShotName(resWidthN, resHeightN);


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
