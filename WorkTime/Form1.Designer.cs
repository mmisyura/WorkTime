﻿namespace WorkTime
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonCame = new System.Windows.Forms.Button();
            this.labelTimeNow = new System.Windows.Forms.Label();
            this.MaskedTextBoxCame = new System.Windows.Forms.MaskedTextBox();
            this.labelTimeGo = new System.Windows.Forms.Label();
            this.labelGo = new System.Windows.Forms.Label();
            this.labelNow = new System.Windows.Forms.Label();
            this.labelWeekLeft = new System.Windows.Forms.Label();
            this.labelTimeWeekLeft = new System.Windows.Forms.Label();
            this.ButtonGone = new System.Windows.Forms.Button();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCame
            // 
            this.buttonCame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCame.Location = new System.Drawing.Point(84, 98);
            this.buttonCame.Name = "buttonCame";
            this.buttonCame.Size = new System.Drawing.Size(128, 44);
            this.buttonCame.TabIndex = 2;
            this.buttonCame.Text = "Пришёл";
            this.buttonCame.UseVisualStyleBackColor = true;
            this.buttonCame.Click += new System.EventHandler(this.ButtonCame_Click);
            // 
            // labelTimeNow
            // 
            this.labelTimeNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeNow.Location = new System.Drawing.Point(12, 189);
            this.labelTimeNow.Name = "labelTimeNow";
            this.labelTimeNow.Size = new System.Drawing.Size(292, 73);
            this.labelTimeNow.TabIndex = 1;
            this.labelTimeNow.Text = "             ";
            this.labelTimeNow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MaskedTextBoxCame
            // 
            this.MaskedTextBoxCame.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaskedTextBoxCame.Location = new System.Drawing.Point(65, 12);
            this.MaskedTextBoxCame.Mask = "00:00";
            this.MaskedTextBoxCame.Name = "MaskedTextBoxCame";
            this.MaskedTextBoxCame.Size = new System.Drawing.Size(177, 80);
            this.MaskedTextBoxCame.TabIndex = 1;
            this.MaskedTextBoxCame.ValidatingType = typeof(System.DateTime);
            this.MaskedTextBoxCame.TextChanged += new System.EventHandler(this.MaskedTextBoxCame_TextChanged);
            this.MaskedTextBoxCame.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaskedTextBoxCame_KeyPress_1);
            // 
            // labelTimeGo
            // 
            this.labelTimeGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTimeGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeGo.Location = new System.Drawing.Point(12, 318);
            this.labelTimeGo.Name = "labelTimeGo";
            this.labelTimeGo.Size = new System.Drawing.Size(292, 73);
            this.labelTimeGo.TabIndex = 3;
            this.labelTimeGo.Text = "            ";
            this.labelTimeGo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGo
            // 
            this.labelGo.AutoSize = true;
            this.labelGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGo.Location = new System.Drawing.Point(42, 283);
            this.labelGo.Name = "labelGo";
            this.labelGo.Size = new System.Drawing.Size(234, 31);
            this.labelGo.TabIndex = 4;
            this.labelGo.Text = "Рабочий день до:";
            // 
            // labelNow
            // 
            this.labelNow.AutoSize = true;
            this.labelNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNow.Location = new System.Drawing.Point(96, 154);
            this.labelNow.Name = "labelNow";
            this.labelNow.Size = new System.Drawing.Size(115, 31);
            this.labelNow.TabIndex = 5;
            this.labelNow.Text = "Сейчас:";
            // 
            // labelWeekLeft
            // 
            this.labelWeekLeft.AutoSize = true;
            this.labelWeekLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWeekLeft.Location = new System.Drawing.Point(30, 425);
            this.labelWeekLeft.Name = "labelWeekLeft";
            this.labelWeekLeft.Size = new System.Drawing.Size(261, 31);
            this.labelWeekLeft.TabIndex = 6;
            this.labelWeekLeft.Text = "Осталось в неделе:";
            // 
            // labelTimeWeekLeft
            // 
            this.labelTimeWeekLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTimeWeekLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeWeekLeft.Location = new System.Drawing.Point(12, 460);
            this.labelTimeWeekLeft.Name = "labelTimeWeekLeft";
            this.labelTimeWeekLeft.Size = new System.Drawing.Size(292, 73);
            this.labelTimeWeekLeft.TabIndex = 7;
            this.labelTimeWeekLeft.Text = "            ";
            this.labelTimeWeekLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonGone
            // 
            this.ButtonGone.Enabled = false;
            this.ButtonGone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonGone.Location = new System.Drawing.Point(83, 551);
            this.ButtonGone.Name = "ButtonGone";
            this.ButtonGone.Size = new System.Drawing.Size(128, 44);
            this.ButtonGone.TabIndex = 8;
            this.ButtonGone.Text = "Ушёл";
            this.ButtonGone.UseVisualStyleBackColor = true;
            this.ButtonGone.Click += new System.EventHandler(this.ButtonGone_Click);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.BackgroundImage = global::WorkTime.Properties.Resources.settingsIcon;
            this.ButtonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonSettings.FlatAppearance.BorderSize = 0;
            this.ButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSettings.Location = new System.Drawing.Point(279, 12);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(25, 25);
            this.ButtonSettings.TabIndex = 9;
            this.ButtonSettings.UseVisualStyleBackColor = true;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 608);
            this.Controls.Add(this.ButtonSettings);
            this.Controls.Add(this.ButtonGone);
            this.Controls.Add(this.labelTimeWeekLeft);
            this.Controls.Add(this.labelWeekLeft);
            this.Controls.Add(this.labelNow);
            this.Controls.Add(this.labelGo);
            this.Controls.Add(this.labelTimeGo);
            this.Controls.Add(this.MaskedTextBoxCame);
            this.Controls.Add(this.labelTimeNow);
            this.Controls.Add(this.buttonCame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCame;
        private System.Windows.Forms.Label labelTimeNow;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxCame;
        private System.Windows.Forms.Label labelTimeGo;
        private System.Windows.Forms.Label labelGo;
        private System.Windows.Forms.Label labelNow;
        private System.Windows.Forms.Label labelWeekLeft;
        private System.Windows.Forms.Label labelTimeWeekLeft;
        private System.Windows.Forms.Button ButtonGone;
        private System.Windows.Forms.Button ButtonSettings;
    }
}

