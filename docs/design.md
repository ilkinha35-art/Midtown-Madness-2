# Midtown Clone - Design Document

Este documento descreve as ideias iniciais de gameplay e a arquitetura do código para o projeto **Midtown Clone**.

---

## 🎮 Gameplay
- **Objetivo principal:** Corridas em mundo aberto, com possibilidade de explorar livremente a cidade.
- **Modos de jogo:**
  - Corrida contra o tempo
  - Corrida contra adversários
  - Exploração livre
- **Carros:**
  - Diferentes modelos com variação de velocidade, aceleração e resistência
  - Sistema de dano visual simples (carro amassado, fumaça)
- **Cidade:**
  - Ruas principais, cruzamentos e áreas abertas
  - Tráfego de NPCs com comportamento básico
  - Pontos de interesse (praças, pontes, avenidas largas)

---

## 🛠️ Estrutura do Código
- **Scripts/CarController.cs**
  - Responsável pela movimentação do carro (aceleração, freio, direção)
- **Scripts/TrafficAI.cs**
  - Controla veículos NPC (trajetórias simples, evitar colisões)
- **Scripts/GameManager.cs**
  - Gerencia modos de jogo, cronômetro e regras de corrida
- **Scripts/UIManager.cs**
  - Interface gráfica: menus, HUD de velocidade e tempo

---

## 📂 Organização
Docs/
├── design.md        # ideias de gameplay e arquitetura
├── arquitetura.md   # detalhes técnicos da engine e padrões de código
└── exemplos/        # pequenos trechos de código comentados

---

## 🔮 Próximos Passos
1. Criar protótipo de movimentação básica do carro.
2. Implementar mapa simples com ruas e colisões.
3. Adicionar tráfego NPC.
4. Criar interface de corrida com cronômetro.

---

## ⚠️ Nota
Este projeto é apenas uma recriação **inspirada** em Midtown Madness 2.  
Todos os direitos do jogo original pertencem à Microsoft.
