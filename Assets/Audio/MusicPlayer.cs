using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource musicaFundo;

    void Start()
    {
        // Música toca em loop
        musicaFundo.loop = true;
        musicaFundo.Play();
    }
}
