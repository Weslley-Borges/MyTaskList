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
			NewMinorTaskButton = new Button();
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
			label2 = new Label();
			label1 = new Label();
			MinorTaskInput = new TextBox();
			DeleteMinorTaskButton = new Button();
			UpdateMinorTaskButton = new Button();
			MajorTaskErrorLabel = new Label();
			MinorTaskErrorLabel = new Label();
			SuspendLayout();
			// 
			// NewMinorTaskButton
			// 
			NewMinorTaskButton.Location = new Point(243, 365);
			NewMinorTaskButton.Name = "NewMinorTaskButton";
			NewMinorTaskButton.Size = new Size(75, 23);
			NewMinorTaskButton.TabIndex = 0;
			NewMinorTaskButton.Text = "Criar";
			NewMinorTaskButton.UseVisualStyleBackColor = true;
			NewMinorTaskButton.Click += NewMinorTaskButton_Click;
			// 
			// MajorTaskTitleInput
			// 
			MajorTaskTitleInput.Location = new Point(243, 25);
			MajorTaskTitleInput.MaxLength = 100;
			MajorTaskTitleInput.Name = "MajorTaskTitleInput";
			MajorTaskTitleInput.Size = new Size(307, 23);
			MajorTaskTitleInput.TabIndex = 1;
			// 
			// MinorTasksCheckList
			// 
			MinorTasksCheckList.FormattingEnabled = true;
			MinorTasksCheckList.Location = new Point(243, 186);
			MinorTasksCheckList.Name = "MinorTasksCheckList";
			MinorTasksCheckList.Size = new Size(307, 130);
			MinorTasksCheckList.TabIndex = 2;
			MinorTasksCheckList.SelectedIndexChanged += MinorTasksCheckList_SelectedIndexChanged;
			// 
			// MajorTaskTituloLabel
			// 
			MajorTaskTituloLabel.AutoSize = true;
			MajorTaskTituloLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			MajorTaskTituloLabel.Location = new Point(254, 16);
			MajorTaskTituloLabel.Name = "MajorTaskTituloLabel";
			MajorTaskTituloLabel.Size = new Size(38, 15);
			MajorTaskTituloLabel.TabIndex = 3;
			MajorTaskTituloLabel.Text = "Título";
			// 
			// MajorTaskDescriptionInput
			// 
			MajorTaskDescriptionInput.Location = new Point(243, 60);
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
			MajorTaskDescriptionLabel.Location = new Point(252, 51);
			MajorTaskDescriptionLabel.Name = "MajorTaskDescriptionLabel";
			MajorTaskDescriptionLabel.Size = new Size(59, 15);
			MajorTaskDescriptionLabel.TabIndex = 5;
			MajorTaskDescriptionLabel.Text = "Descrição";
			// 
			// MinorTasksListLabel
			// 
			MinorTasksListLabel.AutoSize = true;
			MinorTasksListLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			MinorTasksListLabel.Location = new Point(452, 176);
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
			MajorTasksList.Size = new Size(225, 364);
			MajorTasksList.TabIndex = 8;
			MajorTasksList.SelectedIndexChanged += MajorTasksList_SelectedIndexChanged;
			// 
			// NewMajorTaskButton
			// 
			NewMajorTaskButton.Location = new Point(243, 143);
			NewMajorTaskButton.Name = "NewMajorTaskButton";
			NewMajorTaskButton.Size = new Size(75, 23);
			NewMajorTaskButton.TabIndex = 9;
			NewMajorTaskButton.Text = "Criar";
			NewMajorTaskButton.UseVisualStyleBackColor = true;
			NewMajorTaskButton.Click += NewMajorTaskButton_Click;
			// 
			// DeleteMajorTaskButton
			// 
			DeleteMajorTaskButton.Location = new Point(361, 143);
			DeleteMajorTaskButton.Name = "DeleteMajorTaskButton";
			DeleteMajorTaskButton.Size = new Size(75, 23);
			DeleteMajorTaskButton.TabIndex = 10;
			DeleteMajorTaskButton.Text = "Excluir";
			DeleteMajorTaskButton.UseVisualStyleBackColor = true;
			DeleteMajorTaskButton.Click += DeleteMajorTaskButton_Click;
			// 
			// UpdateMajorTaskButton
			// 
			UpdateMajorTaskButton.Location = new Point(475, 143);
			UpdateMajorTaskButton.Name = "UpdateMajorTaskButton";
			UpdateMajorTaskButton.Size = new Size(75, 23);
			UpdateMajorTaskButton.TabIndex = 11;
			UpdateMajorTaskButton.Text = "Atualizar";
			UpdateMajorTaskButton.UseVisualStyleBackColor = true;
			UpdateMajorTaskButton.Click += UpdateMajorTaskButton_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label2.Location = new Point(12, 9);
			label2.Name = "label2";
			label2.Size = new Size(48, 15);
			label2.TabIndex = 12;
			label2.Text = "Tarefas";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label1.Location = new Point(254, 327);
			label1.Name = "label1";
			label1.Size = new Size(81, 15);
			label1.TabIndex = 14;
			label1.Text = "Tarefa Menor";
			// 
			// MinorTaskInput
			// 
			MinorTaskInput.Location = new Point(243, 336);
			MinorTaskInput.MaxLength = 100;
			MinorTaskInput.Name = "MinorTaskInput";
			MinorTaskInput.Size = new Size(307, 23);
			MinorTaskInput.TabIndex = 13;
			// 
			// DeleteMinorTaskButton
			// 
			DeleteMinorTaskButton.Location = new Point(361, 365);
			DeleteMinorTaskButton.Name = "DeleteMinorTaskButton";
			DeleteMinorTaskButton.Size = new Size(75, 23);
			DeleteMinorTaskButton.TabIndex = 15;
			DeleteMinorTaskButton.Text = "Excluir";
			DeleteMinorTaskButton.UseVisualStyleBackColor = true;
			DeleteMinorTaskButton.Click += DeleteMinorTaskButton_Click;
			// 
			// UpdateMinorTaskButton
			// 
			UpdateMinorTaskButton.Location = new Point(475, 365);
			UpdateMinorTaskButton.Name = "UpdateMinorTaskButton";
			UpdateMinorTaskButton.Size = new Size(75, 23);
			UpdateMinorTaskButton.TabIndex = 16;
			UpdateMinorTaskButton.Text = "Atualizar";
			UpdateMinorTaskButton.UseVisualStyleBackColor = true;
			UpdateMinorTaskButton.Click += UpdateMinorTaskButton_Click;
			// 
			// MajorTaskErrorLabel
			// 
			MajorTaskErrorLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			MajorTaskErrorLabel.ForeColor = Color.Red;
			MajorTaskErrorLabel.Location = new Point(556, 24);
			MajorTaskErrorLabel.Name = "MajorTaskErrorLabel";
			MajorTaskErrorLabel.Size = new Size(140, 113);
			MajorTaskErrorLabel.TabIndex = 17;
			MajorTaskErrorLabel.Text = ".";
			// 
			// MinorTaskErrorLabel
			// 
			MinorTaskErrorLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			MinorTaskErrorLabel.ForeColor = Color.Red;
			MinorTaskErrorLabel.Location = new Point(556, 275);
			MinorTaskErrorLabel.Name = "MinorTaskErrorLabel";
			MinorTaskErrorLabel.Size = new Size(140, 113);
			MinorTaskErrorLabel.TabIndex = 18;
			MinorTaskErrorLabel.Text = ".";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(699, 416);
			Controls.Add(MinorTaskErrorLabel);
			Controls.Add(MajorTaskErrorLabel);
			Controls.Add(UpdateMinorTaskButton);
			Controls.Add(DeleteMinorTaskButton);
			Controls.Add(label1);
			Controls.Add(MinorTaskInput);
			Controls.Add(label2);
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
			Controls.Add(NewMinorTaskButton);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "MyTaskList";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button NewMinorTaskButton;
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
		private Label label2;
		private Label label1;
		private TextBox MinorTaskInput;
		private Button DeleteMinorTaskButton;
		private Button UpdateMinorTaskButton;
		private Label MajorTaskErrorLabel;
		private Label MinorTaskErrorLabel;
	}
}