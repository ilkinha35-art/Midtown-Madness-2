# Midtown Clone - Arquitetura

Este documento descreve a arquitetura técnica do projeto **Midtown Clone**.

---

## 🏗️ Estrutura Geral
O projeto está dividido em três principais camadas:

1. **Apresentação (UI/HUD)**
   - Menus de jogo (início, seleção de carro, opções)
   - HUD durante a corrida (velocímetro, cronômetro, posição)

2. **Lógica de Jogo**
   - Gerenciamento de modos de corrida (tempo, adversários, exploração)
   - Controle de veículos (jogador e NPCs)
   - Sistema de tráfego e IA básica

3. **Recursos (Assets)**
   - Modelos 3D dos carros e da cidade
   - Sons (motor, colisões, música)
   - Texturas e materiais

---

## 📂 Estrutura de Pastas
midtown-clone/
├── Assets/        # recursos visuais e sonoros
├── Scripts/       # código do jogo
│    ├── CarController.cs
│    ├── TrafficAI.cs
│    ├── GameManager.cs
│    └── UIManager.cs
├── Docs/          # documentação e design
│    ├── design.md
│    ├── arquitetura.md
│    └── exemplos/

---

## 🔧 Componentes Principais
- **CarController**: controla aceleração, direção, freio e colisões do carro do jogador.
- **TrafficAI**: define comportamento dos carros NPC (trajetórias simples, evitar colisões).
- **GameManager**: gerencia regras de corrida, cronômetro e estados do jogo.
- **UIManager**: controla menus e HUD.

---

## 📐 Padrões de Código
- **Organização em Classes**: cada funcionalidade principal terá sua própria classe/script.
- **Separação de Responsabilidades**: lógica de jogo separada da interface e dos recursos.
- **Uso de Prefabs (Unity) ou Scenes (Godot)**: para facilitar reutilização de objetos.

---

## 🔮 Próximos Passos
1. Implementar protótipo de movimentação básica (CarController).
2. Criar cena inicial com mapa simples.
3. Adicionar sistema de tráfego NPC.
4. Integrar HUD com informações de corrida.

---

## ⚠️ Nota
Este projeto é apenas uma recriação **inspirada** em Midtown Madness 2.  
Todos os direitos do jogo original pertencem à Microsoft.
