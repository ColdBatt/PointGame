namespace DotGame;

partial class GameWindow
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
        ButtonLogin = new Button();
        NameInput = new TextBox();
        Users = new ListBox();
        label1 = new Label();
        SuspendLayout();
        // 
        // ButtonLogin
        // 
        ButtonLogin.Location = new Point(341, 202);
        ButtonLogin.Name = "ButtonLogin";
        ButtonLogin.Size = new Size(75, 23);
        ButtonLogin.TabIndex = 0;
        ButtonLogin.Text = "Войти";
        ButtonLogin.UseVisualStyleBackColor = true;
        ButtonLogin.Click += Login;
        // 
        // NameInput
        // 
        NameInput.Location = new Point(314, 161);
        NameInput.Name = "NameInput";
        NameInput.Size = new Size(127, 23);
        NameInput.TabIndex = 2;
        // 
        // Users
        // 
        Users.FormattingEnabled = true;
        Users.ItemHeight = 15;
        Users.Location = new Point(667, 18);
        Users.Name = "Users";
        Users.Size = new Size(120, 289);
        Users.TabIndex = 3;
        // 
        // Lab
        // 
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(93, 53);
        label1.Name = "label1";
        label1.Size = new Size(38, 15);
        label1.TabIndex = 4;
        label1.Text = "label1";
        // 
        // GameWindow
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(818, 335);
        Controls.Add(label1);
        Controls.Add(Users);
        Controls.Add(NameInput);
        Controls.Add(ButtonLogin);
        Margin = new Padding(2, 2, 2, 2);
        Name = "GameWindow";
        Text = "Игра в точку";
        MouseDown += GameWindow_MouseDown;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button ButtonLogin;
    private TextBox NameInput;
    private ListBox Users;
    private Label label1;
}