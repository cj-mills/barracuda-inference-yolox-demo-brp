using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHelper : MonoBehaviour
{
    [SerializeField] InferenceController inferenceController;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// OnRenderImage is called after the Camera had finished rendering 
    /// </summary>
    /// <param name="src">Input from the Camera</param>
    /// <param name="dest">The texture for the targer display</param>
    void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        Graphics.Blit(src, dest);


        inferenceController.UpdateCameraTexture(src);
    }
}
