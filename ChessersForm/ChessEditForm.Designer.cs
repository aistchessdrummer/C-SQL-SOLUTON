namespace ChessersForm
{
    partial class ChessEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label chesserDateBirthLabel;
            System.Windows.Forms.Label chesserLabel;
            System.Windows.Forms.Label chesserRaitingLabel;
            System.Windows.Forms.Label sexIDLabel;
            System.Windows.Forms.Label zvanRazIDLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chesserDateBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.chesserTextBox = new System.Windows.Forms.TextBox();
            this.chesserRaitingTextBox = new System.Windows.Forms.TextBox();
            this.chesserInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sexIDComboBox = new System.Windows.Forms.ComboBox();
            this.zvanRazIDComboBox = new System.Windows.Forms.ComboBox();
            this.sexlistbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zvanrazbindingSource = new System.Windows.Forms.BindingSource(this.components);
            chesserDateBirthLabel = new System.Windows.Forms.Label();
            chesserLabel = new System.Windows.Forms.Label();
            chesserRaitingLabel = new System.Windows.Forms.Label();
            sexIDLabel = new System.Windows.Forms.Label();
            zvanRazIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chesserInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexlistbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zvanrazbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(135, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chesserDateBirthLabel
            // 
            chesserDateBirthLabel.AutoSize = true;
            chesserDateBirthLabel.Location = new System.Drawing.Point(63, 104);
            chesserDateBirthLabel.Name = "chesserDateBirthLabel";
            chesserDateBirthLabel.Size = new System.Drawing.Size(89, 13);
            chesserDateBirthLabel.TabIndex = 8;
            chesserDateBirthLabel.Text = "Дата рождения:";
            // 
            // chesserDateBirthDateTimePicker
            // 
            this.chesserDateBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.chesserInfoBindingSource, "ChesserDateBirth", true));
            this.chesserDateBirthDateTimePicker.Location = new System.Drawing.Point(158, 104);
            this.chesserDateBirthDateTimePicker.Name = "chesserDateBirthDateTimePicker";
            this.chesserDateBirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.chesserDateBirthDateTimePicker.TabIndex = 9;
            // 
            // chesserLabel
            // 
            chesserLabel.AutoSize = true;
            chesserLabel.Location = new System.Drawing.Point(68, 55);
            chesserLabel.Name = "chesserLabel";
            chesserLabel.Size = new System.Drawing.Size(84, 13);
            chesserLabel.TabIndex = 9;
            chesserLabel.Text = "Фамилия Имя:";
            // 
            // chesserTextBox
            // 
            this.chesserTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chesserInfoBindingSource, "Chesser", true));
            this.chesserTextBox.Location = new System.Drawing.Point(158, 52);
            this.chesserTextBox.Name = "chesserTextBox";
            this.chesserTextBox.Size = new System.Drawing.Size(200, 20);
            this.chesserTextBox.TabIndex = 10;
            // 
            // chesserRaitingLabel
            // 
            chesserRaitingLabel.AutoSize = true;
            chesserRaitingLabel.Location = new System.Drawing.Point(37, 81);
            chesserRaitingLabel.Name = "chesserRaitingLabel";
            chesserRaitingLabel.Size = new System.Drawing.Size(115, 13);
            chesserRaitingLabel.TabIndex = 10;
            chesserRaitingLabel.Text = "Рейтинг шахматиста:";
            // 
            // chesserRaitingTextBox
            // 
            this.chesserRaitingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chesserInfoBindingSource, "ChesserRaiting", true));
            this.chesserRaitingTextBox.Location = new System.Drawing.Point(158, 78);
            this.chesserRaitingTextBox.Name = "chesserRaitingTextBox";
            this.chesserRaitingTextBox.Size = new System.Drawing.Size(69, 20);
            this.chesserRaitingTextBox.TabIndex = 11;
            // 
            // chesserInfoBindingSource
            // 
            this.chesserInfoBindingSource.DataSource = typeof(ChessersLibrary.ChesserInfo);
            // 
            // sexIDLabel
            // 
            sexIDLabel.AutoSize = true;
            sexIDLabel.Location = new System.Drawing.Point(122, 133);
            sexIDLabel.Name = "sexIDLabel";
            sexIDLabel.Size = new System.Drawing.Size(30, 13);
            sexIDLabel.TabIndex = 11;
            sexIDLabel.Text = "Пол:";
            // 
            // sexIDComboBox
            // 
            this.sexIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.chesserInfoBindingSource, "SexID", true));
            this.sexIDComboBox.DataSource = this.sexlistbindingSource;
            this.sexIDComboBox.DisplayMember = "Sex";
            this.sexIDComboBox.FormattingEnabled = true;
            this.sexIDComboBox.Location = new System.Drawing.Point(158, 130);
            this.sexIDComboBox.Name = "sexIDComboBox";
            this.sexIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.sexIDComboBox.TabIndex = 12;
            this.sexIDComboBox.ValueMember = "SexID";
            // 
            // zvanRazIDLabel
            // 
            zvanRazIDLabel.AutoSize = true;
            zvanRazIDLabel.Location = new System.Drawing.Point(63, 160);
            zvanRazIDLabel.Name = "zvanRazIDLabel";
            zvanRazIDLabel.Size = new System.Drawing.Size(89, 13);
            zvanRazIDLabel.TabIndex = 12;
            zvanRazIDLabel.Text = "Звание/Разряд:";
            // 
            // zvanRazIDComboBox
            // 
            this.zvanRazIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.chesserInfoBindingSource, "ZvanRazID", true));
            this.zvanRazIDComboBox.DataSource = this.zvanrazbindingSource;
            this.zvanRazIDComboBox.DisplayMember = "ZvanRaz";
            this.zvanRazIDComboBox.FormattingEnabled = true;
            this.zvanRazIDComboBox.Location = new System.Drawing.Point(158, 157);
            this.zvanRazIDComboBox.Name = "zvanRazIDComboBox";
            this.zvanRazIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.zvanRazIDComboBox.TabIndex = 13;
            this.zvanRazIDComboBox.ValueMember = "ZvanRazID";
            // 
            // sexlistbindingSource
            // 
            this.sexlistbindingSource.DataSource = typeof(ChessersLibrary.ChesserList);
            this.sexlistbindingSource.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // zvanrazbindingSource
            // 
            this.zvanrazbindingSource.DataSource = typeof(ChessersLibrary.ChesserList);
            // 
            // ChessEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(zvanRazIDLabel);
            this.Controls.Add(this.zvanRazIDComboBox);
            this.Controls.Add(sexIDLabel);
            this.Controls.Add(this.sexIDComboBox);
            this.Controls.Add(chesserRaitingLabel);
            this.Controls.Add(this.chesserRaitingTextBox);
            this.Controls.Add(chesserLabel);
            this.Controls.Add(this.chesserTextBox);
            this.Controls.Add(chesserDateBirthLabel);
            this.Controls.Add(this.chesserDateBirthDateTimePicker);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ChessEditForm";
            this.Text = "Добавить члена клуба";
            this.Load += new System.EventHandler(this.ChessEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chesserInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexlistbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zvanrazbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource chesserInfoBindingSource;
        private System.Windows.Forms.DateTimePicker chesserDateBirthDateTimePicker;
        private System.Windows.Forms.TextBox chesserTextBox;
        private System.Windows.Forms.TextBox chesserRaitingTextBox;
        private System.Windows.Forms.ComboBox sexIDComboBox;
        private System.Windows.Forms.ComboBox zvanRazIDComboBox;
        private System.Windows.Forms.BindingSource sexlistbindingSource;
        private System.Windows.Forms.BindingSource zvanrazbindingSource;
    }
}