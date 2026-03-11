using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text velocidadeTexto;
    public Rigidbody carroRigidbody;

    void Update()
    {
        float velocidade = carroRigidbody.velocity.magnitude * 3.6f; // m/s → km/h
        velocidadeTexto.text = "Velocidade: " + velocidade.ToString("F1") + " km/h";
    }
}
