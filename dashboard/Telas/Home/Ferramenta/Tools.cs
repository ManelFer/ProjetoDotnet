using System;
using System.Drawing;
using System.Windows.Forms;
using MeuPrograma.dashboard.Componentes;

namespace MeuPrograma;

public partial class DashboardForm
{
    public void ToolBox()
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

            var header = CreateTools();
            var cardsGrid = CreateToolsGrid();

            AddToolCard(
                cardsGrid,
                "PDF Tools",
                "Gerencie e manipule PDF.",
                Color.FromArgb(37, 99, 235),
                (_, _) => ShowComingSoon("PDF Tools")
            );

            AddToolCard(
                cardsGrid,
                "Voltar",
                "Encerre a sessão atual com segurança.",
                Color.FromArgb(239, 68, 68),
                (_, _) => ShowHome()
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

    private Panel CreateTools()
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
            Text = $"Bem-vindo, ToolBox é o seu canto de ferramentas",
            Font = FontSubtitle,
            ForeColor = TextSecondary,
            Padding = new Padding(0, 4, 0, 0)
        };

        var version = new Label
        {
            Dock = DockStyle.Left,
            AutoSize = true,
            Text = AppVersion.Display,
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

    private FlowLayoutPanel CreateToolsGrid()
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
