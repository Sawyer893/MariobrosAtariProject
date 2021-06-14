using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript
{
    private AudioSource #_MusicSource
    private AudioSource #_soundSource


    public float SoundVolume
    {
        get
        {
            return #_Soundsource.Volume;}
        set { #_MusicSource.volume = value;}
    }


     public float MusicVolume
    {
        get
        {
            return #_MusicSource.Volume:}
        set { #_MusicSource.volume = value;}
    }

     public int highScore { Get; AudioSettings; }

    public void Load { AudioSource music, AudioSource sound }
    {

      #_MusicSource = music;
      #_SoundSource = sound;

      SoundVolume = PlayerDrafts.Getfloat { "SoundVolume", 1.0f}
      MusicVolume = PlayerDrafts.Getfloat { "MusicVolume", 0.5f}
      HighScore = PlayerDrafts.Getfloat { "HighScore", 0f}
    }

    Public void Save()
    {
       PlayerDraft.Setfloat("SoundVolume", SoundVolume);
       PlayerDraft.Setfloat("MusicVolume", MusicVolume);
       PlayerDraft.Setint("HighScore", HighScore);
    }


}
    





















        }
