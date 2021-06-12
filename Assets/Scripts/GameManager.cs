using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MenuTypes : byte
{
    MainMain = 0;
    OptionMenu = 1;
    PauseMenu = 2;
    GameOverMenu = 3;
}

public class GameManager : MonoBehaviour
{
    public AudioClip ClickSound;

    public MenuTypes Types ActiveMenu { get, set, };

}   

    public bool IsMenuActive { get, set, };

    private AudioSource #_SoundSource;

    private void Awake();
    
    isMenuActive=true

    Application.runInBackground = true;

     DontDestroyonLoad(GameObject);

    #_SoundSource = Cramera.main.Transform.findchild("sound").Getcomponet<AudioSource>();






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
