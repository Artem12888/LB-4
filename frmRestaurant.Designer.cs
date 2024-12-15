namespace Lab4
{
    partial class frmRestaurant
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
            this.lstMenu = new System.Windows.Forms.ListBox();
            this.lstZakaz = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewDish = new System.Windows.Forms.TextBox();
            this.btnAddToMenu = new System.Windows.Forms.Button();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMenu
            // 
            this.lstMenu.BackColor = System.Drawing.Color.White;
            this.lstMenu.ForeColor = System.Drawing.Color.Black;
            this.lstMenu.FormattingEnabled = true;
            this.lstMenu.ItemHeight = 16;
            this.lstMenu.Items.AddRange(new object[] {
            "Борщ - 120",
            "Паста Карбонара - 250",
            "Салат Цезарь - 180",
            "Пицца Маргарита - 300",
            "Куриный суп с лапшой - 150",
            "Бифштекс с картофелем - 350",
            "Ризотто с грибами - 270",
            "Роллы Филадельфия - 400",
            "Чизкейк Нью-Йорк - 200",
            "Сок апельсиновый - 100"});
            this.lstMenu.Location = new System.Drawing.Point(45, 152);
            this.lstMenu.Name = "lstMenu";
            this.lstMenu.Size = new System.Drawing.Size(259, 132);
            this.lstMenu.TabIndex = 0;
            // 
            // lstZakaz
            // 
            this.lstZakaz.BackColor = System.Drawing.Color.White;
            this.lstZakaz.ForeColor = System.Drawing.Color.Black;
            this.lstZakaz.FormattingEnabled = true;
            this.lstZakaz.ItemHeight = 16;
            this.lstZakaz.Location = new System.Drawing.Point(466, 152);
            this.lstZakaz.Name = "lstZakaz";
            this.lstZakaz.Size = new System.Drawing.Size(259, 132);
            this.lstZakaz.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(331, 162);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 42);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(331, 237);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 38);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Убрать";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(466, 296);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 38);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Заказать";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "МЕНЮ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "ЗАКАЗ";
            // 
            // txtNewDish
            // 
            this.txtNewDish.BackColor = System.Drawing.Color.White;
            this.txtNewDish.ForeColor = System.Drawing.Color.Black;
            this.txtNewDish.Location = new System.Drawing.Point(45, 304);
            this.txtNewDish.Name = "txtNewDish";
            this.txtNewDish.Size = new System.Drawing.Size(259, 22);
            this.txtNewDish.TabIndex = 7;
            // 
            // btnAddToMenu
            // 
            this.btnAddToMenu.Location = new System.Drawing.Point(91, 345);
            this.btnAddToMenu.Name = "btnAddToMenu";
            this.btnAddToMenu.Size = new System.Drawing.Size(156, 38);
            this.btnAddToMenu.TabIndex = 8;
            this.btnAddToMenu.Text = "Добавить в меню";
            this.btnAddToMenu.UseVisualStyleBackColor = true;
            this.btnAddToMenu.Click += new System.EventHandler(this.btnAddToMenu_Click);
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Location = new System.Drawing.Point(594, 296);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(131, 38);
            this.btnClearOrder.TabIndex = 9;
            this.btnClearOrder.Text = "Очистить заказ";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // frmRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearOrder);
            this.Controls.Add(this.btnAddToMenu);
            this.Controls.Add(this.txtNewDish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstZakaz);
            this.Controls.Add(this.lstMenu);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmRestaurant";
            this.Text = "frmRestaurant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMenu;
        private System.Windows.Forms.ListBox lstZakaz;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewDish;
        private System.Windows.Forms.Button btnAddToMenu;
        private System.Windows.Forms.Button btnClearOrder;
    }
}

