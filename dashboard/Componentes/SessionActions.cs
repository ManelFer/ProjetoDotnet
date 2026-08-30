using System.Windows.Forms;

namespace MeuPrograma;

public partial class DashboardForm
{
    private void ConfirmExit()
    {
        var result = MessageBox.Show(
            this,
            "Tem certeza de que deseja sair do sistema?",
            "Confirmar saída",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
            Close();
    }
}
