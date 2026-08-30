# ProjetoDotnet

Documentação oficial do repositório **ProjetoDotnet**, desenvolvido por **ManelFer** (Manoel Ferreira Matos). Este projeto consiste em uma aplicação desktop desenvolvida na plataforma .NET utilizando a linguagem C#.

---

## 📋 Visão Geral

O **ProjetoDotnet** é uma aplicação desktop baseada em **Windows Forms** escrita 100% em C#. A estrutura do repositório indica o desenvolvimento de uma interface gráfica contendo um painel de controle (dashboard) e recursos visuais personalizados.

### Informações do Repositório
* **Autor:** Manoel Ferreira Matos (ManelFer)
* **Linguagem Principal:** C# (100%)
* **Plataforma:** .NET (Windows Forms)
* **Licença/Releases:** Nenhuma release publicada ou licença explicitada no momento.

---

## 📂 Estrutura de Arquivos e Pastas

A organização de pastas e componentes estruturais do projeto é detalhada a seguir:

```text
ProjetoDotnet/
├── .gitignore
├── Form1.cs
├── Form1.Designer.cs
├── MeuPrograma.csproj
├── Program.cs
├── Resources/
│   └── AppIcon/
└── dashboard/
```

### Detalhamento dos Componentes

#### 1. Arquivos de Inicialização e Configuração
* **`MeuPrograma.csproj`**: Arquivo de definição do projeto .NET, responsável por gerenciar dependências, referências e configurações de compilação da aplicação.
* **`Program.cs`**: Contém o ponto de entrada principal (`static void Main`) que inicializa a execução do aplicativo.
* **`.gitignore`**: Arquivo de configuração que instrui o Git sobre quais arquivos e diretórios temporários ou de build (como as pastas `bin/` e `obj/`) devem ser ignorados no versionamento.

#### 2. Interface do Usuário (UI)
* **`Form1.cs`**: Arquivo que contém a lógica de controle e eventos da janela principal (Form) do aplicativo, escrito em C#.
* **`Form1.Designer.cs`**: Código gerado automaticamente pelo designer visual do Visual Studio, responsável por instanciar e posicionar os componentes gráficos da interface (botões, painéis, caixas de texto, etc.).

#### 3. Módulos e Recursos Específicos
* **`dashboard/`**: Diretório dedicado à lógica ou visualizações do painel de controle principal da aplicação (Dashboard).
* **`Resources/AppIcon/`**: Pasta que armazena os ativos visuais e o ícone de aplicativo personalizado do programa desktop.

---

## 🛠️ Tecnologias e Dependências

Com base no ecossistema .NET, a aplicação utiliza as seguintes tecnologias fundamentais:
* **C#**: Linguagem orientada a objetos moderna e com tipagem segura, utilizada para todo o desenvolvimento lógico da aplicação.
* **Windows Forms**: Framework do .NET usado para criar aplicativos de área de trabalho (desktop) com uma interface gráfica rica e interativa para Windows.

---

## 🚀 Como Executar o Projeto

Para executar este projeto localmente em sua máquina de desenvolvimento, siga os passos abaixo:

### Pré-requisitos
* **SDK do .NET** compatível instalado em sua máquina.
* Uma IDE como **Visual Studio**, **Visual Studio Code** ou **JetBrains Rider**.

### Passos para Compilação e Execução
1. Clone este repositório para o seu ambiente local:
   ```bash
   git clone https://github.com/ManelFer/ProjetoDotnet.git
   ```
2. Navegue até o diretório do projeto:
   ```bash
   cd ProjetoDotnet
   ```
3. Restaure as dependências e compile o projeto utilizando o terminal CLI do .NET:
   ```bash
   dotnet build
   ```
4. Execute o programa:
   ```bash
   dotnet run
   ```

---

*Documentação gerada com base nos metadados estruturais do repositório ProjetoDotnet (2026).*
