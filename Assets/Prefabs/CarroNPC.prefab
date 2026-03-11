using UnityEngine;

public class TrafficAI : MonoBehaviour
{
    public float velocidade = 5f;
    public float limiteZ = 50f;
    private Vector3 posicaoInicial;

    void Start()
    {
        posicaoInicial = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector3.forward * velocidade * Time.deltaTime);

        if (transform.position.z > limiteZ)
        {
            transform.position = posicaoInicial;
        }
    }
}
