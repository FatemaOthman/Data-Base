namespace Rentals
{
    partial class form
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
            this.UnitIDtext = new System.Windows.Forms.ComboBox();
            this.displayUnits = new System.Windows.Forms.DataGridView();
            this.ShowUnit = new System.Windows.Forms.Button();
            this.ShowAllUnits = new System.Windows.Forms.Button();
            this.BACK = new System.Windows.Forms.Button();
            this.UBuildingNum = new System.Windows.Forms.TextBox();
            this.UCondition = new System.Windows.Forms.TextBox();
            this.UnoOfRooms = new System.Windows.Forms.TextBox();
            this.UnoOfBathrooms = new System.Windows.Forms.TextBox();
            this.UArea = new System.Windows.Forms.TextBox();
            this.UState = new System.Windows.Forms.TextBox();
            this.UReqRent = new System.Windows.Forms.TextBox();
            this.UType = new System.Windows.Forms.TextBox();
            this.uID = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UPDATEunit = new System.Windows.Forms.Button();
            this.AddUNIT = new System.Windows.Forms.Button();
            this.DELUnit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.displayUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // UnitIDtext
            // 
            this.UnitIDtext.FormattingEnabled = true;
            this.UnitIDtext.Location = new System.Drawing.Point(12, 8);
            this.UnitIDtext.Name = "UnitIDtext";
            this.UnitIDtext.Size = new System.Drawing.Size(121, 24);
            this.UnitIDtext.TabIndex = 0;
            this.UnitIDtext.SelectedIndexChanged += new System.EventHandler(this.UnitIDtext_SelectedIndexChanged);
            // 
            // displayUnits
            // 
            this.displayUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayUnits.Location = new System.Drawing.Point(12, 117);
            this.displayUnits.Name = "displayUnits";
            this.displayUnits.RowTemplate.Height = 24;
            this.displayUnits.Size = new System.Drawing.Size(635, 246);
            this.displayUnits.TabIndex = 1;
            this.displayUnits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayUnits_CellContentClick);
            // 
            // ShowUnit
            // 
            this.ShowUnit.Location = new System.Drawing.Point(176, 8);
            this.ShowUnit.Name = "ShowUnit";
            this.ShowUnit.Size = new System.Drawing.Size(122, 28);
            this.ShowUnit.TabIndex = 2;
            this.ShowUnit.Text = "Show Unit";
            this.ShowUnit.UseVisualStyleBackColor = true;
            this.ShowUnit.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowAllUnits
            // 
            this.ShowAllUnits.Location = new System.Drawing.Point(383, 8);
            this.ShowAllUnits.Name = "ShowAllUnits";
            this.ShowAllUnits.Size = new System.Drawing.Size(181, 28);
            this.ShowAllUnits.TabIndex = 3;
            this.ShowAllUnits.Text = "Show all units";
            this.ShowAllUnits.UseVisualStyleBackColor = true;
            this.ShowAllUnits.Click += new System.EventHandler(this.ShowAllUnits_Click);
            // 
            // BACK
            // 
            this.BACK.Location = new System.Drawing.Point(1108, 12);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(75, 24);
            this.BACK.TabIndex = 4;
            this.BACK.Text = "Back";
            this.BACK.UseVisualStyleBackColor = true;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // UBuildingNum
            // 
            this.UBuildingNum.Location = new System.Drawing.Point(937, 341);
            this.UBuildingNum.Name = "UBuildingNum";
            this.UBuildingNum.Size = new System.Drawing.Size(100, 22);
            this.UBuildingNum.TabIndex = 22;
            // 
            // UCondition
            // 
            this.UCondition.Location = new System.Drawing.Point(937, 313);
            this.UCondition.Name = "UCondition";
            this.UCondition.Size = new System.Drawing.Size(100, 22);
            this.UCondition.TabIndex = 21;
            // 
            // UnoOfRooms
            // 
            this.UnoOfRooms.Location = new System.Drawing.Point(937, 285);
            this.UnoOfRooms.Name = "UnoOfRooms";
            this.UnoOfRooms.Size = new System.Drawing.Size(100, 22);
            this.UnoOfRooms.TabIndex = 20;
            // 
            // UnoOfBathrooms
            // 
            this.UnoOfBathrooms.Location = new System.Drawing.Point(937, 257);
            this.UnoOfBathrooms.Name = "UnoOfBathrooms";
            this.UnoOfBathrooms.Size = new System.Drawing.Size(100, 22);
            this.UnoOfBathrooms.TabIndex = 19;
            // 
            // UArea
            // 
            this.UArea.Location = new System.Drawing.Point(937, 229);
            this.UArea.Name = "UArea";
            this.UArea.Size = new System.Drawing.Size(100, 22);
            this.UArea.TabIndex = 18;
            this.UArea.TextChanged += new System.EventHandler(this.UArea_TextChanged);
            // 
            // UState
            // 
            this.UState.Location = new System.Drawing.Point(937, 201);
            this.UState.Name = "UState";
            this.UState.Size = new System.Drawing.Size(100, 22);
            this.UState.TabIndex = 17;
            // 
            // UReqRent
            // 
            this.UReqRent.Location = new System.Drawing.Point(937, 173);
            this.UReqRent.Name = "UReqRent";
            this.UReqRent.Size = new System.Drawing.Size(100, 22);
            this.UReqRent.TabIndex = 16;
            // 
            // UType
            // 
            this.UType.Location = new System.Drawing.Point(937, 145);
            this.UType.Name = "UType";
            this.UType.Size = new System.Drawing.Size(100, 22);
            this.UType.TabIndex = 15;
            // 
            // uID
            // 
            this.uID.Location = new System.Drawing.Point(937, 117);
            this.uID.Name = "uID";
            this.uID.Size = new System.Drawing.Size(100, 22);
            this.uID.TabIndex = 14;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(763, 122);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(21, 17);
            this.ID.TabIndex = 23;
            this.ID.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(763, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(762, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "RequiredRent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(762, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(762, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Area";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(762, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Number of bathrooms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(762, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Number of rooms";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(763, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Condition";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(765, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Building number ";
            // 
            // UPDATEunit
            // 
            this.UPDATEunit.Location = new System.Drawing.Point(937, 408);
            this.UPDATEunit.Name = "UPDATEunit";
            this.UPDATEunit.Size = new System.Drawing.Size(148, 28);
            this.UPDATEunit.TabIndex = 32;
            this.UPDATEunit.Text = "Update  Unit";
            this.UPDATEunit.UseVisualStyleBackColor = true;
            this.UPDATEunit.Click += new System.EventHandler(this.UPDATEunit_Click);
            // 
            // AddUNIT
            // 
            this.AddUNIT.Location = new System.Drawing.Point(937, 374);
            this.AddUNIT.Name = "AddUNIT";
            this.AddUNIT.Size = new System.Drawing.Size(126, 28);
            this.AddUNIT.TabIndex = 33;
            this.AddUNIT.Text = "Add Unit";
            this.AddUNIT.UseVisualStyleBackColor = true;
            this.AddUNIT.Click += new System.EventHandler(this.AddUNIT_Click);
            // 
            // DELUnit
            // 
            this.DELUnit.Location = new System.Drawing.Point(631, 8);
            this.DELUnit.Name = "DELUnit";
            this.DELUnit.Size = new System.Drawing.Size(129, 28);
            this.DELUnit.TabIndex = 34;
            this.DELUnit.Text = "delete";
            this.DELUnit.UseVisualStyleBackColor = true;
            this.DELUnit.Click += new System.EventHandler(this.DELUnit_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 461);
            this.Controls.Add(this.DELUnit);
            this.Controls.Add(this.AddUNIT);
            this.Controls.Add(this.UPDATEunit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.UBuildingNum);
            this.Controls.Add(this.UCondition);
            this.Controls.Add(this.UnoOfRooms);
            this.Controls.Add(this.UnoOfBathrooms);
            this.Controls.Add(this.UArea);
            this.Controls.Add(this.UState);
            this.Controls.Add(this.UReqRent);
            this.Controls.Add(this.UType);
            this.Controls.Add(this.uID);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.ShowAllUnits);
            this.Controls.Add(this.ShowUnit);
            this.Controls.Add(this.displayUnits);
            this.Controls.Add(this.UnitIDtext);
            this.Name = "form";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Units_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayUnits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UnitIDtext;
        private System.Windows.Forms.DataGridView displayUnits;
        private System.Windows.Forms.Button ShowUnit;
        private System.Windows.Forms.Button ShowAllUnits;
        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.TextBox UBuildingNum;
        private System.Windows.Forms.TextBox UCondition;
        private System.Windows.Forms.TextBox UnoOfRooms;
        private System.Windows.Forms.TextBox UnoOfBathrooms;
        private System.Windows.Forms.TextBox UArea;
        private System.Windows.Forms.TextBox UState;
        private System.Windows.Forms.TextBox UReqRent;
        private System.Windows.Forms.TextBox UType;
        private System.Windows.Forms.TextBox uID;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button UPDATEunit;
        private System.Windows.Forms.Button AddUNIT;
        private System.Windows.Forms.Button DELUnit;
    }
}