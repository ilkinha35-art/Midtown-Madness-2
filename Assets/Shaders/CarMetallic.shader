Shader "Custom/CarMetallic"
{
    Properties
    {
        _Color ("Cor Principal", Color) = (1,1,1,1)
        _Glossiness ("Brilho", Range(0,1)) = 0.6
        _Metallic ("Metal", Range(0,1)) = 0.8
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        #pragma surface surf Standard fullforwardshadows

        struct Input
        {
            float2 uv_MainTex;
        };

        half _Glossiness;
        half _Metallic;
        fixed4 _Color;

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            // Define a cor do carro
            o.Albedo = _Color.rgb;

            // Define o nível de metal e brilho
            o.Metallic = _Metallic;
            o.Smoothness = _Glossiness;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
