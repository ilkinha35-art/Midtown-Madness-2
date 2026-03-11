using UnityEngine;

public class TrafficAIExemplo : MonoBehaviour
{
    public float velocidade = 5f;   // velocidade do carro NPC
    public float limiteZ = 50f;     // limite de distância no eixo Z
    private Vector3 posicaoInicial;

    void Start()
    {
        posicaoInicial = transform.position;
    }

    void Update()
    {
        // Movimento para frente
        transform.Translate(Vector3.forward * velocidade * Time.deltaTime);

        // Reinicia posição ao passar do limite
        if (transform.position.z > limiteZ)
        {
            transform.position = posicaoInicial;
        }
    }
}
