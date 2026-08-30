using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MeuPrograma;

public partial class DashboardForm
{
    private void ShowComingSoon(string module)
    {
        var container = new Panel
        {
            Dock = DockStyle.Fill,
            BackColor = BgCanvas,
            Padding = new Padding(40)
        };

        var center = new Panel
        {
            Width = 500,
            Height = 260,
            Anchor = AnchorStyles.None,
            BackColor = BgCard
        };

        var icon = new Label
        {
            Dock = DockStyle.Top,
            Height = 70,
            Image = LoadToolImage(),
            TextAlign = ContentAlignment.MiddleCenter
        };

        var title = new Label
        {
            Dock = DockStyle.Top,
            Height = 40,
            Text = $"Módulo de {module}",
            Font = new Font("Segoe UI", 16F, FontStyle.Bold),
            ForeColor = TextPrimary,
            TextAlign = ContentAlignment.MiddleCenter
        };

        var description = new Label
        {
            Dock = DockStyle.Top,
            Height = 75,
            Text = "Esta funcionalidade está em desenvolvimento e estará disponível em breve.",
            Font = new Font("Segoe UI", 10.5F),
            ForeColor = TextSecondary,
            TextAlign = ContentAlignment.MiddleCenter
        };

        center.Controls.Add(description);
        center.Controls.Add(title);
        center.Controls.Add(icon);
        container.Controls.Add(center);

// backButton é a função para voltar
        var backButton = CreateBackButton();
        backButton.Anchor = AnchorStyles.Bottom;
        container.Controls.Add(backButton);

        PositionModuleControls(container, center, backButton);
        container.Resize += (_, _) => PositionModuleControls(container, center, backButton);

        ShowPage(container);
    }

    private static void PositionModuleControls(Panel container, Panel center, Button backButton)
    {
        center.Left = (container.ClientSize.Width - center.Width) / 2;
        center.Top = (container.ClientSize.Height - center.Height) / 2;
        backButton.Left = (container.ClientSize.Width - backButton.Width) / 2;
        backButton.Top = container.ClientSize.Height - backButton.Height;
    }

    private static Image LoadToolImage()
    {
        var imagePath = Path.Combine(
            AppContext.BaseDirectory,
            "Resources",
            "AppIcon",
            "ferramentas.png");

        using var stream = File.OpenRead(imagePath);
        return new Bitmap(stream);
    }
}
