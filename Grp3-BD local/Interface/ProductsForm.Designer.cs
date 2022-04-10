/*
 * Created by SharpDevelop.
 * User: harding legrand
 * Date: 05/01/2022
 * Time: 01:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Connexion
{
	partial class ProductsForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView view;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.ComboBox cat;
		private System.Windows.Forms.Button actualise;
		private System.Windows.Forms.ComboBox recherchecategorie;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button buyer;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.panel1 = new System.Windows.Forms.Panel();
            this.numCom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.prx = new System.Windows.Forms.TextBox();
            this.qte = new System.Windows.Forms.TextBox();
            this.intit = new System.Windows.Forms.TextBox();
            this.refer = new System.Windows.Forms.TextBox();
            this.Recherche = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.cat = new System.Windows.Forms.ComboBox();
            this.actualise = new System.Windows.Forms.Button();
            this.recherchecategorie = new System.Windows.Forms.ComboBox();
            this.view = new System.Windows.Forms.DataGridView();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buyer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.numCom);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.prx);
            this.panel1.Controls.Add(this.qte);
            this.panel1.Controls.Add(this.intit);
            this.panel1.Controls.Add(this.refer);
            this.panel1.Controls.Add(this.Recherche);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.cat);
            this.panel1.Controls.Add(this.actualise);
            this.panel1.Controls.Add(this.recherchecategorie);
            this.panel1.Controls.Add(this.view);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(177, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 719);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // numCom
            // 
            this.numCom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.numCom.BackColor = System.Drawing.Color.White;
            this.numCom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numCom.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCom.Location = new System.Drawing.Point(135, 168);
            this.numCom.Margin = new System.Windows.Forms.Padding(4);
            this.numCom.Multiline = true;
            this.numCom.Name = "numCom";
            this.numCom.Size = new System.Drawing.Size(223, 28);
            this.numCom.TabIndex = 32;
            this.numCom.Text = " ";
            this.numCom.TextChanged += new System.EventHandler(this.numCom_TextChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 168);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 28);
            this.label8.TabIndex = 31;
            this.label8.Text = "NUMERO CMD";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(48, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(340, 65);
            this.label7.TabIndex = 30;
            this.label7.Text = "FIELD EDIT AND DELETE";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.button1.Location = new System.Drawing.Point(584, 131);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 28);
            this.button1.TabIndex = 29;
            this.button1.Text = "Research";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prx
            // 
            this.prx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.prx.BackColor = System.Drawing.Color.White;
            this.prx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prx.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prx.Location = new System.Drawing.Point(134, 406);
            this.prx.Margin = new System.Windows.Forms.Padding(4);
            this.prx.Multiline = true;
            this.prx.Name = "prx";
            this.prx.Size = new System.Drawing.Size(223, 28);
            this.prx.TabIndex = 28;
            // 
            // qte
            // 
            this.qte.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.qte.BackColor = System.Drawing.Color.White;
            this.qte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.qte.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qte.Location = new System.Drawing.Point(134, 345);
            this.qte.Margin = new System.Windows.Forms.Padding(4);
            this.qte.Multiline = true;
            this.qte.Name = "qte";
            this.qte.Size = new System.Drawing.Size(223, 28);
            this.qte.TabIndex = 27;
            // 
            // intit
            // 
            this.intit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.intit.BackColor = System.Drawing.Color.White;
            this.intit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.intit.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intit.Location = new System.Drawing.Point(134, 284);
            this.intit.Margin = new System.Windows.Forms.Padding(4);
            this.intit.Multiline = true;
            this.intit.Name = "intit";
            this.intit.Size = new System.Drawing.Size(223, 28);
            this.intit.TabIndex = 26;
            this.intit.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // refer
            // 
            this.refer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.refer.BackColor = System.Drawing.Color.White;
            this.refer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.refer.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refer.Location = new System.Drawing.Point(134, 224);
            this.refer.Margin = new System.Windows.Forms.Padding(4);
            this.refer.Multiline = true;
            this.refer.Name = "refer";
            this.refer.Size = new System.Drawing.Size(223, 28);
            this.refer.TabIndex = 25;
            this.refer.Text = " ";
            this.refer.TextChanged += new System.EventHandler(this.refer_TextChanged);
            // 
            // Recherche
            // 
            this.Recherche.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Recherche.BackColor = System.Drawing.Color.White;
            this.Recherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Recherche.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Recherche.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recherche.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Recherche.Location = new System.Drawing.Point(403, 132);
            this.Recherche.Margin = new System.Windows.Forms.Padding(4);
            this.Recherche.Multiline = true;
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(184, 26);
            this.Recherche.TabIndex = 24;
            this.Recherche.UseWaitCursor = true;
            this.Recherche.TextChanged += new System.EventHandler(this.Recherche_TextChanged);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.button9.Location = new System.Drawing.Point(273, 618);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(115, 42);
            this.button9.TabIndex = 23;
            this.button9.Text = "EXIT";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.button6.Location = new System.Drawing.Point(145, 618);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 42);
            this.button6.TabIndex = 22;
            this.button6.Text = "SEARCH";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.button11.Location = new System.Drawing.Point(17, 618);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(115, 42);
            this.button11.TabIndex = 21;
            this.button11.Text = "NEW";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // cat
            // 
            this.cat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.cat.FormattingEnabled = true;
            this.cat.Items.AddRange(new object[] {
            "Quincaillerie",
            "accessoiresFixation",
            "boulonnerie",
            "visserie",
            "clouterie"});
            this.cat.Location = new System.Drawing.Point(135, 465);
            this.cat.Margin = new System.Windows.Forms.Padding(4);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(222, 31);
            this.cat.TabIndex = 20;
            this.cat.Text = "Select Category";
            this.cat.SelectedIndexChanged += new System.EventHandler(this.cat_SelectedIndexChanged);
            // 
            // actualise
            // 
            this.actualise.BackColor = System.Drawing.Color.White;
            this.actualise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actualise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actualise.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.actualise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.actualise.Location = new System.Drawing.Point(791, 131);
            this.actualise.Margin = new System.Windows.Forms.Padding(4);
            this.actualise.Name = "actualise";
            this.actualise.Size = new System.Drawing.Size(149, 28);
            this.actualise.TabIndex = 19;
            this.actualise.Text = "REFRESH";
            this.actualise.UseVisualStyleBackColor = false;
            this.actualise.Click += new System.EventHandler(this.actualise_Click);
            // 
            // recherchecategorie
            // 
            this.recherchecategorie.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recherchecategorie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.recherchecategorie.FormattingEnabled = true;
            this.recherchecategorie.Items.AddRange(new object[] {
            "Quincaillerie",
            "accessoiresFixation",
            "boulonnerie",
            "visserie",
            "clouterie"});
            this.recherchecategorie.Location = new System.Drawing.Point(403, 92);
            this.recherchecategorie.Margin = new System.Windows.Forms.Padding(4);
            this.recherchecategorie.Name = "recherchecategorie";
            this.recherchecategorie.Size = new System.Drawing.Size(276, 31);
            this.recherchecategorie.TabIndex = 18;
            this.recherchecategorie.Text = "Select Category";
            this.recherchecategorie.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // view
            // 
            this.view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.view.BackgroundColor = System.Drawing.Color.White;
            this.view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view.GridColor = System.Drawing.Color.White;
            this.view.Location = new System.Drawing.Point(403, 162);
            this.view.Margin = new System.Windows.Forms.Padding(4);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(537, 542);
            this.view.TabIndex = 17;
            this.view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_CellContentClick);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.button10.Location = new System.Drawing.Point(273, 569);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(115, 42);
            this.button10.TabIndex = 16;
            this.button10.Text = "DELETE";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.button8.Location = new System.Drawing.Point(146, 569);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(115, 42);
            this.button8.TabIndex = 14;
            this.button8.Text = "EDIT";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.button7.Location = new System.Drawing.Point(18, 569);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(115, 42);
            this.button7.TabIndex = 13;
            this.button7.Text = "ADD";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 470);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "CATEGORY";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 408);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "PRICE";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 346);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "QUANTITY";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 286);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "ENTITLED";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "REFERENCE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(312, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE PRODUCTS";
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.button5.Location = new System.Drawing.Point(1091, 2);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 42);
            this.button5.TabIndex = 4;
            this.button5.Text = "x";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.button3.Location = new System.Drawing.Point(16, 276);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 42);
            this.button3.TabIndex = 7;
            this.button3.Text = "Ordered";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.button2.Location = new System.Drawing.Point(16, 209);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "CONSULTATION";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buyer
            // 
            this.buyer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyer.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.buyer.Location = new System.Drawing.Point(16, 143);
            this.buyer.Margin = new System.Windows.Forms.Padding(4);
            this.buyer.Name = "buyer";
            this.buyer.Size = new System.Drawing.Size(141, 42);
            this.buyer.TabIndex = 5;
            this.buyer.Text = "BUYERS";
            this.buyer.UseVisualStyleBackColor = true;
            this.buyer.Click += new System.EventHandler(this.buyer_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 818);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buyer);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox Recherche;
        private System.Windows.Forms.TextBox refer;
        private System.Windows.Forms.TextBox prx;
        private System.Windows.Forms.TextBox qte;
        private System.Windows.Forms.TextBox intit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numCom;
        private System.Windows.Forms.Label label8;
	}
}
