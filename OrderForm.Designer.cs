namespace Pizza_Project
{
    partial class frm_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Order));
            this.gb_Size = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gb_Toppings = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPlace = new System.Windows.Forms.Label();
            this.lbFinal_Place = new System.Windows.Forms.Label();
            this.lbCrustType = new System.Windows.Forms.Label();
            this.lbFinal_Crust_Type = new System.Windows.Forms.Label();
            this.lbToppings = new System.Windows.Forms.Label();
            this.lbFinal_Toppings = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbFinal_Size = new System.Windows.Forms.Label();
            this.chkTometo = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkBeef = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.chkTurkey = new System.Windows.Forms.CheckBox();
            this.gb_Crust_Type = new System.Windows.Forms.GroupBox();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gb_Where_To_Eat = new System.Windows.Forms.GroupBox();
            this.rbTake_Out = new System.Windows.Forms.RadioButton();
            this.rbEat_In = new System.Windows.Forms.RadioButton();
            this.Total_Price = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btn_To_Purchase_frm = new System.Windows.Forms.Button();
            this.btn_To_Main_frm = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPlace = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCrust = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gb_Size.SuspendLayout();
            this.gb_Toppings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_Crust_Type.SuspendLayout();
            this.gb_Where_To_Eat.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Size
            // 
            this.gb_Size.BackColor = System.Drawing.Color.Transparent;
            this.gb_Size.Controls.Add(this.rbLarge);
            this.gb_Size.Controls.Add(this.rbMedium);
            this.gb_Size.Controls.Add(this.rbSmall);
            this.gb_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Size.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gb_Size.Location = new System.Drawing.Point(15, 25);
            this.gb_Size.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Size.Name = "gb_Size";
            this.gb_Size.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Size.Size = new System.Drawing.Size(163, 166);
            this.gb_Size.TabIndex = 0;
            this.gb_Size.TabStop = false;
            this.gb_Size.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(23, 103);
            this.rbLarge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(77, 26);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "30";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(23, 71);
            this.rbMedium.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(93, 26);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(23, 39);
            this.rbSmall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(75, 26);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "10";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gb_Toppings
            // 
            this.gb_Toppings.BackColor = System.Drawing.Color.Transparent;
            this.gb_Toppings.Controls.Add(this.groupBox1);
            this.gb_Toppings.Controls.Add(this.chkTometo);
            this.gb_Toppings.Controls.Add(this.chkMushrooms);
            this.gb_Toppings.Controls.Add(this.chkBeef);
            this.gb_Toppings.Controls.Add(this.chkOnion);
            this.gb_Toppings.Controls.Add(this.chkCheese);
            this.gb_Toppings.Controls.Add(this.chkTurkey);
            this.gb_Toppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Toppings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gb_Toppings.Location = new System.Drawing.Point(213, 25);
            this.gb_Toppings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Toppings.Name = "gb_Toppings";
            this.gb_Toppings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Toppings.Size = new System.Drawing.Size(183, 278);
            this.gb_Toppings.TabIndex = 3;
            this.gb_Toppings.TabStop = false;
            this.gb_Toppings.Text = "Toppings";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbPlace);
            this.groupBox1.Controls.Add(this.lbFinal_Place);
            this.groupBox1.Controls.Add(this.lbCrustType);
            this.groupBox1.Controls.Add(this.lbFinal_Crust_Type);
            this.groupBox1.Controls.Add(this.lbToppings);
            this.groupBox1.Controls.Add(this.lbFinal_Toppings);
            this.groupBox1.Controls.Add(this.lbSize);
            this.groupBox1.Controls.Add(this.lbFinal_Size);
            this.groupBox1.Font = new System.Drawing.Font("Wide Latin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(295, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(287, 238);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Summary";
            // 
            // lbPlace
            // 
            this.lbPlace.AutoSize = true;
            this.lbPlace.ForeColor = System.Drawing.Color.Red;
            this.lbPlace.Location = new System.Drawing.Point(187, 209);
            this.lbPlace.Name = "lbPlace";
            this.lbPlace.Size = new System.Drawing.Size(61, 16);
            this.lbPlace.TabIndex = 7;
            this.lbPlace.Text = "Size:";
            // 
            // lbFinal_Place
            // 
            this.lbFinal_Place.AutoSize = true;
            this.lbFinal_Place.Location = new System.Drawing.Point(17, 209);
            this.lbFinal_Place.Name = "lbFinal_Place";
            this.lbFinal_Place.Size = new System.Drawing.Size(163, 16);
            this.lbFinal_Place.TabIndex = 6;
            this.lbFinal_Place.Text = "Where To Eat:";
            // 
            // lbCrustType
            // 
            this.lbCrustType.AutoSize = true;
            this.lbCrustType.ForeColor = System.Drawing.Color.Red;
            this.lbCrustType.Location = new System.Drawing.Point(157, 167);
            this.lbCrustType.Name = "lbCrustType";
            this.lbCrustType.Size = new System.Drawing.Size(61, 16);
            this.lbCrustType.TabIndex = 5;
            this.lbCrustType.Text = "Size:";
            // 
            // lbFinal_Crust_Type
            // 
            this.lbFinal_Crust_Type.AutoSize = true;
            this.lbFinal_Crust_Type.Location = new System.Drawing.Point(17, 167);
            this.lbFinal_Crust_Type.Name = "lbFinal_Crust_Type";
            this.lbFinal_Crust_Type.Size = new System.Drawing.Size(135, 16);
            this.lbFinal_Crust_Type.TabIndex = 4;
            this.lbFinal_Crust_Type.Text = "Crust Type:";
            // 
            // lbToppings
            // 
            this.lbToppings.AutoSize = true;
            this.lbToppings.ForeColor = System.Drawing.Color.Red;
            this.lbToppings.Location = new System.Drawing.Point(139, 73);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(61, 16);
            this.lbToppings.TabIndex = 3;
            this.lbToppings.Text = "Size:";
            // 
            // lbFinal_Toppings
            // 
            this.lbFinal_Toppings.AutoSize = true;
            this.lbFinal_Toppings.Location = new System.Drawing.Point(17, 73);
            this.lbFinal_Toppings.Name = "lbFinal_Toppings";
            this.lbFinal_Toppings.Size = new System.Drawing.Size(115, 16);
            this.lbFinal_Toppings.TabIndex = 2;
            this.lbFinal_Toppings.Text = "Toppings:";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.ForeColor = System.Drawing.Color.Red;
            this.lbSize.Location = new System.Drawing.Point(84, 34);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(61, 16);
            this.lbSize.TabIndex = 1;
            this.lbSize.Text = "Size:";
            // 
            // lbFinal_Size
            // 
            this.lbFinal_Size.AutoSize = true;
            this.lbFinal_Size.Location = new System.Drawing.Point(17, 34);
            this.lbFinal_Size.Name = "lbFinal_Size";
            this.lbFinal_Size.Size = new System.Drawing.Size(61, 16);
            this.lbFinal_Size.TabIndex = 0;
            this.lbFinal_Size.Text = "Size:";
            // 
            // chkTometo
            // 
            this.chkTometo.AutoSize = true;
            this.chkTometo.Location = new System.Drawing.Point(23, 116);
            this.chkTometo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkTometo.Name = "chkTometo";
            this.chkTometo.Size = new System.Drawing.Size(93, 26);
            this.chkTometo.TabIndex = 2;
            this.chkTometo.Tag = "5";
            this.chkTometo.Text = "Tometo";
            this.chkTometo.UseVisualStyleBackColor = true;
            this.chkTometo.CheckedChanged += new System.EventHandler(this.chkTometo_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(23, 230);
            this.chkMushrooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(124, 26);
            this.chkMushrooms.TabIndex = 5;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkBeef
            // 
            this.chkBeef.AutoSize = true;
            this.chkBeef.Location = new System.Drawing.Point(23, 78);
            this.chkBeef.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkBeef.Name = "chkBeef";
            this.chkBeef.Size = new System.Drawing.Size(69, 26);
            this.chkBeef.TabIndex = 1;
            this.chkBeef.Tag = "5";
            this.chkBeef.Text = "Beef";
            this.chkBeef.UseVisualStyleBackColor = true;
            this.chkBeef.CheckedChanged += new System.EventHandler(this.chkBeef_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(23, 192);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(80, 26);
            this.chkOnion.TabIndex = 4;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Location = new System.Drawing.Point(23, 39);
            this.chkCheese.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(94, 26);
            this.chkCheese.TabIndex = 0;
            this.chkCheese.Tag = "5";
            this.chkCheese.Text = "Cheese";
            this.chkCheese.UseVisualStyleBackColor = true;
            this.chkCheese.CheckedChanged += new System.EventHandler(this.chkCheese_CheckedChanged);
            // 
            // chkTurkey
            // 
            this.chkTurkey.AutoSize = true;
            this.chkTurkey.Location = new System.Drawing.Point(23, 154);
            this.chkTurkey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkTurkey.Name = "chkTurkey";
            this.chkTurkey.Size = new System.Drawing.Size(88, 26);
            this.chkTurkey.TabIndex = 3;
            this.chkTurkey.Tag = "5";
            this.chkTurkey.Text = "Turkey";
            this.chkTurkey.UseVisualStyleBackColor = true;
            this.chkTurkey.CheckedChanged += new System.EventHandler(this.chkTurkey_CheckedChanged);
            // 
            // gb_Crust_Type
            // 
            this.gb_Crust_Type.BackColor = System.Drawing.Color.Transparent;
            this.gb_Crust_Type.Controls.Add(this.rbThick);
            this.gb_Crust_Type.Controls.Add(this.rbThin);
            this.gb_Crust_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Crust_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gb_Crust_Type.Location = new System.Drawing.Point(15, 209);
            this.gb_Crust_Type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Crust_Type.Name = "gb_Crust_Type";
            this.gb_Crust_Type.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Crust_Type.Size = new System.Drawing.Size(163, 107);
            this.gb_Crust_Type.TabIndex = 1;
            this.gb_Crust_Type.TabStop = false;
            this.gb_Crust_Type.Text = "Crust Type";
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Location = new System.Drawing.Point(23, 71);
            this.rbThick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(75, 26);
            this.rbThick.TabIndex = 1;
            this.rbThick.TabStop = true;
            this.rbThick.Tag = "10";
            this.rbThick.Text = "Thick";
            this.rbThick.UseVisualStyleBackColor = true;
            this.rbThick.CheckedChanged += new System.EventHandler(this.rbThick_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Location = new System.Drawing.Point(23, 39);
            this.rbThin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(67, 26);
            this.rbThin.TabIndex = 0;
            this.rbThin.TabStop = true;
            this.rbThin.Text = "Thin";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // gb_Where_To_Eat
            // 
            this.gb_Where_To_Eat.BackColor = System.Drawing.Color.Transparent;
            this.gb_Where_To_Eat.Controls.Add(this.rbTake_Out);
            this.gb_Where_To_Eat.Controls.Add(this.rbEat_In);
            this.gb_Where_To_Eat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Where_To_Eat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gb_Where_To_Eat.Location = new System.Drawing.Point(15, 335);
            this.gb_Where_To_Eat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Where_To_Eat.Name = "gb_Where_To_Eat";
            this.gb_Where_To_Eat.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Where_To_Eat.Size = new System.Drawing.Size(163, 107);
            this.gb_Where_To_Eat.TabIndex = 2;
            this.gb_Where_To_Eat.TabStop = false;
            this.gb_Where_To_Eat.Text = "Where To Eat";
            // 
            // rbTake_Out
            // 
            this.rbTake_Out.AutoSize = true;
            this.rbTake_Out.Location = new System.Drawing.Point(23, 71);
            this.rbTake_Out.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTake_Out.Name = "rbTake_Out";
            this.rbTake_Out.Size = new System.Drawing.Size(106, 26);
            this.rbTake_Out.TabIndex = 1;
            this.rbTake_Out.TabStop = true;
            this.rbTake_Out.Tag = "0";
            this.rbTake_Out.Text = "Take Out";
            this.rbTake_Out.UseVisualStyleBackColor = true;
            this.rbTake_Out.CheckedChanged += new System.EventHandler(this.rbTake_Out_CheckedChanged);
            // 
            // rbEat_In
            // 
            this.rbEat_In.AutoSize = true;
            this.rbEat_In.Location = new System.Drawing.Point(23, 39);
            this.rbEat_In.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbEat_In.Name = "rbEat_In";
            this.rbEat_In.Size = new System.Drawing.Size(77, 26);
            this.rbEat_In.TabIndex = 0;
            this.rbEat_In.TabStop = true;
            this.rbEat_In.Tag = "0";
            this.rbEat_In.Text = "Eat In";
            this.rbEat_In.UseVisualStyleBackColor = true;
            this.rbEat_In.CheckedChanged += new System.EventHandler(this.rbEat_In_CheckedChanged);
            // 
            // Total_Price
            // 
            this.Total_Price.AutoSize = true;
            this.Total_Price.BackColor = System.Drawing.Color.Transparent;
            this.Total_Price.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Total_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Total_Price.Location = new System.Drawing.Point(17, 366);
            this.Total_Price.Name = "Total_Price";
            this.Total_Price.Size = new System.Drawing.Size(102, 22);
            this.Total_Price.TabIndex = 10;
            this.Total_Price.Text = "Total Price:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(125, 353);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 38);
            this.lblPrice.TabIndex = 11;
            // 
            // btn_To_Purchase_frm
            // 
            this.btn_To_Purchase_frm.BackColor = System.Drawing.Color.Transparent;
            this.btn_To_Purchase_frm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_To_Purchase_frm.Font = new System.Drawing.Font("Wide Latin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_To_Purchase_frm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_To_Purchase_frm.Location = new System.Drawing.Point(213, 369);
            this.btn_To_Purchase_frm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_To_Purchase_frm.Name = "btn_To_Purchase_frm";
            this.btn_To_Purchase_frm.Size = new System.Drawing.Size(107, 43);
            this.btn_To_Purchase_frm.TabIndex = 4;
            this.btn_To_Purchase_frm.Text = "Order";
            this.btn_To_Purchase_frm.UseVisualStyleBackColor = false;
            this.btn_To_Purchase_frm.Click += new System.EventHandler(this.btn_To_Purchase_frm_Click);
            // 
            // btn_To_Main_frm
            // 
            this.btn_To_Main_frm.BackColor = System.Drawing.Color.Transparent;
            this.btn_To_Main_frm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_To_Main_frm.Font = new System.Drawing.Font("Wide Latin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_To_Main_frm.ForeColor = System.Drawing.Color.Red;
            this.btn_To_Main_frm.Location = new System.Drawing.Point(348, 369);
            this.btn_To_Main_frm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_To_Main_frm.Name = "btn_To_Main_frm";
            this.btn_To_Main_frm.Size = new System.Drawing.Size(107, 43);
            this.btn_To_Main_frm.TabIndex = 5;
            this.btn_To_Main_frm.Text = "Reset";
            this.btn_To_Main_frm.UseVisualStyleBackColor = false;
            this.btn_To_Main_frm.Click += new System.EventHandler(this.btn_To_Main_frm_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblPlace);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblCrust);
            this.groupBox2.Controls.Add(this.lblPrice);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Total_Price);
            this.groupBox2.Controls.Add(this.lblToppings);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblSize);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Wide Latin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(492, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(272, 417);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Summary";
            // 
            // lblPlace
            // 
            this.lblPlace.ForeColor = System.Drawing.Color.Red;
            this.lblPlace.Location = new System.Drawing.Point(13, 319);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(251, 18);
            this.lblPlace.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Where To Eat:";
            // 
            // lblCrust
            // 
            this.lblCrust.ForeColor = System.Drawing.Color.Red;
            this.lblCrust.Location = new System.Drawing.Point(17, 256);
            this.lblCrust.Name = "lblCrust";
            this.lblCrust.Size = new System.Drawing.Size(246, 25);
            this.lblCrust.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Crust Type:";
            // 
            // lblToppings
            // 
            this.lblToppings.ForeColor = System.Drawing.Color.Red;
            this.lblToppings.Location = new System.Drawing.Point(20, 129);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(243, 89);
            this.lblToppings.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Toppings:";
            // 
            // lblSize
            // 
            this.lblSize.ForeColor = System.Drawing.Color.Red;
            this.lblSize.Location = new System.Drawing.Point(20, 60);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(243, 16);
            this.lblSize.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Size:";
            // 
            // frm_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza_Project.Properties.Resources.photo_2024_07_16_20_52_06;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_To_Main_frm);
            this.Controls.Add(this.btn_To_Purchase_frm);
            this.Controls.Add(this.gb_Where_To_Eat);
            this.Controls.Add(this.gb_Crust_Type);
            this.Controls.Add(this.gb_Toppings);
            this.Controls.Add(this.gb_Size);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Order";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.frm_Order_Load);
            this.gb_Size.ResumeLayout(false);
            this.gb_Size.PerformLayout();
            this.gb_Toppings.ResumeLayout(false);
            this.gb_Toppings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_Crust_Type.ResumeLayout(false);
            this.gb_Crust_Type.PerformLayout();
            this.gb_Where_To_Eat.ResumeLayout(false);
            this.gb_Where_To_Eat.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Size;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gb_Toppings;
        private System.Windows.Forms.GroupBox gb_Crust_Type;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbThin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gb_Where_To_Eat;
        private System.Windows.Forms.RadioButton rbTake_Out;
        private System.Windows.Forms.RadioButton rbEat_In;
        private System.Windows.Forms.Label Total_Price;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btn_To_Purchase_frm;
        private System.Windows.Forms.Button btn_To_Main_frm;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.CheckBox chkTometo;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkTurkey;
        private System.Windows.Forms.CheckBox chkBeef;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbPlace;
        private System.Windows.Forms.Label lbFinal_Place;
        private System.Windows.Forms.Label lbCrustType;
        private System.Windows.Forms.Label lbFinal_Crust_Type;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.Label lbFinal_Toppings;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbFinal_Size;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCrust;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label8;
    }
}