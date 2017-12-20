
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{


   public Camera myCaamara;
   public TakingScreenShot _takeScreenShot;
   List<Spot> mySpotList = new List<Spot>();

    //Spot myspot = new Spot();
    //     myspot.angle = new Vector3(0,0,0);
    //     myspot.position = new Vector3(0,2,0);
    //     mySpotList.Add(myspot);
    //     myspot.angle = new Vector3(1, 10, 5);
    //     myspot.position = new Vector3(10, 2, 20);
    //     mySpotList.Add(myspot);
    //     myspot.angle = new Vector3(5, 9, 47);
    //     myspot.position = new Vector3(9, 82, 70);
    //     mySpotList.Add(myspot);
    //     myspot.angle = new Vector3(7, 4, 2);
    //     myspot.position = new Vector3(58, 55, 4);
    //     mySpotList.Add(myspot);
    //     myspot.angle = new Vector3(0, 0, 4);
    //     myspot.position = new Vector3(89, 2, 0);
    //     mySpotList.Add(myspot);

    private void Start()
    {
       // _takeScreenShot = new TakingScreenShot();
       // myCaamara = new Camera();

        if(Input.GetMouseButtonDown(0))
        {
          //  _takeScreenShot.sc
          // _takeScreenShot.ScreenShot("C:/Users/student106/Pictures/Screen_DIDI_DIEGO_FRANçOIS");
          //  ScreenCapture.CaptureScreenshot("C:/Users/student106/Pictures/Screen_DIDI_DIEGO_FRANçOIS", 2);
        }
    }
}
