using System;
using System.Drawing;
using System.Windows.Forms;

namespace MeuPrograma;

public partial class DashboardForm : Form
{
    #region Cores

    public static readonly Color BgCanvas =
        Color.FromArgb(248, 250, 252);

    public static readonly Color BgCard =
        Color.White;

    public static readonly Color BgHover =
        Color.FromArgb(241, 245, 249);

    public static readonly Color BorderColor =
        Color.FromArgb(226, 232, 240);

    public static readonly Color TextPrimary =
        Color.FromArgb(15, 23, 42);

    public static readonly Color TextSecondary =
        Color.FromArgb(100, 116, 139);

    #endregion

    #region Fontes

    private static readonly Font FontTitle =
        new("Segoe UI", 20F, FontStyle.Bold);

    private static readonly Font FontSubtitle =
        new("Segoe UI", 10.5F);

    private static readonly Font FontCardTitle =
        new("Segoe UI", 12F, FontStyle.Bold);

    private static readonly Font FontCardDescription =
        new("Segoe UI", 9.5F);

    #endregion

    private readonly string usuario;

    private Panel contentArea = null!;

    public DashboardForm(string usuario)
    {
        this.usuario = usuario;

        ConfigureRendering();
        ConfigureForm();
        BuildLayout();

        ShowHome();
    }

    #region Inicialização

    private void ConfigureRendering()
    {
        SetStyle(
            ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.UserPaint,
            true
        );

        UpdateStyles();
    }

    private void ConfigureForm()
    {
        Text = "Dashboard - Sistema de Gestão";
        StartPosition = FormStartPosition.CenterScreen;
        Size = new Size(1100, 700);
        MinimumSize = Size;
        MaximumSize = Size;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        BackColor = BgCanvas;
    }

    #endregion

    #region Layout

    private void BuildLayout()
    {
        contentArea = new Panel
        {
            Dock = DockStyle.Fill,
            Padding = new Padding(32),
            BackColor = BgCanvas,
            AutoScroll = true
        };

        Controls.Add(contentArea);
    }

    #endregion

    #region Navegação

    private void ShowPage(Control page)
    {
        contentArea.SuspendLayout();

        try
        {
            contentArea.Controls.Clear();
            page.Dock = DockStyle.Fill;
            contentArea.Controls.Add(page);
        }
        finally
        {
            contentArea.ResumeLayout(true);
        }
    }

    #endregion

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            FontTitle.Dispose();
            FontSubtitle.Dispose();
            FontCardTitle.Dispose();
            FontCardDescription.Dispose();
        }

        base.Dispose(disposing);
    }
}
