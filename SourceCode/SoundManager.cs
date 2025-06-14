using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SoundManager", menuName = "ScriptableObjects/SoundManager")]
public class SoundManager : ScriptableObject
{
    [System.Serializable]
    public class SoundList
    {
        [Header("サウンドの種類(BGMまたはSE")]
        public string soundName;
        [Header("対応する音")]
        public AudioClip audioClip;

        public SoundList(string musicName, AudioClip sound)
        {
            this.soundName = musicName;
            this.audioClip = sound;
        }
    }
    public List<SoundList> soundLists = new List<SoundList>();
}
