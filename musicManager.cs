using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicManager : MonoBehaviour
{
    public bool guitarCheck = true;
    public bool bassCheck;
    public bool vocal1Check;
    //public bool vocal2Check;
    public bool drumsCheck;
    public bool otherCheck;

    public AudioSource Guitar;
    public AudioSource Bass;
    public AudioSource Vocals1;
    //public AudioSource Vocals2;
    public AudioSource Drums;
    public AudioSource Other;

    //Every frame update. Plz make it not every frame that may cause problems in the future :3
    //I refuse to update it :P
    void Update()
    {
        //Guitar Checks
        if (guitarCheck == true)
        {
            Guitar.volume = 1;
        }
        else if (guitarCheck == false)
        {
            Guitar.volume = 0;
        }
        //Bass Checks
        if (bassCheck == true)
        {
            Bass.volume = 1;
        }
        else if (bassCheck == false)
        {
            Bass.volume = 0;
        }
        //Drums Checks
        if (drumsCheck == true)
        {
            Drums.volume = 1;
        }
        else if (drumsCheck == false)
        {
            Drums.volume = 0;
        }

        //Other Checks
        if (otherCheck == true)
        {
            Other.volume = 1;
        }
        else if (drumsCheck == false)
        {
            Other.volume = 0;
        }
        
        //Vocal Checks
        if (vocal1Check == true)
        {
            Vocals1.volume = 1;
        }
        else if (vocal1Check == false)
        {
            Vocals1.volume = 0;
        }

        //if (vocal2Check == true)
        //{
        //    Vocals2.volume = 1;
        //}
        //else if (vocal2Check == false)
        //{
        //    Vocals2.volume = 0;
        //}
    }
}
