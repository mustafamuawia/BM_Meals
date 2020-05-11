namespace BM_Meals
{
    partial class frmPlacesTables
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flpLocations = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLocationsPrevious = new System.Windows.Forms.Button();
            this.btnDeleteReceipt = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnLocationsNext = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.flpPlaces = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPlacesPrevious = new System.Windows.Forms.Button();
            this.btnNextPlaces = new System.Windows.Forms.Button();
            this.btnTakeaway = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(854, 489);
            this.splitContainer1.SplitterDistance = 640;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.flpLocations);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnLocationsPrevious);
            this.splitContainer2.Panel2.Controls.Add(this.btnTakeaway);
            this.splitContainer2.Panel2.Controls.Add(this.btnDeleteReceipt);
            this.splitContainer2.Panel2.Controls.Add(this.btnDeleteOrder);
            this.splitContainer2.Panel2.Controls.Add(this.btnLocationsNext);
            this.splitContainer2.Size = new System.Drawing.Size(640, 489);
            this.splitContainer2.SplitterDistance = 431;
            this.splitContainer2.TabIndex = 0;
            // 
            // flpLocations
            // 
            this.flpLocations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLocations.Location = new System.Drawing.Point(0, 0);
            this.flpLocations.Name = "flpLocations";
            this.flpLocations.Size = new System.Drawing.Size(640, 431);
            this.flpLocations.TabIndex = 0;
            // 
            // btnLocationsPrevious
            // 
            this.btnLocationsPrevious.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLocationsPrevious.Location = new System.Drawing.Point(3, 3);
            this.btnLocationsPrevious.Name = "btnLocationsPrevious";
            this.btnLocationsPrevious.Size = new System.Drawing.Size(91, 48);
            this.btnLocationsPrevious.TabIndex = 1;
            this.btnLocationsPrevious.Text = "السابق";
            this.btnLocationsPrevious.UseVisualStyleBackColor = false;
            this.btnLocationsPrevious.Click += new System.EventHandler(this.btnLocationsPrevious_Click);
            // 
            // btnDeleteReceipt
            // 
            this.btnDeleteReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteReceipt.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeleteReceipt.Location = new System.Drawing.Point(279, 3);
            this.btnDeleteReceipt.Name = "btnDeleteReceipt";
            this.btnDeleteReceipt.Size = new System.Drawing.Size(91, 48);
            this.btnDeleteReceipt.TabIndex = 0;
            this.btnDeleteReceipt.Text = "الغاء ايصال";
            this.btnDeleteReceipt.UseVisualStyleBackColor = false;
            this.btnDeleteReceipt.Click += new System.EventHandler(this.btnDeleteReceipt_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteOrder.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeleteOrder.Location = new System.Drawing.Point(421, 2);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(91, 48);
            this.btnDeleteOrder.TabIndex = 0;
            this.btnDeleteOrder.Text = "الغاء طلب";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnLocationsNext
            // 
            this.btnLocationsNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLocationsNext.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLocationsNext.Location = new System.Drawing.Point(546, 3);
            this.btnLocationsNext.Name = "btnLocationsNext";
            this.btnLocationsNext.Size = new System.Drawing.Size(91, 48);
            this.btnLocationsNext.TabIndex = 0;
            this.btnLocationsNext.Text = "التالي";
            this.btnLocationsNext.UseVisualStyleBackColor = false;
            this.btnLocationsNext.Click += new System.EventHandler(this.btnLocationsNext_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.flpPlaces);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btnPlacesPrevious);
            this.splitContainer3.Panel2.Controls.Add(this.btnNextPlaces);
            this.splitContainer3.Size = new System.Drawing.Size(210, 489);
            this.splitContainer3.SplitterDistance = 431;
            this.splitContainer3.TabIndex = 1;
            // 
            // flpPlaces
            // 
            this.flpPlaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPlaces.Location = new System.Drawing.Point(0, 0);
            this.flpPlaces.Name = "flpPlaces";
            this.flpPlaces.Size = new System.Drawing.Size(210, 431);
            this.flpPlaces.TabIndex = 0;
            // 
            // btnPlacesPrevious
            // 
            this.btnPlacesPrevious.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPlacesPrevious.Location = new System.Drawing.Point(3, 3);
            this.btnPlacesPrevious.Name = "btnPlacesPrevious";
            this.btnPlacesPrevious.Size = new System.Drawing.Size(91, 48);
            this.btnPlacesPrevious.TabIndex = 2;
            this.btnPlacesPrevious.Text = "السابق";
            this.btnPlacesPrevious.UseVisualStyleBackColor = false;
            this.btnPlacesPrevious.Click += new System.EventHandler(this.btnPlacesPrevious_Click);
            // 
            // btnNextPlaces
            // 
            this.btnNextPlaces.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNextPlaces.Location = new System.Drawing.Point(116, 3);
            this.btnNextPlaces.Name = "btnNextPlaces";
            this.btnNextPlaces.Size = new System.Drawing.Size(91, 48);
            this.btnNextPlaces.TabIndex = 1;
            this.btnNextPlaces.Text = "التالي";
            this.btnNextPlaces.UseVisualStyleBackColor = false;
            this.btnNextPlaces.Click += new System.EventHandler(this.btnNextPlaces_Click);
            // 
            // btnTakeaway
            // 
            this.btnTakeaway.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTakeaway.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTakeaway.Location = new System.Drawing.Point(129, 2);
            this.btnTakeaway.Name = "btnTakeaway";
            this.btnTakeaway.Size = new System.Drawing.Size(91, 48);
            this.btnTakeaway.TabIndex = 0;
            this.btnTakeaway.Text = "سفري";
            this.btnTakeaway.UseVisualStyleBackColor = false;
            this.btnTakeaway.Click += new System.EventHandler(this.btnTakeaway_Click);
            // 
            // frmPlacesTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 489);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPlacesTables";
            this.ShowIcon = false;
            this.Text = "الاماكن والطاولات";
            this.Load += new System.EventHandler(this.frmPlacesTables_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnLocationsPrevious;
        private System.Windows.Forms.Button btnLocationsNext;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button btnPlacesPrevious;
        private System.Windows.Forms.Button btnNextPlaces;
        private System.Windows.Forms.FlowLayoutPanel flpLocations;
        private System.Windows.Forms.FlowLayoutPanel flpPlaces;
        private System.Windows.Forms.Button btnDeleteReceipt;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnTakeaway;
    }
}