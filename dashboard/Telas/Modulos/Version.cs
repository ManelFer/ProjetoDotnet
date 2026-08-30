using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MeuPrograma;

public partial class DashboardForm
{
    private void ShowVersionHistory()
    {
        var repository = CreateVersionRepository();
        var updatesData = repository.GetUpdates();

        var container = new Panel
        {
            Dock = DockStyle.Fill,
            BackColor = BgCanvas,
            Padding = new Padding(40)
        };

        var title = new Label
        {
            Dock = DockStyle.Top,
            Height = 48,
            Text = "Atualizações do sistema",
            Font = FontTitle,
            ForeColor = TextPrimary
        };

        var updates = CreateUpdatesPanel(updatesData);

        var backButton = CreateBackButton();
        backButton.Dock = DockStyle.Bottom;

        container.Controls.Add(updates);
        container.Controls.Add(title);
        container.Controls.Add(backButton);

        ShowPage(container);
    }

    private static FlowLayoutPanel CreateUpdatesPanel(IReadOnlyList<VersionUpdate> updates)
    {
        var updatesPanel = new FlowLayoutPanel
        {
            Dock = DockStyle.Fill,
            AutoScroll = true,
            FlowDirection = FlowDirection.TopDown,
            WrapContents = false,
            Padding = new Padding(0, 12, 0, 20),
            BackColor = BgCanvas
        };

        if (updates.Count == 0)
        {
            updatesPanel.Controls.Add(new Label
            {
                AutoSize = true,
                Text = "Nenhuma atualização registrada.",
                Font = FontSubtitle,
                ForeColor = TextSecondary,
                Margin = new Padding(0, 12, 0, 0)
            });
            return updatesPanel;
        }

        foreach (var update in updates)
            updatesPanel.Controls.Add(CreateUpdateCard(update));

        return updatesPanel;
    }

    private static IVersionRepository CreateVersionRepository()
    {
        var filePath = Path.Combine(
            AppContext.BaseDirectory,
            "dashboard",
            "Data",
            "Json",
            "updates.json");

        return new JsonVersionRepository(filePath);
    }

    private static Panel CreateUpdateCard(VersionUpdate update)
    {
        var card = new Panel
        {
            Width = 700,
            AutoSize = true,
            MinimumSize = new Size(500, 0),
            BackColor = BgCard,
            Padding = new Padding(18, 14, 18, 14),
            Margin = new Padding(0, 0, 0, 16)
        };

        var version = new Label
        {
            Dock = DockStyle.Top,
            AutoSize = true,
            Text = update.Version,
            Font = new Font("Segoe UI", 13F, FontStyle.Bold),
            ForeColor = TextPrimary
        };

        var date = new Label
        {
            Dock = DockStyle.Top,
            AutoSize = true,
            Text = update.Date,
            Font = new Font("Segoe UI", 9F),
            ForeColor = TextSecondary,
            Padding = new Padding(0, 3, 0, 10)
        };

        var changes = new Label
        {
            Dock = DockStyle.Top,
            AutoSize = true,
            Text = string.Join("\n", update.Changes.Select(change => $"• {change}")),
            Font = FontSubtitle,
            ForeColor = TextSecondary
        };

        card.Controls.Add(changes);
        card.Controls.Add(date);
        card.Controls.Add(version);
        card.Paint += (_, e) =>
        {
            ControlPaint.DrawBorder(
                e.Graphics,
                card.ClientRectangle,
                Color.FromArgb(37, 99, 235),
                ButtonBorderStyle.Solid
            );
        };

        return card;
    }
}
