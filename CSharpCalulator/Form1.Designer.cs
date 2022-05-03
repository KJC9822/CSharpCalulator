
using System;

namespace CSharpCalulator
{
    partial class Form1
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
            this.WhiteRB = new System.Windows.Forms.RadioButton();
            this.ItalianRB = new System.Windows.Forms.RadioButton();
            this.WheatRB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HoagieRB = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DoubleMeatCB = new System.Windows.Forms.CheckBox();
            this.RoastBeefRB = new System.Windows.Forms.RadioButton();
            this.SteakRB = new System.Windows.Forms.RadioButton();
            this.ChickenRB = new System.Windows.Forms.RadioButton();
            this.TureyRB = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SpinachCB = new System.Windows.Forms.CheckBox();
            this.OnionCB = new System.Windows.Forms.CheckBox();
            this.JalapenoCB = new System.Windows.Forms.CheckBox();
            this.AvocadoCB = new System.Windows.Forms.CheckBox();
            this.LettuceCB = new System.Windows.Forms.CheckBox();
            this.TomatoCB = new System.Windows.Forms.CheckBox();
            this.PickleCB = new System.Windows.Forms.CheckBox();
            this.GuacamoleCB = new System.Windows.Forms.CheckBox();
            this.OliveCB = new System.Windows.Forms.CheckBox();
            this.BellCB = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.MozzarellaRB = new System.Windows.Forms.RadioButton();
            this.MuensterRB = new System.Windows.Forms.RadioButton();
            this.CheddarRB = new System.Windows.Forms.RadioButton();
            this.PepperjackRB = new System.Windows.Forms.RadioButton();
            this.ProvoloneRB = new System.Windows.Forms.RadioButton();
            this.YAmericanRB = new System.Windows.Forms.RadioButton();
            this.WAmericanRB = new System.Windows.Forms.RadioButton();
            this.SwissRB = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.MayoCB = new System.Windows.Forms.CheckBox();
            this.ItalianDressingCB = new System.Windows.Forms.CheckBox();
            this.RanchCB = new System.Windows.Forms.CheckBox();
            this.SpicyMustardCB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Calc = new System.Windows.Forms.Button();
            this.ClearAllB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // WhiteRB
            // 
            this.WhiteRB.AutoSize = true;
            this.WhiteRB.Location = new System.Drawing.Point(6, 19);
            this.WhiteRB.Name = "WhiteRB";
            this.WhiteRB.Size = new System.Drawing.Size(53, 17);
            this.WhiteRB.TabIndex = 1;
            this.WhiteRB.TabStop = true;
            this.WhiteRB.Text = "White";
            this.WhiteRB.UseVisualStyleBackColor = true;
            this.WhiteRB.CheckedChanged += new System.EventHandler(this.WhiteRB_CheckedChanged);
            // 
            // ItalianRB
            // 
            this.ItalianRB.AutoSize = true;
            this.ItalianRB.Location = new System.Drawing.Point(6, 42);
            this.ItalianRB.Name = "ItalianRB";
            this.ItalianRB.Size = new System.Drawing.Size(53, 17);
            this.ItalianRB.TabIndex = 2;
            this.ItalianRB.TabStop = true;
            this.ItalianRB.Text = "Italian";
            this.ItalianRB.UseVisualStyleBackColor = true;
            this.ItalianRB.CheckedChanged += new System.EventHandler(this.ItalianRB_CheckedChanged);
            // 
            // WheatRB
            // 
            this.WheatRB.AutoSize = true;
            this.WheatRB.Location = new System.Drawing.Point(97, 19);
            this.WheatRB.Name = "WheatRB";
            this.WheatRB.Size = new System.Drawing.Size(57, 17);
            this.WheatRB.TabIndex = 3;
            this.WheatRB.TabStop = true;
            this.WheatRB.Text = "Wheat";
            this.WheatRB.UseVisualStyleBackColor = true;
            this.WheatRB.CheckedChanged += new System.EventHandler(this.WheatRB_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HoagieRB);
            this.groupBox1.Controls.Add(this.WhiteRB);
            this.groupBox1.Controls.Add(this.WheatRB);
            this.groupBox1.Controls.Add(this.ItalianRB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bread Choice - Choose One";
            // 
            // HoagieRB
            // 
            this.HoagieRB.AutoSize = true;
            this.HoagieRB.Location = new System.Drawing.Point(97, 42);
            this.HoagieRB.Name = "HoagieRB";
            this.HoagieRB.Size = new System.Drawing.Size(59, 17);
            this.HoagieRB.TabIndex = 4;
            this.HoagieRB.TabStop = true;
            this.HoagieRB.Text = "Hoagie";
            this.HoagieRB.UseVisualStyleBackColor = true;
            this.HoagieRB.CheckedChanged += new System.EventHandler(this.HoagieRB_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DoubleMeatCB);
            this.groupBox2.Controls.Add(this.RoastBeefRB);
            this.groupBox2.Controls.Add(this.SteakRB);
            this.groupBox2.Controls.Add(this.ChickenRB);
            this.groupBox2.Controls.Add(this.TureyRB);
            this.groupBox2.Location = new System.Drawing.Point(12, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 89);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meat Choice - Choose One";
            // 
            // DoubleMeatCB
            // 
            this.DoubleMeatCB.AutoSize = true;
            this.DoubleMeatCB.Location = new System.Drawing.Point(6, 65);
            this.DoubleMeatCB.Name = "DoubleMeatCB";
            this.DoubleMeatCB.Size = new System.Drawing.Size(87, 17);
            this.DoubleMeatCB.TabIndex = 5;
            this.DoubleMeatCB.Text = "Double Meat";
            this.DoubleMeatCB.UseVisualStyleBackColor = true;
            this.DoubleMeatCB.CheckedChanged += new System.EventHandler(this.DoubleMeatCB_CheckedChanged);
            // 
            // RoastBeefRB
            // 
            this.RoastBeefRB.AutoSize = true;
            this.RoastBeefRB.Location = new System.Drawing.Point(97, 42);
            this.RoastBeefRB.Name = "RoastBeefRB";
            this.RoastBeefRB.Size = new System.Drawing.Size(78, 17);
            this.RoastBeefRB.TabIndex = 4;
            this.RoastBeefRB.TabStop = true;
            this.RoastBeefRB.Text = "Roast Beef";
            this.RoastBeefRB.UseVisualStyleBackColor = true;
            this.RoastBeefRB.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // SteakRB
            // 
            this.SteakRB.AutoSize = true;
            this.SteakRB.Location = new System.Drawing.Point(6, 19);
            this.SteakRB.Name = "SteakRB";
            this.SteakRB.Size = new System.Drawing.Size(53, 17);
            this.SteakRB.TabIndex = 1;
            this.SteakRB.TabStop = true;
            this.SteakRB.Text = "Steak";
            this.SteakRB.UseVisualStyleBackColor = true;
            this.SteakRB.CheckedChanged += new System.EventHandler(this.SteakRB_CheckedChanged);
            // 
            // ChickenRB
            // 
            this.ChickenRB.AutoSize = true;
            this.ChickenRB.Location = new System.Drawing.Point(97, 19);
            this.ChickenRB.Name = "ChickenRB";
            this.ChickenRB.Size = new System.Drawing.Size(64, 17);
            this.ChickenRB.TabIndex = 3;
            this.ChickenRB.TabStop = true;
            this.ChickenRB.Text = "Chicken";
            this.ChickenRB.UseVisualStyleBackColor = true;
            this.ChickenRB.CheckedChanged += new System.EventHandler(this.ChickenRB_CheckedChanged);
            // 
            // TureyRB
            // 
            this.TureyRB.AutoSize = true;
            this.TureyRB.Location = new System.Drawing.Point(6, 42);
            this.TureyRB.Name = "TureyRB";
            this.TureyRB.Size = new System.Drawing.Size(58, 17);
            this.TureyRB.TabIndex = 2;
            this.TureyRB.TabStop = true;
            this.TureyRB.Text = "Turkey";
            this.TureyRB.UseVisualStyleBackColor = true;
            this.TureyRB.CheckedChanged += new System.EventHandler(this.TureyRB_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SpinachCB);
            this.groupBox3.Controls.Add(this.OnionCB);
            this.groupBox3.Controls.Add(this.JalapenoCB);
            this.groupBox3.Controls.Add(this.AvocadoCB);
            this.groupBox3.Controls.Add(this.LettuceCB);
            this.groupBox3.Controls.Add(this.TomatoCB);
            this.groupBox3.Controls.Add(this.PickleCB);
            this.groupBox3.Controls.Add(this.GuacamoleCB);
            this.groupBox3.Controls.Add(this.OliveCB);
            this.groupBox3.Controls.Add(this.BellCB);
            this.groupBox3.Location = new System.Drawing.Point(12, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 131);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vegetable Choice +$0.25 Per";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // SpinachCB
            // 
            this.SpinachCB.AutoSize = true;
            this.SpinachCB.Location = new System.Drawing.Point(114, 111);
            this.SpinachCB.Name = "SpinachCB";
            this.SpinachCB.Size = new System.Drawing.Size(65, 17);
            this.SpinachCB.TabIndex = 17;
            this.SpinachCB.Text = "Spinach";
            this.SpinachCB.UseVisualStyleBackColor = true;
            this.SpinachCB.CheckedChanged += new System.EventHandler(this.SpinachCB_CheckedChanged);
            // 
            // OnionCB
            // 
            this.OnionCB.AutoSize = true;
            this.OnionCB.Location = new System.Drawing.Point(6, 42);
            this.OnionCB.Name = "OnionCB";
            this.OnionCB.Size = new System.Drawing.Size(54, 17);
            this.OnionCB.TabIndex = 16;
            this.OnionCB.Text = "Onion";
            this.OnionCB.UseVisualStyleBackColor = true;
            this.OnionCB.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // JalapenoCB
            // 
            this.JalapenoCB.AutoSize = true;
            this.JalapenoCB.Location = new System.Drawing.Point(6, 65);
            this.JalapenoCB.Name = "JalapenoCB";
            this.JalapenoCB.Size = new System.Drawing.Size(69, 17);
            this.JalapenoCB.TabIndex = 14;
            this.JalapenoCB.Text = "Jalapeno";
            this.JalapenoCB.UseVisualStyleBackColor = true;
            this.JalapenoCB.CheckedChanged += new System.EventHandler(this.JalapenoCB_CheckedChanged);
            // 
            // AvocadoCB
            // 
            this.AvocadoCB.AutoSize = true;
            this.AvocadoCB.Location = new System.Drawing.Point(114, 88);
            this.AvocadoCB.Name = "AvocadoCB";
            this.AvocadoCB.Size = new System.Drawing.Size(69, 17);
            this.AvocadoCB.TabIndex = 12;
            this.AvocadoCB.Text = "Avocado";
            this.AvocadoCB.UseVisualStyleBackColor = true;
            this.AvocadoCB.CheckedChanged += new System.EventHandler(this.AvocadoCB_CheckedChanged);
            // 
            // LettuceCB
            // 
            this.LettuceCB.AutoSize = true;
            this.LettuceCB.Location = new System.Drawing.Point(114, 19);
            this.LettuceCB.Name = "LettuceCB";
            this.LettuceCB.Size = new System.Drawing.Size(62, 17);
            this.LettuceCB.TabIndex = 4;
            this.LettuceCB.Text = "Lettuce";
            this.LettuceCB.UseVisualStyleBackColor = true;
            this.LettuceCB.CheckedChanged += new System.EventHandler(this.LettuceCB_CheckedChanged);
            // 
            // TomatoCB
            // 
            this.TomatoCB.AutoSize = true;
            this.TomatoCB.Location = new System.Drawing.Point(6, 19);
            this.TomatoCB.Name = "TomatoCB";
            this.TomatoCB.Size = new System.Drawing.Size(62, 17);
            this.TomatoCB.TabIndex = 0;
            this.TomatoCB.Text = "Tomato";
            this.TomatoCB.UseVisualStyleBackColor = true;
            this.TomatoCB.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged_1);
            // 
            // PickleCB
            // 
            this.PickleCB.AutoSize = true;
            this.PickleCB.Location = new System.Drawing.Point(114, 65);
            this.PickleCB.Name = "PickleCB";
            this.PickleCB.Size = new System.Drawing.Size(60, 17);
            this.PickleCB.TabIndex = 10;
            this.PickleCB.Text = "Pickles";
            this.PickleCB.UseVisualStyleBackColor = true;
            this.PickleCB.CheckedChanged += new System.EventHandler(this.PickleCB_CheckedChanged);
            // 
            // GuacamoleCB
            // 
            this.GuacamoleCB.AutoSize = true;
            this.GuacamoleCB.Location = new System.Drawing.Point(5, 111);
            this.GuacamoleCB.Name = "GuacamoleCB";
            this.GuacamoleCB.Size = new System.Drawing.Size(80, 17);
            this.GuacamoleCB.TabIndex = 8;
            this.GuacamoleCB.Text = "Guacamole";
            this.GuacamoleCB.UseVisualStyleBackColor = true;
            this.GuacamoleCB.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // OliveCB
            // 
            this.OliveCB.AutoSize = true;
            this.OliveCB.Location = new System.Drawing.Point(6, 88);
            this.OliveCB.Name = "OliveCB";
            this.OliveCB.Size = new System.Drawing.Size(55, 17);
            this.OliveCB.TabIndex = 2;
            this.OliveCB.Text = "Olives";
            this.OliveCB.UseVisualStyleBackColor = true;
            this.OliveCB.CheckedChanged += new System.EventHandler(this.OliveCB_CheckedChanged);
            // 
            // BellCB
            // 
            this.BellCB.AutoSize = true;
            this.BellCB.Location = new System.Drawing.Point(114, 42);
            this.BellCB.Name = "BellCB";
            this.BellCB.Size = new System.Drawing.Size(111, 17);
            this.BellCB.TabIndex = 6;
            this.BellCB.Text = "Bell Pepper Slices";
            this.BellCB.UseVisualStyleBackColor = true;
            this.BellCB.CheckedChanged += new System.EventHandler(this.BellCB_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.MozzarellaRB);
            this.groupBox4.Controls.Add(this.MuensterRB);
            this.groupBox4.Controls.Add(this.CheddarRB);
            this.groupBox4.Controls.Add(this.PepperjackRB);
            this.groupBox4.Controls.Add(this.ProvoloneRB);
            this.groupBox4.Controls.Add(this.YAmericanRB);
            this.groupBox4.Controls.Add(this.WAmericanRB);
            this.groupBox4.Controls.Add(this.SwissRB);
            this.groupBox4.Location = new System.Drawing.Point(12, 183);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(217, 135);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cheese Choice - Choose One";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 111);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(99, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Double Cheese";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // MozzarellaRB
            // 
            this.MozzarellaRB.AutoSize = true;
            this.MozzarellaRB.Location = new System.Drawing.Point(115, 88);
            this.MozzarellaRB.Name = "MozzarellaRB";
            this.MozzarellaRB.Size = new System.Drawing.Size(75, 17);
            this.MozzarellaRB.TabIndex = 8;
            this.MozzarellaRB.TabStop = true;
            this.MozzarellaRB.Text = "Mozzarella";
            this.MozzarellaRB.UseVisualStyleBackColor = true;
            this.MozzarellaRB.CheckedChanged += new System.EventHandler(this.MozzarellaRB_CheckedChanged);
            // 
            // MuensterRB
            // 
            this.MuensterRB.AutoSize = true;
            this.MuensterRB.Location = new System.Drawing.Point(6, 88);
            this.MuensterRB.Name = "MuensterRB";
            this.MuensterRB.Size = new System.Drawing.Size(69, 17);
            this.MuensterRB.TabIndex = 7;
            this.MuensterRB.TabStop = true;
            this.MuensterRB.Text = "Muenster";
            this.MuensterRB.UseVisualStyleBackColor = true;
            this.MuensterRB.CheckedChanged += new System.EventHandler(this.radioButton23_CheckedChanged);
            // 
            // CheddarRB
            // 
            this.CheddarRB.AutoSize = true;
            this.CheddarRB.Location = new System.Drawing.Point(115, 65);
            this.CheddarRB.Name = "CheddarRB";
            this.CheddarRB.Size = new System.Drawing.Size(65, 17);
            this.CheddarRB.TabIndex = 6;
            this.CheddarRB.TabStop = true;
            this.CheddarRB.Text = "Cheddar";
            this.CheddarRB.UseVisualStyleBackColor = true;
            this.CheddarRB.CheckedChanged += new System.EventHandler(this.radioButton22_CheckedChanged);
            // 
            // PepperjackRB
            // 
            this.PepperjackRB.AutoSize = true;
            this.PepperjackRB.Location = new System.Drawing.Point(6, 65);
            this.PepperjackRB.Name = "PepperjackRB";
            this.PepperjackRB.Size = new System.Drawing.Size(79, 17);
            this.PepperjackRB.TabIndex = 5;
            this.PepperjackRB.TabStop = true;
            this.PepperjackRB.Text = "Pepperjack";
            this.PepperjackRB.UseVisualStyleBackColor = true;
            this.PepperjackRB.CheckedChanged += new System.EventHandler(this.radioButton21_CheckedChanged);
            // 
            // ProvoloneRB
            // 
            this.ProvoloneRB.AutoSize = true;
            this.ProvoloneRB.Location = new System.Drawing.Point(115, 42);
            this.ProvoloneRB.Name = "ProvoloneRB";
            this.ProvoloneRB.Size = new System.Drawing.Size(73, 17);
            this.ProvoloneRB.TabIndex = 4;
            this.ProvoloneRB.TabStop = true;
            this.ProvoloneRB.Text = "Provolone";
            this.ProvoloneRB.UseVisualStyleBackColor = true;
            this.ProvoloneRB.CheckedChanged += new System.EventHandler(this.ProvoloneRB_CheckedChanged);
            // 
            // YAmericanRB
            // 
            this.YAmericanRB.AutoSize = true;
            this.YAmericanRB.Location = new System.Drawing.Point(6, 19);
            this.YAmericanRB.Name = "YAmericanRB";
            this.YAmericanRB.Size = new System.Drawing.Size(103, 17);
            this.YAmericanRB.TabIndex = 1;
            this.YAmericanRB.TabStop = true;
            this.YAmericanRB.Text = "Yellow American";
            this.YAmericanRB.UseVisualStyleBackColor = true;
            this.YAmericanRB.CheckedChanged += new System.EventHandler(this.YAmericanRB_CheckedChanged);
            // 
            // WAmericanRB
            // 
            this.WAmericanRB.AutoSize = true;
            this.WAmericanRB.Location = new System.Drawing.Point(115, 19);
            this.WAmericanRB.Name = "WAmericanRB";
            this.WAmericanRB.Size = new System.Drawing.Size(100, 17);
            this.WAmericanRB.TabIndex = 3;
            this.WAmericanRB.TabStop = true;
            this.WAmericanRB.Text = "White American";
            this.WAmericanRB.UseVisualStyleBackColor = true;
            this.WAmericanRB.CheckedChanged += new System.EventHandler(this.radioButton15_CheckedChanged);
            // 
            // SwissRB
            // 
            this.SwissRB.AutoSize = true;
            this.SwissRB.Location = new System.Drawing.Point(6, 42);
            this.SwissRB.Name = "SwissRB";
            this.SwissRB.Size = new System.Drawing.Size(52, 17);
            this.SwissRB.TabIndex = 2;
            this.SwissRB.TabStop = true;
            this.SwissRB.Text = "Swiss";
            this.SwissRB.UseVisualStyleBackColor = true;
            this.SwissRB.CheckedChanged += new System.EventHandler(this.radioButton16_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.MayoCB);
            this.groupBox5.Controls.Add(this.ItalianDressingCB);
            this.groupBox5.Controls.Add(this.RanchCB);
            this.groupBox5.Controls.Add(this.SpicyMustardCB);
            this.groupBox5.Location = new System.Drawing.Point(12, 461);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(215, 70);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Condiment Choice +$0.25 Per";
            // 
            // MayoCB
            // 
            this.MayoCB.AutoSize = true;
            this.MayoCB.Location = new System.Drawing.Point(106, 43);
            this.MayoCB.Name = "MayoCB";
            this.MayoCB.Size = new System.Drawing.Size(52, 17);
            this.MayoCB.TabIndex = 3;
            this.MayoCB.Text = "Mayo";
            this.MayoCB.UseVisualStyleBackColor = true;
            this.MayoCB.CheckedChanged += new System.EventHandler(this.MayoCB_CheckedChanged);
            // 
            // ItalianDressingCB
            // 
            this.ItalianDressingCB.AutoSize = true;
            this.ItalianDressingCB.Location = new System.Drawing.Point(106, 19);
            this.ItalianDressingCB.Name = "ItalianDressingCB";
            this.ItalianDressingCB.Size = new System.Drawing.Size(98, 17);
            this.ItalianDressingCB.TabIndex = 2;
            this.ItalianDressingCB.Text = "Italian Dressing";
            this.ItalianDressingCB.UseVisualStyleBackColor = true;
            this.ItalianDressingCB.CheckedChanged += new System.EventHandler(this.ItalianDressingCB_CheckedChanged);
            // 
            // RanchCB
            // 
            this.RanchCB.AutoSize = true;
            this.RanchCB.Location = new System.Drawing.Point(7, 43);
            this.RanchCB.Name = "RanchCB";
            this.RanchCB.Size = new System.Drawing.Size(58, 17);
            this.RanchCB.TabIndex = 1;
            this.RanchCB.Text = "Ranch";
            this.RanchCB.UseVisualStyleBackColor = true;
            this.RanchCB.CheckedChanged += new System.EventHandler(this.RanchCB_CheckedChanged);
            // 
            // SpicyMustardCB
            // 
            this.SpicyMustardCB.AutoSize = true;
            this.SpicyMustardCB.Location = new System.Drawing.Point(7, 20);
            this.SpicyMustardCB.Name = "SpicyMustardCB";
            this.SpicyMustardCB.Size = new System.Drawing.Size(93, 17);
            this.SpicyMustardCB.TabIndex = 0;
            this.SpicyMustardCB.Text = "Spicy Mustard";
            this.SpicyMustardCB.UseVisualStyleBackColor = true;
            this.SpicyMustardCB.CheckedChanged += new System.EventHandler(this.SpicyMustardCB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sub Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 592);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 566);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tax";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 537);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 589);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(128, 563);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(2, 535);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(68, 38);
            this.Calc.TabIndex = 13;
            this.Calc.Text = "Calculate";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // ClearAllB
            // 
            this.ClearAllB.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClearAllB.Location = new System.Drawing.Point(2, 571);
            this.ClearAllB.Name = "ClearAllB";
            this.ClearAllB.Size = new System.Drawing.Size(68, 38);
            this.ClearAllB.TabIndex = 14;
            this.ClearAllB.Text = "Clear All";
            this.ClearAllB.UseVisualStyleBackColor = true;
            this.ClearAllB.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 616);
            this.Controls.Add(this.ClearAllB);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Kyle\'s Sub Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            
        }


        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        #endregion

        private System.Windows.Forms.RadioButton WhiteRB;
        private System.Windows.Forms.RadioButton ItalianRB;
        private System.Windows.Forms.RadioButton WheatRB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton HoagieRB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox DoubleMeatCB;
        private System.Windows.Forms.RadioButton RoastBeefRB;
        private System.Windows.Forms.RadioButton SteakRB;
        private System.Windows.Forms.RadioButton ChickenRB;
        private System.Windows.Forms.RadioButton TureyRB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton ProvoloneRB;
        private System.Windows.Forms.RadioButton YAmericanRB;
        private System.Windows.Forms.RadioButton WAmericanRB;
        private System.Windows.Forms.RadioButton SwissRB;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton PepperjackRB;
        private System.Windows.Forms.RadioButton CheddarRB;
        private System.Windows.Forms.RadioButton MozzarellaRB;
        private System.Windows.Forms.RadioButton MuensterRB;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox SpinachCB;
        private System.Windows.Forms.CheckBox OnionCB;
        private System.Windows.Forms.CheckBox JalapenoCB;
        private System.Windows.Forms.CheckBox AvocadoCB;
        private System.Windows.Forms.CheckBox LettuceCB;
        private System.Windows.Forms.CheckBox TomatoCB;
        private System.Windows.Forms.CheckBox PickleCB;
        private System.Windows.Forms.CheckBox GuacamoleCB;
        private System.Windows.Forms.CheckBox OliveCB;
        private System.Windows.Forms.CheckBox BellCB;
        private System.Windows.Forms.CheckBox MayoCB;
        private System.Windows.Forms.CheckBox ItalianDressingCB;
        private System.Windows.Forms.CheckBox RanchCB;
        private System.Windows.Forms.CheckBox SpicyMustardCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.Button ClearAllB;
    }
}

