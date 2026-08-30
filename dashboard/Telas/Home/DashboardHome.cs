using System;
using System.Drawing;
using System.Windows.Forms;

namespace MeuPrograma;

public partial class DashboardForm
{
    public void ShowHome()
    {
        contentArea.SuspendLayout();

        try
        {
            contentArea.Controls.Clear();

            var container = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = BgCanvas
            };

            var header = CreateHeader();
            var cardsGrid = CreateCardsGrid();

            AddToolCard(
                cardsGrid,
                "Usuários",
                "Gerencie usuários, permissões e acessos.",
                Color.FromArgb(37, 99, 235),
                (_, _) => ShowComingSoon("Usuários")
            );

            AddToolCard(
                cardsGrid,
                "Relatórios",
                "Consulte relátorios das máquinas cadastradas",
                Color.FromArgb(16, 185, 129),
                (_, _) => ShowComingSoon("Relatórios")
            );

            AddToolCard(
                cardsGrid,
                "Infraestrutura",
                "Consultar localização dos computadores.",
                Color.FromArgb(239, 112, 68),
                (_, _) => ShowComingSoon("Infraestrutura")
            );

            AddToolCard(
                cardsGrid,
                "Ferramentas",
                "Consulte as ferramentas disponíveis.",
                Color.FromArgb(46, 2, 223),
                (_, _) => ShowComingSoon("Ferramentas")
            );

            AddToolCard(
                cardsGrid,
                "Configurações",
                "Ajuste preferências e parâmetros do sistema.",
                Color.FromArgb(245, 158, 11),
                (_, _) => ShowComingSoon("Configurações")
            );

            AddToolCard(
                cardsGrid,
                "Sair",
                "Encerre a sessão atual com segurança.",
                Color.FromArgb(239, 68, 68),
                (_, _) => ConfirmExit()
            );

            container.Controls.Add(cardsGrid);
            container.Controls.Add(header);
            contentArea.Controls.Add(container);
        }
        finally
        {
            contentArea.ResumeLayout(true);
        }
    }

    private Panel CreateHeader()
    {
        var header = new Panel
        {
            Dock = DockStyle.Top,
            Height = 125,
            BackColor = BgCanvas
        };

        var titleRow = new Panel
        {
            Dock = DockStyle.Top,
            Height = 48,
            BackColor = BgCanvas
        };

        var title = new Label
        {
            Dock = DockStyle.Left,
            AutoSize = true,
            Text = "Visão Geral",
            Font = FontTitle,
            ForeColor = TextPrimary
        };

        var subtitle = new Label
        {
            Dock = DockStyle.Top,
            Height = 45,
            Text = $"Bem-vindo, {usuario}! Verifique as atualizações de hoje.",
            Font = FontSubtitle,
            ForeColor = TextSecondary,
            Padding = new Padding(0, 4, 0, 0)
        };

        var version = new Label
        {
            Dock = DockStyle.Left,
            AutoSize = true,
            Text = "V1.0.0",
            Font = FontCardDescription,
            ForeColor = TextSecondary,
            Padding = new Padding(12, 14, 0, 0),
            Cursor = Cursors.Hand
        };
        version.Click += (_, _) => ShowVersionHistory();

        titleRow.Controls.Add(version);
        titleRow.Controls.Add(title);
        header.Controls.Add(subtitle);
        header.Controls.Add(titleRow);
        return header;
    }

    private FlowLayoutPanel CreateCardsGrid()
    {
        return new FlowLayoutPanel
        {
            Dock = DockStyle.Fill,
            AutoScroll = true,
            WrapContents = true,
            FlowDirection = FlowDirection.LeftToRight,
            Padding = new Padding(0, 12, 0, 20),
            BackColor = BgCanvas
        };
    }

}
