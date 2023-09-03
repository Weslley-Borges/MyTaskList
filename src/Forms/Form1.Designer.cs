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
			MinorTaskLabel = new Label();
			MinorTaskInput = new TextBox();
			DeleteMinorTaskButton = new Button();
			UpdateMinorTaskButton = new Button();
			MajorTaskErrorLabel = new Label();
			MinorTaskErrorLabel = new Label();
			DoneCheckbox = new CheckBox();
			SuspendLayout();
			// 
			// NewMinorTaskButton
			// 
			NewMinorTaskButton.Location = new Point(243, 393);
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
			MinorTasksCheckList.CheckOnClick = true;
			MinorTasksCheckList.FormattingEnabled = true;
			MinorTasksCheckList.Location = new Point(243, 214);
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
			MinorTasksListLabel.Location = new Point(452, 204);
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
			MajorTasksList.Size = new Size(225, 439);
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
			// MinorTaskLabel
			// 
			MinorTaskLabel.AutoSize = true;
			MinorTaskLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			MinorTaskLabel.Location = new Point(277, 355);
			MinorTaskLabel.Name = "MinorTaskLabel";
			MinorTaskLabel.Size = new Size(81, 15);
			MinorTaskLabel.TabIndex = 14;
			MinorTaskLabel.Text = "Tarefa Menor";
			// 
			// MinorTaskInput
			// 
			MinorTaskInput.Location = new Point(264, 364);
			MinorTaskInput.MaxLength = 100;
			MinorTaskInput.Name = "MinorTaskInput";
			MinorTaskInput.Size = new Size(286, 23);
			MinorTaskInput.TabIndex = 13;
			// 
			// DeleteMinorTaskButton
			// 
			DeleteMinorTaskButton.Location = new Point(361, 393);
			DeleteMinorTaskButton.Name = "DeleteMinorTaskButton";
			DeleteMinorTaskButton.Size = new Size(75, 23);
			DeleteMinorTaskButton.TabIndex = 15;
			DeleteMinorTaskButton.Text = "Excluir";
			DeleteMinorTaskButton.UseVisualStyleBackColor = true;
			DeleteMinorTaskButton.Click += DeleteMinorTaskButton_Click;
			// 
			// UpdateMinorTaskButton
			// 
			UpdateMinorTaskButton.Location = new Point(475, 393);
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
			MajorTaskErrorLabel.Location = new Point(243, 169);
			MajorTaskErrorLabel.Name = "MajorTaskErrorLabel";
			MajorTaskErrorLabel.Size = new Size(307, 35);
			MajorTaskErrorLabel.TabIndex = 17;
			MajorTaskErrorLabel.Text = ".";
			// 
			// MinorTaskErrorLabel
			// 
			MinorTaskErrorLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			MinorTaskErrorLabel.ForeColor = Color.Red;
			MinorTaskErrorLabel.Location = new Point(243, 419);
			MinorTaskErrorLabel.Name = "MinorTaskErrorLabel";
			MinorTaskErrorLabel.Size = new Size(307, 43);
			MinorTaskErrorLabel.TabIndex = 18;
			MinorTaskErrorLabel.Text = ".";
			// 
			// DoneCheckbox
			// 
			DoneCheckbox.AutoSize = true;
			DoneCheckbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			DoneCheckbox.Location = new Point(243, 368);
			DoneCheckbox.Name = "DoneCheckbox";
			DoneCheckbox.Size = new Size(15, 14);
			DoneCheckbox.TabIndex = 19;
			DoneCheckbox.UseVisualStyleBackColor = true;
			DoneCheckbox.CheckedChanged += DoneCheckbox_CheckedChanged;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(568, 471);
			Controls.Add(DoneCheckbox);
			Controls.Add(MinorTaskErrorLabel);
			Controls.Add(MajorTaskErrorLabel);
			Controls.Add(UpdateMinorTaskButton);
			Controls.Add(DeleteMinorTaskButton);
			Controls.Add(MinorTaskLabel);
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
			FormBorderStyle = FormBorderStyle.FixedSingle;
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
		private Label MinorTaskLabel;
		private TextBox MinorTaskInput;
		private Button DeleteMinorTaskButton;
		private Button UpdateMinorTaskButton;
		private Label MajorTaskErrorLabel;
		private Label MinorTaskErrorLabel;
		private CheckBox DoneCheckbox;
	}
}