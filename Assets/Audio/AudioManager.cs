using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource motorSom;
    public AudioSource colisaoSom;
    public Rigidbody carroRigidbody;

    void Update()
    {
        // Ajusta o tom do motor conforme a velocidade
        float velocidade = carroRigidbody.velocity.magnitude;
        motorSom.pitch = 1f + (velocidade / 50f);
    }

    void OnCollisionEnter(Collision colisao)
    {
        // Toca som de colisão ao bater
        colisaoSom.Play();
    }
}
