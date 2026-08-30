using System;
using System.Drawing;
using System.Windows.Forms;

namespace MeuPrograma;

public partial class DashboardForm
{
    private void AddToolCard(
        Control parent,
        string title,
        string description,
        Color accentColor,
        EventHandler onClick)
    {
        var card = new Panel
        {
            Width = 280,
            Height = 145,
            Margin = new Padding(0, 0, 18, 18),
            BackColor = BgCard,
            Cursor = Cursors.Hand
        };

        var accentStripe = new Panel
        {
            Dock = DockStyle.Left,
            Width = 5,
            BackColor = accentColor
        };

        var content = new Panel
        {
            Dock = DockStyle.Fill,
            Padding = new Padding(18, 15, 16, 15),
            BackColor = BgCard
        };

        var lblTitle = new Label
        {
            Dock = DockStyle.Top,
            Height = 36,
            Text = title,
            Font = FontCardTitle,
            ForeColor = TextPrimary,
            AutoEllipsis = true
        };

        var lblDescription = new Label
        {
            Dock = DockStyle.Fill,
            Text = description,
            Font = FontCardDescription,
            ForeColor = TextSecondary,
            AutoSize = false
        };

        content.Controls.Add(lblDescription);
        content.Controls.Add(lblTitle);
        card.Controls.Add(content);
        card.Controls.Add(accentStripe);

        ConfigureCardEvents(card, accentStripe, content, lblTitle, lblDescription, onClick);

        card.Paint += (_, e) =>
        {
            ControlPaint.DrawBorder(
                e.Graphics,
                card.ClientRectangle,
                BorderColor,
                ButtonBorderStyle.Solid
            );
        };

        parent.Controls.Add(card);
    }

    private void ConfigureCardEvents(
        Panel card,
        Panel accentStripe,
        Panel content,
        Label title,
        Label description,
        EventHandler? onClick)
    {
        void Enter()
        {
            card.BackColor = BgHover;
            content.BackColor = BgHover;
        }

        void Leave()
        {
            if (!card.ClientRectangle.Contains(card.PointToClient(Cursor.Position)))
            {
                card.BackColor = BgCard;
                content.BackColor = BgCard;
            }
        }

        void Click(object? sender, EventArgs e)
        {
            onClick?.Invoke(sender, e);
        }

        foreach (Control control in new Control[]
        {
            card,
            accentStripe,
            content,
            title,
            description
        })
        {
            control.Cursor = Cursors.Hand;
            control.MouseEnter += (_, _) => Enter();
            control.MouseLeave += (_, _) => Leave();

            if (onClick != null)
                control.Click += Click;
        }
    }
}
