
namespace UI
{
    partial class IntroductionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroductionForm));
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonRules = new System.Windows.Forms.Button();
            this.LabelRules = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.BackgroundImage = global::UI.Properties.Resources.black;
            resources.ApplyResources(this.ButtonStart, "ButtonStart");
            this.ButtonStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonRules
            // 
            this.ButtonRules.BackgroundImage = global::UI.Properties.Resources.black;
            resources.ApplyResources(this.ButtonRules, "ButtonRules");
            this.ButtonRules.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonRules.Name = "ButtonRules";
            this.ButtonRules.UseVisualStyleBackColor = false;
            this.ButtonRules.Click += new System.EventHandler(this.ButtonRules_Click);
            // 
            // LabelRules
            // 
            resources.ApplyResources(this.LabelRules, "LabelRules");
            this.LabelRules.BackColor = System.Drawing.Color.Transparent;
            this.LabelRules.Name = "LabelRules";
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackgroundImage = global::UI.Properties.Resources.black;
            resources.ApplyResources(this.ButtonBack, "ButtonBack");
            this.ButtonBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.UseVisualStyleBackColor = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // IntroductionForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.LabelRules);
            this.Controls.Add(this.ButtonRules);
            this.Controls.Add(this.ButtonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "IntroductionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonRules;
        private System.Windows.Forms.Label LabelRules;
        private System.Windows.Forms.Button ButtonBack;
    }
}