namespace MeuPrograma;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        lblTitulo = new Label();
        lblUsuario = new Label();
        txtUsuario = new TextBox();
        lblSenha = new Label();
        txtSenha = new TextBox();
        chkMostrarSenha = new CheckBox();
        btnEntrar = new Button();
        lblAjuda = new Label();
        SuspendLayout();
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitulo.Location = new Point(285, 65);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(190, 37);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Meu sistema teste";
        // 
        // lblUsuario
        // 
        lblUsuario.AutoSize = true;
        lblUsuario.Location = new Point(250, 135);
        lblUsuario.Name = "lblUsuario";
        lblUsuario.Size = new Size(50, 15);
        lblUsuario.TabIndex = 1;
        lblUsuario.Text = "Usuário";
        // 
        // txtUsuario
        // 
        txtUsuario.Location = new Point(250, 163);
        txtUsuario.Name = "txtUsuario";
        txtUsuario.PlaceholderText = "Digite seu usuário";
        txtUsuario.Size = new Size(300, 23);
        txtUsuario.TabIndex = 2;
        // 
        // lblSenha
        // 
        lblSenha.AutoSize = true;
        lblSenha.Location = new Point(250, 195);
        lblSenha.Name = "lblSenha";
        lblSenha.Size = new Size(39, 15);
        lblSenha.TabIndex = 3;
        lblSenha.Text = "Senha";
        // 
        // txtSenha
        // 
        txtSenha.Location = new Point(250, 223);
        txtSenha.Name = "txtSenha";
        txtSenha.PlaceholderText = "Digite sua senha";
        txtSenha.Size = new Size(300, 23);
        txtSenha.TabIndex = 4;
        txtSenha.UseSystemPasswordChar = true;
        // 
        // chkMostrarSenha
        // 
        chkMostrarSenha.AutoSize = true;
        chkMostrarSenha.Location = new Point(250, 258);
        chkMostrarSenha.Name = "chkMostrarSenha";
        chkMostrarSenha.Size = new Size(108, 19);
        chkMostrarSenha.TabIndex = 5;
        chkMostrarSenha.Text = "Mostrar senha";
        chkMostrarSenha.UseVisualStyleBackColor = true;
        chkMostrarSenha.CheckedChanged += chkMostrarSenha_CheckedChanged;
        // 
        // btnEntrar
        // 
        btnEntrar.Location = new Point(250, 301);
        btnEntrar.Name = "btnEntrar";
        btnEntrar.Size = new Size(300, 35);
        btnEntrar.TabIndex = 6;
        btnEntrar.Text = "Entrar";
        btnEntrar.UseVisualStyleBackColor = true;
        btnEntrar.Click += btnEntrar_Click;
        // 
        // lblAjuda
        // 
        lblAjuda.AutoSize = true;
        lblAjuda.ForeColor = SystemColors.GrayText;
        lblAjuda.Location = new Point(250, 355);
        lblAjuda.Name = "lblAjuda";
        lblAjuda.Size = new Size(300, 15);
        lblAjuda.TabIndex = 7;
        lblAjuda.Text = "Use admin / 1234 para testar";
        lblAjuda.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // Form1
        // 
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(lblAjuda);
        Controls.Add(btnEntrar);
        Controls.Add(chkMostrarSenha);
        Controls.Add(txtSenha);
        Controls.Add(lblSenha);
        Controls.Add(txtUsuario);
        Controls.Add(lblUsuario);
        Controls.Add(lblTitulo);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Login";
        AcceptButton = btnEntrar;
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitulo;
    private Label lblUsuario;
    private TextBox txtUsuario;
    private Label lblSenha;
    private TextBox txtSenha;
    private CheckBox chkMostrarSenha;
    private Button btnEntrar;
    private Label lblAjuda;

    #endregion
}
