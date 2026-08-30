namespace MeuPrograma;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnEntrar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
        {
            MessageBox.Show("Preencha o usuário e a senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (txtUsuario.Text == "admin" && txtSenha.Text == "1234")
        {
            var dashboard = new DashboardForm(txtUsuario.Text);
            dashboard.FormClosed += (_, _) => Close();
            Hide();
            dashboard.Show();
            return;
        }

        MessageBox.Show("Usuário ou senha inválidos.", "Falha no login", MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtSenha.Clear();
        txtSenha.Focus();
    }

    private void chkMostrarSenha_CheckedChanged(object sender, EventArgs e)
    {
        txtSenha.UseSystemPasswordChar = !chkMostrarSenha.Checked;
    }
}
