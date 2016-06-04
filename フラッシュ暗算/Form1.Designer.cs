namespace フラッシュ暗算
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ゲームToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.難易度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.初級ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中級ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上級ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.桁数変更ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.桁ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ケタToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ケタToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ケタToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ゲームToolStripMenuItem,
            this.難易度ToolStripMenuItem,
            this.桁数変更ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ゲームToolStripMenuItem
            // 
            this.ゲームToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開始ToolStripMenuItem});
            this.ゲームToolStripMenuItem.Name = "ゲームToolStripMenuItem";
            this.ゲームToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.ゲームToolStripMenuItem.Text = "ゲーム";
            // 
            // 開始ToolStripMenuItem
            // 
            this.開始ToolStripMenuItem.Name = "開始ToolStripMenuItem";
            this.開始ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.開始ToolStripMenuItem.Text = "開始";
            this.開始ToolStripMenuItem.Click += new System.EventHandler(this.開始ToolStripMenuItem_Click);
            // 
            // 難易度ToolStripMenuItem
            // 
            this.難易度ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.初級ToolStripMenuItem,
            this.中級ToolStripMenuItem,
            this.上級ToolStripMenuItem});
            this.難易度ToolStripMenuItem.Name = "難易度ToolStripMenuItem";
            this.難易度ToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.難易度ToolStripMenuItem.Text = "難易度";
            // 
            // 初級ToolStripMenuItem
            // 
            this.初級ToolStripMenuItem.Name = "初級ToolStripMenuItem";
            this.初級ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.初級ToolStripMenuItem.Text = "初級";
            this.初級ToolStripMenuItem.Click += new System.EventHandler(this.初級ToolStripMenuItem_Click);
            // 
            // 中級ToolStripMenuItem
            // 
            this.中級ToolStripMenuItem.Name = "中級ToolStripMenuItem";
            this.中級ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.中級ToolStripMenuItem.Text = "中級";
            this.中級ToolStripMenuItem.Click += new System.EventHandler(this.中級ToolStripMenuItem_Click);
            // 
            // 上級ToolStripMenuItem
            // 
            this.上級ToolStripMenuItem.Name = "上級ToolStripMenuItem";
            this.上級ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.上級ToolStripMenuItem.Text = "上級";
            this.上級ToolStripMenuItem.Click += new System.EventHandler(this.上級ToolStripMenuItem_Click);
            // 
            // 桁数変更ToolStripMenuItem
            // 
            this.桁数変更ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.桁ToolStripMenuItem,
            this.ケタToolStripMenuItem,
            this.ケタToolStripMenuItem1,
            this.ケタToolStripMenuItem2});
            this.桁数変更ToolStripMenuItem.Name = "桁数変更ToolStripMenuItem";
            this.桁数変更ToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.桁数変更ToolStripMenuItem.Text = "桁数変更";
            // 
            // 桁ToolStripMenuItem
            // 
            this.桁ToolStripMenuItem.Name = "桁ToolStripMenuItem";
            this.桁ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.桁ToolStripMenuItem.Text = "１ケタ";
            this.桁ToolStripMenuItem.Click += new System.EventHandler(this.桁ToolStripMenuItem_Click);
            // 
            // ケタToolStripMenuItem
            // 
            this.ケタToolStripMenuItem.Name = "ケタToolStripMenuItem";
            this.ケタToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ケタToolStripMenuItem.Text = "２ケタ";
            this.ケタToolStripMenuItem.Click += new System.EventHandler(this.ケタToolStripMenuItem_Click);
            // 
            // ケタToolStripMenuItem1
            // 
            this.ケタToolStripMenuItem1.Name = "ケタToolStripMenuItem1";
            this.ケタToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ケタToolStripMenuItem1.Text = "３ケタ";
            this.ケタToolStripMenuItem1.Click += new System.EventHandler(this.ケタToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(207, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 97);
            this.label1.TabIndex = 1;
            this.label1.Text = "暗算";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(46, 223);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 42);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(375, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "答える";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ケタToolStripMenuItem2
            // 
            this.ケタToolStripMenuItem2.Name = "ケタToolStripMenuItem2";
            this.ケタToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.ケタToolStripMenuItem2.Text = "４ケタ";
            this.ケタToolStripMenuItem2.Click += new System.EventHandler(this.ケタToolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.Text = "フラッシュ暗算";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ゲームToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 難易度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 初級ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中級ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上級ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 桁数変更ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 桁ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ケタToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ケタToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem ケタToolStripMenuItem2;
    }
}

