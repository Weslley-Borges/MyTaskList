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
			TaskProgressBar = new ProgressBar();
			ProgressBarLabel = new Label();
			SuspendLayout();
			// 
			// NewMinorTaskButton
			// 
			NewMinorTaskButton.BackColor = Color.LightGreen;
			NewMinorTaskButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			NewMinorTaskButton.Location = new Point(243, 393);
			NewMinorTaskButton.Name = "NewMinorTaskButton";
			NewMinorTaskButton.Size = new Size(75, 23);
			NewMinorTaskButton.TabIndex = 0;
			NewMinorTaskButton.Text = "Criar";
			NewMinorTaskButton.UseVisualStyleBackColor = false;
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
			MinorTasksCheckList.Size = new Size(307, 112);
			MinorTasksCheckList.TabIndex = 2;
			MinorTasksCheckList.SelectedIndexChanged += MinorTasksCheckList_SelectedIndexChanged;
			// 
			// MajorTaskTituloLabel
			// 
			MajorTaskTituloLabel.AutoSize = true;
			MajorTaskTituloLabel.BackColor = Color.MintCream;
			MajorTaskTituloLabel.BorderStyle = BorderStyle.FixedSingle;
			MajorTaskTituloLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			MajorTaskTituloLabel.Location = new Point(254, 16);
			MajorTaskTituloLabel.Name = "MajorTaskTituloLabel";
			MajorTaskTituloLabel.Size = new Size(40, 17);
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
			MajorTaskDescriptionLabel.BackColor = Color.MintCream;
			MajorTaskDescriptionLabel.BorderStyle = BorderStyle.FixedSingle;
			MajorTaskDescriptionLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			MajorTaskDescriptionLabel.Location = new Point(252, 51);
			MajorTaskDescriptionLabel.Name = "MajorTaskDescriptionLabel";
			MajorTaskDescriptionLabel.Size = new Size(61, 17);
			MajorTaskDescriptionLabel.TabIndex = 5;
			MajorTaskDescriptionLabel.Text = "Descrição";
			// 
			// MinorTasksListLabel
			// 
			MinorTasksListLabel.AutoSize = true;
			MinorTasksListLabel.BackColor = Color.MintCream;
			MinorTasksListLabel.BorderStyle = BorderStyle.FixedSingle;
			MinorTasksListLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			MinorTasksListLabel.Location = new Point(444, 204);
			MinorTasksListLabel.Name = "MinorTasksListLabel";
			MinorTasksListLabel.Size = new Size(100, 17);
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
			NewMajorTaskButton.BackColor = Color.PaleGreen;
			NewMajorTaskButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			NewMajorTaskButton.Location = new Point(243, 143);
			NewMajorTaskButton.Name = "NewMajorTaskButton";
			NewMajorTaskButton.Size = new Size(75, 23);
			NewMajorTaskButton.TabIndex = 9;
			NewMajorTaskButton.Text = "Criar";
			NewMajorTaskButton.UseVisualStyleBackColor = false;
			NewMajorTaskButton.Click += NewMajorTaskButton_Click;
			// 
			// DeleteMajorTaskButton
			// 
			DeleteMajorTaskButton.BackColor = Color.IndianRed;
			DeleteMajorTaskButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			DeleteMajorTaskButton.ForeColor = SystemColors.ButtonFace;
			DeleteMajorTaskButton.Location = new Point(361, 143);
			DeleteMajorTaskButton.Name = "DeleteMajorTaskButton";
			DeleteMajorTaskButton.Size = new Size(75, 23);
			DeleteMajorTaskButton.TabIndex = 10;
			DeleteMajorTaskButton.Text = "Excluir";
			DeleteMajorTaskButton.UseVisualStyleBackColor = false;
			DeleteMajorTaskButton.Click += DeleteMajorTaskButton_Click;
			// 
			// UpdateMajorTaskButton
			// 
			UpdateMajorTaskButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
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
			label2.BackColor = Color.MintCream;
			label2.BorderStyle = BorderStyle.FixedSingle;
			label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label2.Location = new Point(178, 16);
			label2.Name = "label2";
			label2.Size = new Size(50, 17);
			label2.TabIndex = 12;
			label2.Text = "Tarefas";
			// 
			// MinorTaskLabel
			// 
			MinorTaskLabel.AutoSize = true;
			MinorTaskLabel.BackColor = Color.MintCream;
			MinorTaskLabel.BorderStyle = BorderStyle.FixedSingle;
			MinorTaskLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			MinorTaskLabel.Location = new Point(252, 354);
			MinorTaskLabel.Name = "MinorTaskLabel";
			MinorTaskLabel.Size = new Size(83, 17);
			MinorTaskLabel.TabIndex = 14;
			MinorTaskLabel.Text = "Tarefa Menor";
			// 
			// MinorTaskInput
			// 
			MinorTaskInput.Location = new Point(243, 364);
			MinorTaskInput.MaxLength = 100;
			MinorTaskInput.Name = "MinorTaskInput";
			MinorTaskInput.Size = new Size(280, 23);
			MinorTaskInput.TabIndex = 13;
			// 
			// DeleteMinorTaskButton
			// 
			DeleteMinorTaskButton.BackColor = Color.IndianRed;
			DeleteMinorTaskButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			DeleteMinorTaskButton.ForeColor = SystemColors.ButtonFace;
			DeleteMinorTaskButton.Location = new Point(361, 393);
			DeleteMinorTaskButton.Name = "DeleteMinorTaskButton";
			DeleteMinorTaskButton.Size = new Size(75, 23);
			DeleteMinorTaskButton.TabIndex = 15;
			DeleteMinorTaskButton.Text = "Excluir";
			DeleteMinorTaskButton.UseVisualStyleBackColor = false;
			DeleteMinorTaskButton.Click += DeleteMinorTaskButton_Click;
			// 
			// UpdateMinorTaskButton
			// 
			UpdateMinorTaskButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
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
			DoneCheckbox.Location = new Point(529, 368);
			DoneCheckbox.Name = "DoneCheckbox";
			DoneCheckbox.Size = new Size(15, 14);
			DoneCheckbox.TabIndex = 19;
			DoneCheckbox.UseVisualStyleBackColor = true;
			DoneCheckbox.CheckedChanged += DoneCheckbox_CheckedChanged;
			// 
			// TaskProgressBar
			// 
			TaskProgressBar.Location = new Point(243, 326);
			TaskProgressBar.Name = "TaskProgressBar";
			TaskProgressBar.Size = new Size(252, 23);
			TaskProgressBar.TabIndex = 20;
			// 
			// ProgressBarLabel
			// 
			ProgressBarLabel.AutoSize = true;
			ProgressBarLabel.BackColor = Color.Transparent;
			ProgressBarLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			ProgressBarLabel.Location = new Point(501, 329);
			ProgressBarLabel.Name = "ProgressBarLabel";
			ProgressBarLabel.Size = new Size(40, 15);
			ProgressBarLabel.TabIndex = 21;
			ProgressBarLabel.Text = "label1";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.PaleTurquoise;
			ClientSize = new Size(568, 471);
			Controls.Add(ProgressBarLabel);
			Controls.Add(TaskProgressBar);
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
		private ProgressBar TaskProgressBar;
		private Label ProgressBarLabel;
	}
}