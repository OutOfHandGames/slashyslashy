using UnityEngine;
using System.Collections;

public class SoundScripts : MonoBehaviour {
    public AudioSource aSource;//If not set, will attempt to grab an audio source component to the gameobject this script is attached to
    public AudioClip[] aClips;//If you want an audio cue to have multiple possible sounds add them here
    public float[] aClipChance;//If you just want an equal chance for all sounds, leave this blank. Or don't. I'm not the police.

    public float minVol;//Pretty obvious. Useful if you don't want your sounds to be super monotonous
    public float maxVol;
    public float minPitch;
    public float maxPitch;

    float delayTimer = 0;

    void Start()
    {
        if (aSource == null)
        {
            aSource = GetComponent<AudioSource>();
        }
    }

    void Update()
    {
        
    }

    public void playSound()
    {
        aSource.Stop();
        aSource.Play();
    }

    public void playSoundDelay(float timeDelay)
    {
        delayTimer = timeDelay;
    }

    public void playRandomSound()
    {
        aSource.Stop();
        setPitch(Random.Range(minPitch, maxPitch));
        setVolume(Random.Range(minVol, maxVol));
        setClip(getRandomClip());

    }

    int getRandomClip()
    {
        float chance = Random.Range(0f, 1f);
        int clipChoice = 0;
        float currentChanceCheck = 0;
        foreach (float i in aClipChance)
        {
            currentChanceCheck += i;
            if (chance < currentChanceCheck)
            {
                return clipChoice;
            }
            clipChoice++;
        }
        return 0;
    }

    void normalizeAClipChance()
    {
        if (aClipChance == null || aClipChance.Length == 0)
        {
            aClipChance = new float[aClips.Length];
            for (int i = 0; i < aClipChance.Length; i++)
            {
                aClipChance[i] = 1f / aClipChance.Length;
            }
            return;
        }
        float total = 0;
        foreach (float i in aClipChance)
        {
            total += i;
        }

        for (int i = 0; i < aClipChance.Length; i++)
        {
            aClipChance[i] = aClipChance[i] / total;
        }

    }

    public void setPitch(float pitch)
    {
        aSource.pitch = pitch;
    }

    public void setVolume(float volume)
    {
        aSource.volume = volume;
    }

    public void setClip(int clipSelected)
    {
        aSource.clip = aClips[Mathf.Abs(clipSelected) % aClips.Length];
    }
}
