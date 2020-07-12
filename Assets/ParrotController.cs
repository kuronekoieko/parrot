using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParrotController : MonoBehaviour
{
    UniGifImage uniGifImage;
    bool isPlay;
    void Start()
    {
        uniGifImage = GetComponent<UniGifImage>();
    }

    public void OnClick()
    {
        if (isPlay)
        {
            uniGifImage.Clear();
        }
        else
        {
            uniGifImage.Play();
        }
        isPlay = !isPlay;
    }
}
