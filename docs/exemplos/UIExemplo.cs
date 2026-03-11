using UnityEngine;
using UnityEngine.UI;

public class UIExemplo : MonoBehaviour
{
    public Text velocidadeTexto;       // referência ao componente de texto
    public Rigidbody carroRigidbody;   // referência ao Rigidbody do carro

    void Update()
    {
        // Calcula a velocidade atual do carro
        float velocidade = carroRigidbody.velocity.magnitude * 3.6f; // m/s → km/h

        // Atualiza o texto na tela
        velocidadeTexto.text = "Velocidade: " + velocidade.ToString("F1") + " km/h";
    }
}
