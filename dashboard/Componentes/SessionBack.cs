using System.Windows.Forms;
using System.Drawing;

namespace MeuPrograma;


public partial class DashboardForm
{
    private Button CreateBackButton()
    {
        var backButton = new Button
        {
            Width = 160,
            Height = 42,
            Text = "Voltar",
            Font = new Font("Segoe UI", 10F, FontStyle.Bold),
            ForeColor = Color.White,
            BackColor = TextPrimary,
            FlatStyle = FlatStyle.Flat,
            Cursor = Cursors.Hand
        };

        backButton.FlatAppearance.BorderSize = 0;
        backButton.Click += (_, _) => ConfirmBack();
        return backButton;
    }

    private void ConfirmBack()
    {
        var result = MessageBox.Show(
            this,
            "Tem certeza de que deseja voltar?",
            "Confirmar retorno",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
            ShowHome();
    }
}