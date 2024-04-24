namespace jpLocationInfo
{
    partial class ChiikiInfo
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.Kanto = new System.Windows.Forms.Button();
            this.Tohoku = new System.Windows.Forms.Button();
            this.Hokkaido = new System.Windows.Forms.Button();
            this.Chubu = new System.Windows.Forms.Button();
            this.Kinki = new System.Windows.Forms.Button();
            this.Chugoku = new System.Windows.Forms.Button();
            this.Shikoku = new System.Windows.Forms.Button();
            this.Kyuoki = new System.Windows.Forms.Button();
            this.searchMode = new System.Windows.Forms.Button();
            this.locateSelection = new System.Windows.Forms.ListBox();
            this.locationOfSelection = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.backText = new System.Windows.Forms.Label();
            this.debug = new System.Windows.Forms.Button();
            this.debugLog = new System.Windows.Forms.ListBox();
            this.debugReset = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Kanto
            // 
            this.Kanto.BackColor = System.Drawing.Color.Silver;
            this.Kanto.FlatAppearance.BorderSize = 0;
            this.Kanto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kanto.Font = new System.Drawing.Font("NC-ニューセザンヌ DB", 20.25F, System.Drawing.FontStyle.Bold);
            this.Kanto.Location = new System.Drawing.Point(31, 188);
            this.Kanto.Name = "Kanto";
            this.Kanto.Size = new System.Drawing.Size(310, 71);
            this.Kanto.TabIndex = 0;
            this.Kanto.Text = "関東";
            this.Kanto.UseVisualStyleBackColor = false;
            this.Kanto.Click += new System.EventHandler(this.Kanto_Click);
            // 
            // Tohoku
            // 
            this.Tohoku.BackColor = System.Drawing.Color.Silver;
            this.Tohoku.FlatAppearance.BorderSize = 0;
            this.Tohoku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tohoku.Font = new System.Drawing.Font("NC-ニューセザンヌ DB", 20.25F, System.Drawing.FontStyle.Bold);
            this.Tohoku.Location = new System.Drawing.Point(31, 111);
            this.Tohoku.Name = "Tohoku";
            this.Tohoku.Size = new System.Drawing.Size(310, 71);
            this.Tohoku.TabIndex = 1;
            this.Tohoku.Text = "東北";
            this.Tohoku.UseVisualStyleBackColor = false;
            this.Tohoku.Click += new System.EventHandler(this.Tohoku_Click);
            // 
            // Hokkaido
            // 
            this.Hokkaido.BackColor = System.Drawing.Color.Silver;
            this.Hokkaido.FlatAppearance.BorderSize = 0;
            this.Hokkaido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hokkaido.Font = new System.Drawing.Font("NC-ニューセザンヌ DB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hokkaido.Location = new System.Drawing.Point(31, 34);
            this.Hokkaido.Name = "Hokkaido";
            this.Hokkaido.Size = new System.Drawing.Size(310, 71);
            this.Hokkaido.TabIndex = 2;
            this.Hokkaido.Text = "北海道";
            this.Hokkaido.UseVisualStyleBackColor = false;
            this.Hokkaido.Click += new System.EventHandler(this.Hokkaido_Click);
            // 
            // Chubu
            // 
            this.Chubu.BackColor = System.Drawing.Color.Silver;
            this.Chubu.FlatAppearance.BorderSize = 0;
            this.Chubu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chubu.Font = new System.Drawing.Font("NC-ニューセザンヌ DB", 20.25F, System.Drawing.FontStyle.Bold);
            this.Chubu.Location = new System.Drawing.Point(31, 265);
            this.Chubu.Name = "Chubu";
            this.Chubu.Size = new System.Drawing.Size(310, 71);
            this.Chubu.TabIndex = 3;
            this.Chubu.Text = "中部";
            this.Chubu.UseVisualStyleBackColor = false;
            this.Chubu.Click += new System.EventHandler(this.Chubu_Click);
            // 
            // Kinki
            // 
            this.Kinki.BackColor = System.Drawing.Color.Silver;
            this.Kinki.FlatAppearance.BorderSize = 0;
            this.Kinki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kinki.Font = new System.Drawing.Font("NC-ニューセザンヌ DB", 20.25F, System.Drawing.FontStyle.Bold);
            this.Kinki.Location = new System.Drawing.Point(31, 342);
            this.Kinki.Name = "Kinki";
            this.Kinki.Size = new System.Drawing.Size(310, 71);
            this.Kinki.TabIndex = 4;
            this.Kinki.Text = "近畿";
            this.Kinki.UseVisualStyleBackColor = false;
            this.Kinki.Click += new System.EventHandler(this.Kinki_Click);
            // 
            // Chugoku
            // 
            this.Chugoku.BackColor = System.Drawing.Color.Silver;
            this.Chugoku.FlatAppearance.BorderSize = 0;
            this.Chugoku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chugoku.Font = new System.Drawing.Font("NC-ニューセザンヌ DB", 20.25F, System.Drawing.FontStyle.Bold);
            this.Chugoku.Location = new System.Drawing.Point(31, 419);
            this.Chugoku.Name = "Chugoku";
            this.Chugoku.Size = new System.Drawing.Size(310, 71);
            this.Chugoku.TabIndex = 5;
            this.Chugoku.Text = "中国";
            this.Chugoku.UseVisualStyleBackColor = false;
            this.Chugoku.Click += new System.EventHandler(this.Chugoku_Click);
            // 
            // Shikoku
            // 
            this.Shikoku.BackColor = System.Drawing.Color.Silver;
            this.Shikoku.FlatAppearance.BorderSize = 0;
            this.Shikoku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Shikoku.Font = new System.Drawing.Font("NC-ニューセザンヌ DB", 20.25F, System.Drawing.FontStyle.Bold);
            this.Shikoku.Location = new System.Drawing.Point(31, 496);
            this.Shikoku.Name = "Shikoku";
            this.Shikoku.Size = new System.Drawing.Size(310, 71);
            this.Shikoku.TabIndex = 6;
            this.Shikoku.Text = "四国";
            this.Shikoku.UseVisualStyleBackColor = false;
            this.Shikoku.Click += new System.EventHandler(this.Shikoku_Click);
            // 
            // Kyuoki
            // 
            this.Kyuoki.BackColor = System.Drawing.Color.Silver;
            this.Kyuoki.FlatAppearance.BorderSize = 0;
            this.Kyuoki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kyuoki.Font = new System.Drawing.Font("NC-ニューセザンヌ DB", 20.25F, System.Drawing.FontStyle.Bold);
            this.Kyuoki.Location = new System.Drawing.Point(31, 573);
            this.Kyuoki.Name = "Kyuoki";
            this.Kyuoki.Size = new System.Drawing.Size(310, 71);
            this.Kyuoki.TabIndex = 7;
            this.Kyuoki.Text = "九州沖縄";
            this.Kyuoki.UseVisualStyleBackColor = false;
            this.Kyuoki.Click += new System.EventHandler(this.Kyuoki_Click);
            // 
            // searchMode
            // 
            this.searchMode.Font = new System.Drawing.Font("NC-ニューセザンヌ DB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchMode.Location = new System.Drawing.Point(400, 24);
            this.searchMode.Name = "searchMode";
            this.searchMode.Size = new System.Drawing.Size(112, 42);
            this.searchMode.TabIndex = 10;
            this.searchMode.Text = "検索";
            this.searchMode.UseVisualStyleBackColor = true;
            this.searchMode.Click += new System.EventHandler(this.searchMode_Click);
            // 
            // locateSelection
            // 
            this.locateSelection.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.locateSelection.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.locateSelection.ForeColor = System.Drawing.SystemColors.WindowText;
            this.locateSelection.FormattingEnabled = true;
            this.locateSelection.ItemHeight = 28;
            this.locateSelection.Location = new System.Drawing.Point(447, 122);
            this.locateSelection.Name = "locateSelection";
            this.locateSelection.Size = new System.Drawing.Size(685, 480);
            this.locateSelection.TabIndex = 11;
            // 
            // locationOfSelection
            // 
            this.locationOfSelection.AutoSize = true;
            this.locationOfSelection.Font = new System.Drawing.Font("HGP創英角ｺﾞｼｯｸUB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationOfSelection.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.locationOfSelection.Location = new System.Drawing.Point(472, 89);
            this.locationOfSelection.Name = "locationOfSelection";
            this.locationOfSelection.Size = new System.Drawing.Size(292, 16);
            this.locationOfSelection.TabIndex = 12;
            this.locationOfSelection.Text = "選択された位置はこっちらに表示されます。";
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(1021, 64);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(50, 50);
            this.back.TabIndex = 13;
            this.back.Text = "◀";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // backText
            // 
            this.backText.AutoSize = true;
            this.backText.Font = new System.Drawing.Font("HGP創英角ｺﾞｼｯｸUB", 10F);
            this.backText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backText.Location = new System.Drawing.Point(1032, 46);
            this.backText.Name = "backText";
            this.backText.Size = new System.Drawing.Size(33, 14);
            this.backText.TabIndex = 14;
            this.backText.Text = "戻る";
            // 
            // debug
            // 
            this.debug.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debug.Location = new System.Drawing.Point(1160, 12);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(92, 31);
            this.debug.TabIndex = 15;
            this.debug.Text = "debug";
            this.debug.UseVisualStyleBackColor = true;
            this.debug.Click += new System.EventHandler(this.debug_Click);
            // 
            // debugLog
            // 
            this.debugLog.Font = new System.Drawing.Font("HGPｺﾞｼｯｸE", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.debugLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.debugLog.FormattingEnabled = true;
            this.debugLog.ItemHeight = 16;
            this.debugLog.Location = new System.Drawing.Point(1180, 56);
            this.debugLog.Name = "debugLog";
            this.debugLog.Size = new System.Drawing.Size(426, 596);
            this.debugLog.TabIndex = 16;
            // 
            // debugReset
            // 
            this.debugReset.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugReset.Location = new System.Drawing.Point(1493, 12);
            this.debugReset.Name = "debugReset";
            this.debugReset.Size = new System.Drawing.Size(104, 31);
            this.debugReset.TabIndex = 17;
            this.debugReset.Text = "RESET";
            this.debugReset.UseVisualStyleBackColor = true;
            this.debugReset.Click += new System.EventHandler(this.debugReset_Click);
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(1077, 64);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(50, 50);
            this.next.TabIndex = 18;
            this.next.Text = "▶";
            this.next.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HGP創英角ｺﾞｼｯｸUB", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1084, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "選択";
            // 
            // ChiikiInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.next);
            this.Controls.Add(this.debugReset);
            this.Controls.Add(this.debugLog);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.backText);
            this.Controls.Add(this.back);
            this.Controls.Add(this.locationOfSelection);
            this.Controls.Add(this.locateSelection);
            this.Controls.Add(this.searchMode);
            this.Controls.Add(this.Kyuoki);
            this.Controls.Add(this.Shikoku);
            this.Controls.Add(this.Chugoku);
            this.Controls.Add(this.Kinki);
            this.Controls.Add(this.Chubu);
            this.Controls.Add(this.Hokkaido);
            this.Controls.Add(this.Tohoku);
            this.Controls.Add(this.Kanto);
            this.Name = "ChiikiInfo";
            this.Text = "地域名情報";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Kanto;
        private System.Windows.Forms.Button Tohoku;
        private System.Windows.Forms.Button Hokkaido;
        private System.Windows.Forms.Button Chubu;
        private System.Windows.Forms.Button Kinki;
        private System.Windows.Forms.Button Chugoku;
        private System.Windows.Forms.Button Shikoku;
        private System.Windows.Forms.Button Kyuoki;
        private System.Windows.Forms.Button searchMode;
        private System.Windows.Forms.ListBox locateSelection;
        private System.Windows.Forms.Label locationOfSelection;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label backText;
        private System.Windows.Forms.Button debug;
        private System.Windows.Forms.ListBox debugLog;
        private System.Windows.Forms.Button debugReset;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label label1;
    }
}

