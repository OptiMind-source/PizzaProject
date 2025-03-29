namespace PizzaProject
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
            this.lTitle = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkGeenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.btResetForm = new System.Windows.Forms.Button();
            this.btOrderPizza = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lSSize = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lSToppings = new System.Windows.Forms.Label();
            this.lSPrice = new System.Windows.Forms.Label();
            this.lSWhereToEat = new System.Windows.Forms.Label();
            this.lSCrustType = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Berlin Sans FB Demi", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.Color.Red;
            this.lTitle.Location = new System.Drawing.Point(234, 29);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(613, 76);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "MAKE YOUR PIZZA";
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSize.Location = new System.Drawing.Point(24, 152);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(200, 181);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbLarge.Location = new System.Drawing.Point(34, 129);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(66, 21);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "40";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbMedium.Location = new System.Drawing.Point(34, 87);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(78, 21);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "30";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rbSmall.Location = new System.Drawing.Point(34, 44);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(63, 21);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "20";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkGeenPeppers);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkExtraChees);
            this.gbToppings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbToppings.Location = new System.Drawing.Point(351, 152);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(333, 181);
            this.gbToppings.TabIndex = 2;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Topping";
            // 
            // chkGeenPeppers
            // 
            this.chkGeenPeppers.AutoSize = true;
            this.chkGeenPeppers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.chkGeenPeppers.Location = new System.Drawing.Point(183, 129);
            this.chkGeenPeppers.Name = "chkGeenPeppers";
            this.chkGeenPeppers.Size = new System.Drawing.Size(127, 21);
            this.chkGeenPeppers.TabIndex = 5;
            this.chkGeenPeppers.Tag = "30";
            this.chkGeenPeppers.Text = "Green Peppers";
            this.chkGeenPeppers.UseVisualStyleBackColor = true;
            this.chkGeenPeppers.CheckedChanged += new System.EventHandler(this.chkGeenPeppers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.chkOlives.Location = new System.Drawing.Point(183, 80);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(69, 21);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Tag = "25";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.chkOnion.Location = new System.Drawing.Point(183, 33);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(68, 21);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Tag = "20";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.chkTomatoes.Location = new System.Drawing.Point(34, 131);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(93, 21);
            this.chkTomatoes.TabIndex = 2;
            this.chkTomatoes.Tag = "15";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.chkMushrooms.Location = new System.Drawing.Point(34, 80);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(103, 21);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Tag = "10";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.chkExtraChees.Location = new System.Drawing.Point(34, 33);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(106, 21);
            this.chkExtraChees.TabIndex = 0;
            this.chkExtraChees.Tag = "5";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkExtraChees_CheckedChanged);
            // 
            // gbCrust
            // 
            this.gbCrust.Controls.Add(this.rbThick);
            this.gbCrust.Controls.Add(this.rbThin);
            this.gbCrust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbCrust.Location = new System.Drawing.Point(24, 367);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(200, 140);
            this.gbCrust.TabIndex = 3;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust Type";
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbThick.Location = new System.Drawing.Point(34, 87);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(100, 21);
            this.rbThick.TabIndex = 1;
            this.rbThick.TabStop = true;
            this.rbThick.Tag = "10";
            this.rbThick.Text = "Thick Crust";
            this.rbThick.UseVisualStyleBackColor = true;
            this.rbThick.CheckedChanged += new System.EventHandler(this.rbThick_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rbThin.Location = new System.Drawing.Point(34, 44);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(94, 21);
            this.rbThin.TabIndex = 0;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "0";
            this.rbThin.Text = "Thin Crust";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbWhereToEat.Location = new System.Drawing.Point(351, 367);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(267, 77);
            this.gbWhereToEat.TabIndex = 4;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat:";
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rbEatIn.Location = new System.Drawing.Point(20, 43);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(69, 21);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = " Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbTakeOut.Location = new System.Drawing.Point(130, 44);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(88, 21);
            this.rbTakeOut.TabIndex = 1;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // btResetForm
            // 
            this.btResetForm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btResetForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btResetForm.Location = new System.Drawing.Point(493, 460);
            this.btResetForm.Name = "btResetForm";
            this.btResetForm.Size = new System.Drawing.Size(125, 47);
            this.btResetForm.TabIndex = 6;
            this.btResetForm.Text = "Reset Form";
            this.btResetForm.UseVisualStyleBackColor = false;
            this.btResetForm.Click += new System.EventHandler(this.btResetForm_Click);
            // 
            // btOrderPizza
            // 
            this.btOrderPizza.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btOrderPizza.Location = new System.Drawing.Point(351, 460);
            this.btOrderPizza.Name = "btOrderPizza";
            this.btOrderPizza.Size = new System.Drawing.Size(127, 47);
            this.btOrderPizza.TabIndex = 7;
            this.btOrderPizza.Text = "Order Pizza";
            this.btOrderPizza.UseVisualStyleBackColor = false;
            this.btOrderPizza.Click += new System.EventHandler(this.btOrderPizza_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10F);
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size:";
            // 
            // lSSize
            // 
            this.lSSize.AutoSize = true;
            this.lSSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lSSize.Location = new System.Drawing.Point(73, 39);
            this.lSSize.Name = "lSSize";
            this.lSSize.Size = new System.Drawing.Size(0, 17);
            this.lSSize.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 3;
            // 
            // lSToppings
            // 
            this.lSToppings.AutoSize = true;
            this.lSToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lSToppings.Location = new System.Drawing.Point(65, 113);
            this.lSToppings.Name = "lSToppings";
            this.lSToppings.Size = new System.Drawing.Size(0, 17);
            this.lSToppings.TabIndex = 4;
            // 
            // lSPrice
            // 
            this.lSPrice.AutoSize = true;
            this.lSPrice.Font = new System.Drawing.Font("Franklin Gothic Heavy", 35F);
            this.lSPrice.ForeColor = System.Drawing.Color.Green;
            this.lSPrice.Location = new System.Drawing.Point(124, 281);
            this.lSPrice.Name = "lSPrice";
            this.lSPrice.Size = new System.Drawing.Size(102, 74);
            this.lSPrice.TabIndex = 5;
            this.lSPrice.Tag = "0";
            this.lSPrice.Text = "$0";
            // 
            // lSWhereToEat
            // 
            this.lSWhereToEat.AutoSize = true;
            this.lSWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lSWhereToEat.Location = new System.Drawing.Point(123, 247);
            this.lSWhereToEat.Name = "lSWhereToEat";
            this.lSWhereToEat.Size = new System.Drawing.Size(0, 17);
            this.lSWhereToEat.TabIndex = 6;
            // 
            // lSCrustType
            // 
            this.lSCrustType.AutoSize = true;
            this.lSCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lSCrustType.Location = new System.Drawing.Point(123, 163);
            this.lSCrustType.Name = "lSCrustType";
            this.lSCrustType.Size = new System.Drawing.Size(0, 17);
            this.lSCrustType.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(116, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 18);
            this.label9.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10F);
            this.label11.Location = new System.Drawing.Point(19, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "Toppings:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lSCrustType);
            this.groupBox1.Controls.Add(this.lSWhereToEat);
            this.groupBox1.Controls.Add(this.lSPrice);
            this.groupBox1.Controls.Add(this.lSToppings);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lSSize);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(729, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 372);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10F);
            this.label12.Location = new System.Drawing.Point(19, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 21);
            this.label12.TabIndex = 13;
            this.label12.Text = "Total Price:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10F);
            this.label10.Location = new System.Drawing.Point(19, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 21);
            this.label10.TabIndex = 12;
            this.label10.Text = "Where To Eat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10F);
            this.label3.Location = new System.Drawing.Point(19, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Crust Type:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 555);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btOrderPizza);
            this.Controls.Add(this.btResetForm);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.lTitle);
            this.Font = new System.Drawing.Font("Franklin Gothic Heavy", 8F);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chkGeenPeppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.Button btResetForm;
        private System.Windows.Forms.Button btOrderPizza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lSSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lSToppings;
        private System.Windows.Forms.Label lSPrice;
        private System.Windows.Forms.Label lSWhereToEat;
        private System.Windows.Forms.Label lSCrustType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
    }
}

