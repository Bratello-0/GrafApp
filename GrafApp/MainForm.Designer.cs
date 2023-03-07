namespace GrafApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContext = new System.Windows.Forms.Panel();
            this.panelSaveMenu = new System.Windows.Forms.Panel();
            this.labelStatusSaveText = new System.Windows.Forms.Label();
            this.labelStatusSave = new System.Windows.Forms.Label();
            this.labelPathSave = new System.Windows.Forms.Label();
            this.labelPathSaveText = new System.Windows.Forms.Label();
            this.buttonSelectPath = new System.Windows.Forms.Button();
            this.panelTextSave = new System.Windows.Forms.Panel();
            this.labelTextSave = new System.Windows.Forms.Label();
            this.checkBoxOpenResult = new System.Windows.Forms.CheckBox();
            this.panelLoadMenu = new System.Windows.Forms.Panel();
            this.labelStatusLoadText = new System.Windows.Forms.Label();
            this.labelStatusLoad = new System.Windows.Forms.Label();
            this.labelPathLoad = new System.Windows.Forms.Label();
            this.labelPathLoadText = new System.Windows.Forms.Label();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.panelTextLoad = new System.Windows.Forms.Panel();
            this.labelLoad = new System.Windows.Forms.Label();
            this.buttonStartAlg = new System.Windows.Forms.Button();
            this.panelSelect = new System.Windows.Forms.Panel();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBoxNameSaveFile = new System.Windows.Forms.TextBox();
            this.labelNameFileForSave = new System.Windows.Forms.Label();
            this.panelContext.SuspendLayout();
            this.panelSaveMenu.SuspendLayout();
            this.panelTextSave.SuspendLayout();
            this.panelLoadMenu.SuspendLayout();
            this.panelTextLoad.SuspendLayout();
            this.panelSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContext
            // 
            this.panelContext.Controls.Add(this.panelSaveMenu);
            this.panelContext.Controls.Add(this.panelTextSave);
            this.panelContext.Controls.Add(this.checkBoxOpenResult);
            this.panelContext.Controls.Add(this.panelLoadMenu);
            this.panelContext.Controls.Add(this.panelTextLoad);
            this.panelContext.Controls.Add(this.buttonStartAlg);
            this.panelContext.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContext.Location = new System.Drawing.Point(0, 0);
            this.panelContext.Name = "panelContext";
            this.panelContext.Size = new System.Drawing.Size(353, 461);
            this.panelContext.TabIndex = 0;
            // 
            // panelSaveMenu
            // 
            this.panelSaveMenu.Controls.Add(this.labelNameFileForSave);
            this.panelSaveMenu.Controls.Add(this.textBoxNameSaveFile);
            this.panelSaveMenu.Controls.Add(this.labelStatusSaveText);
            this.panelSaveMenu.Controls.Add(this.labelStatusSave);
            this.panelSaveMenu.Controls.Add(this.labelPathSave);
            this.panelSaveMenu.Controls.Add(this.labelPathSaveText);
            this.panelSaveMenu.Controls.Add(this.buttonSelectPath);
            this.panelSaveMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSaveMenu.Location = new System.Drawing.Point(0, 137);
            this.panelSaveMenu.Name = "panelSaveMenu";
            this.panelSaveMenu.Size = new System.Drawing.Size(353, 89);
            this.panelSaveMenu.TabIndex = 6;
            // 
            // labelStatusSaveText
            // 
            this.labelStatusSaveText.AutoSize = true;
            this.labelStatusSaveText.Location = new System.Drawing.Point(12, 32);
            this.labelStatusSaveText.Name = "labelStatusSaveText";
            this.labelStatusSaveText.Size = new System.Drawing.Size(79, 13);
            this.labelStatusSaveText.TabIndex = 5;
            this.labelStatusSaveText.Text = "Статус файла:";
            // 
            // labelStatusSave
            // 
            this.labelStatusSave.AutoSize = true;
            this.labelStatusSave.Location = new System.Drawing.Point(97, 32);
            this.labelStatusSave.Name = "labelStatusSave";
            this.labelStatusSave.Size = new System.Drawing.Size(16, 13);
            this.labelStatusSave.TabIndex = 4;
            this.labelStatusSave.Text = "...";
            // 
            // labelPathSave
            // 
            this.labelPathSave.AutoSize = true;
            this.labelPathSave.Location = new System.Drawing.Point(52, 9);
            this.labelPathSave.Name = "labelPathSave";
            this.labelPathSave.Size = new System.Drawing.Size(23, 13);
            this.labelPathSave.TabIndex = 2;
            this.labelPathSave.Text = "null";
            // 
            // labelPathSaveText
            // 
            this.labelPathSaveText.AutoSize = true;
            this.labelPathSaveText.Location = new System.Drawing.Point(12, 9);
            this.labelPathSaveText.Name = "labelPathSaveText";
            this.labelPathSaveText.Size = new System.Drawing.Size(34, 13);
            this.labelPathSaveText.TabIndex = 1;
            this.labelPathSaveText.Text = "Путь:";
            // 
            // buttonSelectPath
            // 
            this.buttonSelectPath.Location = new System.Drawing.Point(15, 48);
            this.buttonSelectPath.Name = "buttonSelectPath";
            this.buttonSelectPath.Size = new System.Drawing.Size(134, 30);
            this.buttonSelectPath.TabIndex = 0;
            this.buttonSelectPath.Text = "Указать путь";
            this.buttonSelectPath.UseVisualStyleBackColor = true;
            // 
            // panelTextSave
            // 
            this.panelTextSave.Controls.Add(this.labelTextSave);
            this.panelTextSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTextSave.Location = new System.Drawing.Point(0, 113);
            this.panelTextSave.Name = "panelTextSave";
            this.panelTextSave.Size = new System.Drawing.Size(353, 24);
            this.panelTextSave.TabIndex = 7;
            // 
            // labelTextSave
            // 
            this.labelTextSave.AutoSize = true;
            this.labelTextSave.Location = new System.Drawing.Point(3, 4);
            this.labelTextSave.Name = "labelTextSave";
            this.labelTextSave.Size = new System.Drawing.Size(67, 13);
            this.labelTextSave.TabIndex = 8;
            this.labelTextSave.Text = "Сохранение";
            // 
            // checkBoxOpenResult
            // 
            this.checkBoxOpenResult.AutoSize = true;
            this.checkBoxOpenResult.Location = new System.Drawing.Point(161, 259);
            this.checkBoxOpenResult.Name = "checkBoxOpenResult";
            this.checkBoxOpenResult.Size = new System.Drawing.Size(152, 17);
            this.checkBoxOpenResult.TabIndex = 4;
            this.checkBoxOpenResult.Text = "Открыть по завершению";
            this.checkBoxOpenResult.UseVisualStyleBackColor = true;
            // 
            // panelLoadMenu
            // 
            this.panelLoadMenu.Controls.Add(this.labelStatusLoadText);
            this.panelLoadMenu.Controls.Add(this.labelStatusLoad);
            this.panelLoadMenu.Controls.Add(this.labelPathLoad);
            this.panelLoadMenu.Controls.Add(this.labelPathLoadText);
            this.panelLoadMenu.Controls.Add(this.buttonSelectFile);
            this.panelLoadMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLoadMenu.Location = new System.Drawing.Point(0, 24);
            this.panelLoadMenu.Name = "panelLoadMenu";
            this.panelLoadMenu.Size = new System.Drawing.Size(353, 89);
            this.panelLoadMenu.TabIndex = 0;
            // 
            // labelStatusLoadText
            // 
            this.labelStatusLoadText.AutoSize = true;
            this.labelStatusLoadText.Location = new System.Drawing.Point(12, 32);
            this.labelStatusLoadText.Name = "labelStatusLoadText";
            this.labelStatusLoadText.Size = new System.Drawing.Size(79, 13);
            this.labelStatusLoadText.TabIndex = 5;
            this.labelStatusLoadText.Text = "Статус файла:";
            // 
            // labelStatusLoad
            // 
            this.labelStatusLoad.AutoSize = true;
            this.labelStatusLoad.Location = new System.Drawing.Point(97, 32);
            this.labelStatusLoad.Name = "labelStatusLoad";
            this.labelStatusLoad.Size = new System.Drawing.Size(91, 13);
            this.labelStatusLoad.TabIndex = 4;
            this.labelStatusLoad.Text = "Не выбран файл";
            // 
            // labelPathLoad
            // 
            this.labelPathLoad.AutoSize = true;
            this.labelPathLoad.Location = new System.Drawing.Point(52, 9);
            this.labelPathLoad.Name = "labelPathLoad";
            this.labelPathLoad.Size = new System.Drawing.Size(23, 13);
            this.labelPathLoad.TabIndex = 2;
            this.labelPathLoad.Text = "null";
            // 
            // labelPathLoadText
            // 
            this.labelPathLoadText.AutoSize = true;
            this.labelPathLoadText.Location = new System.Drawing.Point(12, 9);
            this.labelPathLoadText.Name = "labelPathLoadText";
            this.labelPathLoadText.Size = new System.Drawing.Size(34, 13);
            this.labelPathLoadText.TabIndex = 1;
            this.labelPathLoadText.Text = "Путь:";
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(15, 49);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(134, 30);
            this.buttonSelectFile.TabIndex = 0;
            this.buttonSelectFile.Text = "Выбрать файл";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            // 
            // panelTextLoad
            // 
            this.panelTextLoad.Controls.Add(this.labelLoad);
            this.panelTextLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTextLoad.Location = new System.Drawing.Point(0, 0);
            this.panelTextLoad.Name = "panelTextLoad";
            this.panelTextLoad.Size = new System.Drawing.Size(353, 24);
            this.panelTextLoad.TabIndex = 9;
            // 
            // labelLoad
            // 
            this.labelLoad.AutoSize = true;
            this.labelLoad.Location = new System.Drawing.Point(3, 4);
            this.labelLoad.Name = "labelLoad";
            this.labelLoad.Size = new System.Drawing.Size(54, 13);
            this.labelLoad.TabIndex = 8;
            this.labelLoad.Text = "Загрузка";
            // 
            // buttonStartAlg
            // 
            this.buttonStartAlg.Location = new System.Drawing.Point(12, 246);
            this.buttonStartAlg.Name = "buttonStartAlg";
            this.buttonStartAlg.Size = new System.Drawing.Size(134, 30);
            this.buttonStartAlg.TabIndex = 3;
            this.buttonStartAlg.Text = "Запустить";
            this.buttonStartAlg.UseVisualStyleBackColor = true;
            // 
            // panelSelect
            // 
            this.panelSelect.Controls.Add(this.radioButton14);
            this.panelSelect.Controls.Add(this.radioButton13);
            this.panelSelect.Controls.Add(this.radioButton12);
            this.panelSelect.Controls.Add(this.radioButton11);
            this.panelSelect.Controls.Add(this.radioButton10);
            this.panelSelect.Controls.Add(this.radioButton9);
            this.panelSelect.Controls.Add(this.radioButton8);
            this.panelSelect.Controls.Add(this.radioButton7);
            this.panelSelect.Controls.Add(this.radioButton6);
            this.panelSelect.Controls.Add(this.radioButton5);
            this.panelSelect.Controls.Add(this.radioButton4);
            this.panelSelect.Controls.Add(this.radioButton3);
            this.panelSelect.Controls.Add(this.radioButton2);
            this.panelSelect.Controls.Add(this.radioButton1);
            this.panelSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSelect.Location = new System.Drawing.Point(353, 0);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(406, 461);
            this.panelSelect.TabIndex = 1;
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(6, 374);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(252, 17);
            this.radioButton14.TabIndex = 13;
            this.radioButton14.Text = "14. Алгоритм нахождения точек сочленения.";
            this.radioButton14.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(6, 351);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(267, 17);
            this.radioButton13.TabIndex = 12;
            this.radioButton13.Text = "13. Алгоритм нахождения Гамильтового цикла.";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(6, 328);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(146, 17);
            this.radioButton12.TabIndex = 11;
            this.radioButton12.Text = "12. Алгоритм Крускала.";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(6, 305);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(132, 17);
            this.radioButton11.TabIndex = 10;
            this.radioButton11.Text = "11. Алгоритм Прима.";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(6, 282);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(322, 17);
            this.radioButton10.TabIndex = 9;
            this.radioButton10.Text = "10. Алгоритм нахождения максимального паросочетания.";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(6, 246);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(385, 30);
            this.radioButton9.TabIndex = 8;
            this.radioButton9.Text = "9 .Алгоритм нахождения Эйлеровых циклов с использованием списка\r\nсмежности.";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(6, 210);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(394, 30);
            this.radioButton8.TabIndex = 7;
            this.radioButton8.Text = "8. Алгоритм нахождения Эйлеровых циклов с использованием матрицы\r\nсмежности\r\n";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(6, 187);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(133, 17);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.Text = "7. Алгоритм Флойда.";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 164);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(144, 17);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.Text = "6. Алгоритм Дейкстры.";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 141);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(242, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "5. Алгоритм раскраски графа в два цвета.";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 118);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(235, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "4. Алгоритм топологической сортировки.\r\n";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 95);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(210, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "3. Алгоритм обхода графа в ширину.";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 72);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(349, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "2. Алгоритм обхода графа в глубину с использованием списка.\r\n";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 49);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(358, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1. Алгоритм обхода графа в глубину с использованием матрицы.\r\n";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBoxNameSaveFile
            // 
            this.textBoxNameSaveFile.Location = new System.Drawing.Point(206, 58);
            this.textBoxNameSaveFile.Name = "textBoxNameSaveFile";
            this.textBoxNameSaveFile.Size = new System.Drawing.Size(117, 20);
            this.textBoxNameSaveFile.TabIndex = 6;
            this.textBoxNameSaveFile.Text = "Save";
            // 
            // labelNameFileForSave
            // 
            this.labelNameFileForSave.AutoSize = true;
            this.labelNameFileForSave.Location = new System.Drawing.Point(190, 42);
            this.labelNameFileForSave.Name = "labelNameFileForSave";
            this.labelNameFileForSave.Size = new System.Drawing.Size(147, 13);
            this.labelNameFileForSave.TabIndex = 7;
            this.labelNameFileForSave.Text = "Имя файла при сохранении";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 461);
            this.Controls.Add(this.panelSelect);
            this.Controls.Add(this.panelContext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graf";
            this.panelContext.ResumeLayout(false);
            this.panelContext.PerformLayout();
            this.panelSaveMenu.ResumeLayout(false);
            this.panelSaveMenu.PerformLayout();
            this.panelTextSave.ResumeLayout(false);
            this.panelTextSave.PerformLayout();
            this.panelLoadMenu.ResumeLayout(false);
            this.panelLoadMenu.PerformLayout();
            this.panelTextLoad.ResumeLayout(false);
            this.panelTextLoad.PerformLayout();
            this.panelSelect.ResumeLayout(false);
            this.panelSelect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContext;
        private System.Windows.Forms.Panel panelLoadMenu;
        private System.Windows.Forms.Label labelStatusLoad;
        private System.Windows.Forms.Button buttonStartAlg;
        private System.Windows.Forms.Label labelPathLoad;
        private System.Windows.Forms.Label labelPathLoadText;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.Panel panelSelect;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label labelStatusLoadText;
        private System.Windows.Forms.Panel panelTextLoad;
        private System.Windows.Forms.Label labelLoad;
        private System.Windows.Forms.Panel panelTextSave;
        private System.Windows.Forms.Label labelTextSave;
        private System.Windows.Forms.Panel panelSaveMenu;
        private System.Windows.Forms.Label labelStatusSaveText;
        private System.Windows.Forms.Label labelStatusSave;
        private System.Windows.Forms.Label labelPathSave;
        private System.Windows.Forms.Label labelPathSaveText;
        private System.Windows.Forms.Button buttonSelectPath;
        private System.Windows.Forms.CheckBox checkBoxOpenResult;
        private System.Windows.Forms.TextBox textBoxNameSaveFile;
        private System.Windows.Forms.Label labelNameFileForSave;
    }
}

