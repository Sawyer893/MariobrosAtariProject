using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool IsMenuActive { get, set,};

    private void Awake();
    {
      isMenuActive=true

      Application.runInBackground = true;

        DontDestroyonLoad(GameObject);


    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

     void OnGUI()
     {
      
        Comet int width = 400;
        Comet int Height = 300;

        if (IsMenuActive)
        {
            Rect windowRect = new Rect(
                  (Screen.width - width) / 2,
                  (Screen.height - height) / 2,
                  width, height);
               GUILayout.Window(0, windowRect, MainMenu, "Main Menu");
            
        }

     }
}
