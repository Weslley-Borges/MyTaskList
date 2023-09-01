namespace MyTaskList
{
    partial class Form1
    {
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
            button1 = new Button();
            MajorTaskTitleInput = new TextBox();
            MinorTasksCheckList = new CheckedListBox();
            MajorTaskTituloLabel = new Label();
            MajorTaskDescriptionInput = new TextBox();
            MajorTaskDescriptionLabel = new Label();
            MinorTasksListLabel = new Label();
            MajorTasksList = new ListBox();
            NewMajorTaskButton = new Button();
            DeleteMajorTaskButton = new Button();
            UpdateMajorTaskButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(703, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // MajorTaskTitleInput
            // 
            MajorTaskTitleInput.Location = new Point(374, 24);
            MajorTaskTitleInput.MaxLength = 100;
            MajorTaskTitleInput.Name = "MajorTaskTitleInput";
            MajorTaskTitleInput.Size = new Size(307, 23);
            MajorTaskTitleInput.TabIndex = 1;
            // 
            // MinorTasksCheckList
            // 
            MinorTasksCheckList.FormattingEnabled = true;
            MinorTasksCheckList.Location = new Point(374, 185);
            MinorTasksCheckList.Name = "MinorTasksCheckList";
            MinorTasksCheckList.Size = new Size(307, 202);
            MinorTasksCheckList.TabIndex = 2;
            // 
            // MajorTaskTituloLabel
            // 
            MajorTaskTituloLabel.AutoSize = true;
            MajorTaskTituloLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            MajorTaskTituloLabel.Location = new Point(385, 15);
            MajorTaskTituloLabel.Name = "MajorTaskTituloLabel";
            MajorTaskTituloLabel.Size = new Size(38, 15);
            MajorTaskTituloLabel.TabIndex = 3;
            MajorTaskTituloLabel.Text = "Título";
            // 
            // MajorTaskDescriptionInput
            // 
            MajorTaskDescriptionInput.Location = new Point(374, 72);
            MajorTaskDescriptionInput.MaxLength = 300;
            MajorTaskDescriptionInput.Multiline = true;
            MajorTaskDescriptionInput.Name = "MajorTaskDescriptionInput";
            MajorTaskDescriptionInput.Size = new Size(307, 77);
            MajorTaskDescriptionInput.TabIndex = 4;
            // 
            // MajorTaskDescriptionLabel
            // 
            MajorTaskDescriptionLabel.AutoSize = true;
            MajorTaskDescriptionLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            MajorTaskDescriptionLabel.Location = new Point(383, 63);
            MajorTaskDescriptionLabel.Name = "MajorTaskDescriptionLabel";
            MajorTaskDescriptionLabel.Size = new Size(68, 15);
            MajorTaskDescriptionLabel.TabIndex = 5;
            MajorTaskDescriptionLabel.Text = "Description";
            // 
            // MinorTasksListLabel
            // 
            MinorTasksListLabel.AutoSize = true;
            MinorTasksListLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            MinorTasksListLabel.Location = new Point(383, 167);
            MinorTasksListLabel.Name = "MinorTasksListLabel";
            MinorTasksListLabel.Size = new Size(98, 15);
            MinorTasksListLabel.TabIndex = 6;
            MinorTasksListLabel.Text = "Tarefas menores";
            // 
            // MajorTasksList
            // 
            MajorTasksList.FormattingEnabled = true;
            MajorTasksList.ItemHeight = 15;
            MajorTasksList.Location = new Point(12, 24);
            MajorTasksList.Name = "MajorTasksList";
            MajorTasksList.Size = new Size(341, 364);
            MajorTasksList.TabIndex = 8;
            // 
            // NewMajorTaskButton
            // 
            NewMajorTaskButton.Location = new Point(703, 24);
            NewMajorTaskButton.Name = "NewMajorTaskButton";
            NewMajorTaskButton.Size = new Size(75, 23);
            NewMajorTaskButton.TabIndex = 9;
            NewMajorTaskButton.Text = "Criar tarefa";
            NewMajorTaskButton.UseVisualStyleBackColor = true;
            NewMajorTaskButton.Click += NewMajorTaskButton_Click;
            // 
            // DeleteMajorTaskButton
            // 
            DeleteMajorTaskButton.Location = new Point(703, 53);
            DeleteMajorTaskButton.Name = "DeleteMajorTaskButton";
            DeleteMajorTaskButton.Size = new Size(75, 23);
            DeleteMajorTaskButton.TabIndex = 10;
            DeleteMajorTaskButton.Text = "Excluir";
            DeleteMajorTaskButton.UseVisualStyleBackColor = true;
            // 
            // UpdateMajorTaskButton
            // 
            UpdateMajorTaskButton.Location = new Point(703, 82);
            UpdateMajorTaskButton.Name = "UpdateMajorTaskButton";
            UpdateMajorTaskButton.Size = new Size(75, 23);
            UpdateMajorTaskButton.TabIndex = 11;
            UpdateMajorTaskButton.Text = "Atualizar";
            UpdateMajorTaskButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(UpdateMajorTaskButton);
            Controls.Add(DeleteMajorTaskButton);
            Controls.Add(NewMajorTaskButton);
            Controls.Add(MajorTasksList);
            Controls.Add(MinorTasksListLabel);
            Controls.Add(MajorTaskDescriptionLabel);
            Controls.Add(MajorTaskDescriptionInput);
            Controls.Add(MajorTaskTituloLabel);
            Controls.Add(MinorTasksCheckList);
            Controls.Add(MajorTaskTitleInput);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyTaskList";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox MajorTaskTitleInput;
        private Label Label1;
        private CheckedListBox MinorTasksCheckList;
        private Label MajorTaskTituloLabel;
        private TextBox MajorTaskDescriptionInput;
        private Label MajorTaskDescriptionLabel;
        private Label MinorTasksListLabel;
        private ListBox MajorTasksList;
        private Button NewMajorTaskButton;
        private Button DeleteMajorTaskButton;
        private Button UpdateMajorTaskButton;
    }
}