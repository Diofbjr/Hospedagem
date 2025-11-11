# 🏨 Sistema de Hospedagem em C#

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Status](https://img.shields.io/badge/STATUS-CONCLUÍDO-brightgreen?style=for-the-badge)
![License](https://img.shields.io/badge/LICENSE-MIT-blue?style=for-the-badge)

---

## 📋 Sobre o Projeto

Este projeto foi desenvolvido como parte de um **desafio da Digital Innovation One (DIO)**, com o objetivo de aplicar os fundamentos da **Programação Orientada a Objetos (POO)** utilizando **C# e .NET**.

O sistema simula o funcionamento básico de uma **hospedagem**, permitindo:
- Cadastrar hóspedes;
- Atribuir uma suíte;
- Calcular o valor total da estadia, com desconto automático para reservas acima de 10 dias.

---

## 🧠 Conceitos Aplicados

- 🧩 **Classes e Objetos**
- 🔒 **Encapsulamento**
- 🏷️ **Propriedades e Construtores**
- 📦 **Coleções genéricas (`List<T>`)**
- 💰 **Cálculos com desconto**
- 🧾 **Boas práticas de modelagem de domínio**

---

## ⚙️ Funcionalidades

✅ Cadastrar hóspedes  
✅ Cadastrar suíte  
✅ Calcular valor total da diária  
✅ Aplicar desconto de 10% para reservas acima de 10 dias  
✅ Obter quantidade total de hóspedes  

---

## 🏗️ Estrutura do Projeto

```bash
📦 Hospedagem
├── 📁 Models
│   ├── Pessoa.cs
│   ├── Suite.cs
│   └── Reserva.cs
└── Program.cs
```


---

## 💻 Tecnologias Utilizadas

| Tecnologia | Descrição |
|-------------|------------|
| 🧠 **C#** | Linguagem principal do projeto |
| ⚙️ **.NET 8.0** | Framework para execução e compilação |
| 🖥️ **Console Application** | Interface simples para testes |
| 🧮 **List<T>** | Armazenamento e controle de hóspedes |

---

## 🚀 Como Executar o Projeto

1. **Clone o repositório**
   ```bash
   git clone https://github.com/Diofbjr/Hospedagem.git
   cd Hospedagem


2. **Restaure (opcional)**
    dotnet restore


3. **Execute**
    dotnet run


🧩 Exemplo de Uso
🧍‍♂️ Código principal (Program.cs):

using Hospedagem.Models;

List<Pessoa> hospedes = new()
{
    new Pessoa("Diogo"),
    new Pessoa("Lucas")
};

Suite suite = new("Premium", 2, 150);

Reserva reserva = new(12);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor total da diária: {reserva.CalcularValorDiaria():C}");


💡 Saída esperada:
Hóspedes: 2
Valor total da diária: R$ 1.620,00

|💬 O desconto de 10% é aplicado automaticamente em reservas com mais de 10 dias.

👨‍💻 Autor

Desenvolvido por Diogo de França

📚 Projeto do Bootcamp da Digital Innovation One (DIO)

🏅 Licença

Este projeto está sob a licença MIT — sinta-se livre para usar e modificar.

MIT License © 2025 Diogo de França


✨ “Aprender é transformar lógica em prática, linha por linha.” 💻
