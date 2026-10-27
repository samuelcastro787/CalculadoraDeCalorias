# 🧮 Calculadora de Calorias e Hidratação

Uma aplicação de console robusta desenvolvida em **C#** que ajuda o usuário a entender as necessidades energéticas do seu próprio corpo. O programa calcula a Taxa Metabólica Basal (TMB), o Gasto Energético Total Diário (GETD) e a quantidade ideal de água recomendada por dia baseado no perfil individual de cada pessoa.

---

## 📅 Datas do Projeto
* **Início do projeto:** 25/10/2026
* **Término do projeto:** 27/10/2026

---

## 🎯 Intuito do Projeto
O principal objetivo deste projeto foi aplicar conceitos consolidados de lógica de programação e POO (Programação Orientada a Objetos) em C#. 

A aplicação foca fortemente na **experiência do usuário (UX) no terminal**, garantindo que o programa nunca trave (crash) através de um sistema rigoroso de **tratamento de erros e validação de dados** (evitando falhas caso o usuário digite letras ou símbolos em campos numéricos).

---

## ⚙️ Como o Projeto Funciona

O fluxo do programa é simples, interativo e dividido em 3 etapas principais:

1. **Escolha do Objetivo:** Ao iniciar, o usuário se depara com um menu principal onde define sua meta: **Perder Peso**, **Ganhar Peso** ou **Manter o Peso**.
2. **Coleta de Dados:** O sistema solicita informações básicas de biometria e rotina:
   * Idade (anos)
   * Altura (cm)
   * Peso atual (kg)
   * Gênero (M/F)
   * Nível de atividade física (Sedentário, Levemente Ativo ou Ativo)
3. **Cálculo Matemático:** 
   * **Gasto calórico:** O sistema utiliza a fórmula científica de *Mifflin-St Jeor* para calcular o metabolismo de homens e mulheres separadamente, multiplicando o resultado pelo fator de atividade escolhido.
   * **Consumo Alvo:** Com base na meta do usuário, o programa calcula o déficit calórico (para perder peso), o superávit calórico (para ganhar peso) ou o equilíbrio de calorias.
   * **Hidratação:** Calcula a recomendação diária de água multiplicando o peso atual por um fator de 35ml a 40ml.

---

## 🚀 Tecnologias Utilizadas
* **Linguagem:** C#
* **Ambiente de Execução:** .NET Console Application
* **IDE:** Visual Studio Code

---

## 🔮 Melhorias Futuras
* [ ] Adicionar cálculo de calorias específico para os alimentos consumidos diariamente (diário de dieta).
* [ ] Criar uma interface gráfica (Web ou Desktop) para substituir o console.
* [ ] Implementar persistência de dados para salvar o histórico do usuário.
