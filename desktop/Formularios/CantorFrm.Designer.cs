namespace Festival.desktop
{
    partial class CantorFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CantorFrm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.memoObservacao = new DevExpress.XtraEditors.MemoEdit();
            this.bindingSourceCantor = new System.Windows.Forms.BindingSource(this.components);
            this.txtIdade = new DevExpress.XtraEditors.TextEdit();
            this.txtCpf = new DevExpress.XtraEditors.TextEdit();
            this.txtRg = new DevExpress.XtraEditors.TextEdit();
            this.btnInserir = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceApresentacao = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmusica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colartista = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtNome = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.pnliNome = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.pnliEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.pnliRg = new DevExpress.XtraLayout.LayoutControlItem();
            this.pnliCpf = new DevExpress.XtraLayout.LayoutControlItem();
            this.pnliIdade = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.pnliObservacao = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoObservacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCantor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCpf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceApresentacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnliNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnliEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnliRg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnliCpf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnliIdade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnliObservacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.memoObservacao);
            this.layoutControl1.Controls.Add(this.txtIdade);
            this.layoutControl1.Controls.Add(this.txtCpf);
            this.layoutControl1.Controls.Add(this.txtRg);
            this.layoutControl1.Controls.Add(this.btnInserir);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.txtEmail);
            this.layoutControl1.Controls.Add(this.txtNome);
            this.layoutControl1.Location = new System.Drawing.Point(16, 15);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(949, 553);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // memoObservacao
            // 
            this.memoObservacao.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceCantor, "observacao", true));
            this.memoObservacao.Location = new System.Drawing.Point(891, 64);
            this.memoObservacao.Name = "memoObservacao";
            this.memoObservacao.Size = new System.Drawing.Size(46, 26);
            this.memoObservacao.StyleController = this.layoutControl1;
            this.memoObservacao.TabIndex = 12;
            // 
            // bindingSourceCantor
            // 
            this.bindingSourceCantor.DataSource = typeof(Festival.or.Cantor);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(720, 64);
            this.txtIdade.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdade.MaximumSize = new System.Drawing.Size(53, 0);
            this.txtIdade.MinimumSize = new System.Drawing.Size(40, 0);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(40, 22);
            this.txtIdade.StyleController = this.layoutControl1;
            this.txtIdade.TabIndex = 11;
            // 
            // txtCpf
            // 
            this.txtCpf.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceCantor, "cpf", true));
            this.txtCpf.Location = new System.Drawing.Point(320, 64);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(355, 22);
            this.txtCpf.StyleController = this.layoutControl1;
            this.txtCpf.TabIndex = 10;
            // 
            // txtRg
            // 
            this.txtRg.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceCantor, "rg", true));
            this.txtRg.Location = new System.Drawing.Point(53, 64);
            this.txtRg.Margin = new System.Windows.Forms.Padding(4);
            this.txtRg.MinimumSize = new System.Drawing.Size(133, 0);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(222, 22);
            this.txtRg.StyleController = this.layoutControl1;
            this.txtRg.TabIndex = 9;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(476, 514);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(461, 27);
            this.btnInserir.StyleController = this.layoutControl1;
            this.btnInserir.TabIndex = 8;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSourceApresentacao;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(12, 124);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(925, 386);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bindingSourceApresentacao
            // 
            this.bindingSourceApresentacao.DataSource = typeof(Festival.or.Apresentacao);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colmusica,
            this.colartista,
            this.colcantor,
            this.colcategoria});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCodigo
            // 
            this.colCodigo.Caption = "Codigo";
            this.colCodigo.FieldName = "id_apresentacao";
            this.colCodigo.MinWidth = 27;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            this.colCodigo.Width = 96;
            // 
            // colmusica
            // 
            this.colmusica.FieldName = "musica";
            this.colmusica.MinWidth = 27;
            this.colmusica.Name = "colmusica";
            this.colmusica.Visible = true;
            this.colmusica.VisibleIndex = 1;
            this.colmusica.Width = 271;
            // 
            // colartista
            // 
            this.colartista.FieldName = "artista";
            this.colartista.MinWidth = 27;
            this.colartista.Name = "colartista";
            this.colartista.Visible = true;
            this.colartista.VisibleIndex = 2;
            this.colartista.Width = 271;
            // 
            // colcantor
            // 
            this.colcantor.FieldName = "cantor";
            this.colcantor.MinWidth = 27;
            this.colcantor.Name = "colcantor";
            this.colcantor.Width = 100;
            // 
            // colcategoria
            // 
            this.colcategoria.FieldName = "categoria";
            this.colcategoria.MinWidth = 27;
            this.colcategoria.Name = "colcategoria";
            this.colcategoria.Visible = true;
            this.colcategoria.VisibleIndex = 3;
            this.colcategoria.Width = 276;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceCantor, "email", true));
            this.txtEmail.Location = new System.Drawing.Point(53, 38);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(884, 22);
            this.txtEmail.StyleController = this.layoutControl1;
            this.txtEmail.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceCantor, "nome", true));
            this.txtNome.Location = new System.Drawing.Point(53, 12);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaximumSize = new System.Drawing.Size(300, 0);
            this.txtNome.Name = "txtNome";
            this.txtNome.Properties.MaxLength = 200;
            this.txtNome.Size = new System.Drawing.Size(300, 22);
            this.txtNome.StyleController = this.layoutControl1;
            this.txtNome.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.pnliNome,
            this.emptySpaceItem,
            this.pnliEmail,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.layoutControlItem5,
            this.pnliRg,
            this.pnliCpf,
            this.pnliIdade,
            this.emptySpaceItem2,
            this.pnliObservacao,
            this.emptySpaceItem3,
            this.emptySpaceItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(949, 553);
            this.Root.TextVisible = false;
            // 
            // pnliNome
            // 
            this.pnliNome.Control = this.txtNome;
            this.pnliNome.CustomizationFormText = "Nome";
            this.pnliNome.Location = new System.Drawing.Point(0, 0);
            this.pnliNome.Name = "pnliNome";
            this.pnliNome.ShowInCustomizationForm = false;
            this.pnliNome.Size = new System.Drawing.Size(345, 26);
            this.pnliNome.Text = "Nome:";
            this.pnliNome.TextSize = new System.Drawing.Size(38, 16);
            // 
            // emptySpaceItem
            // 
            this.emptySpaceItem.AllowHotTrack = false;
            this.emptySpaceItem.Location = new System.Drawing.Point(0, 82);
            this.emptySpaceItem.Name = "emptySpaceItem";
            this.emptySpaceItem.Size = new System.Drawing.Size(929, 10);
            this.emptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // pnliEmail
            // 
            this.pnliEmail.Control = this.txtEmail;
            this.pnliEmail.CustomizationFormText = "Email";
            this.pnliEmail.Location = new System.Drawing.Point(0, 26);
            this.pnliEmail.Name = "pnliEmail";
            this.pnliEmail.Size = new System.Drawing.Size(929, 26);
            this.pnliEmail.Text = "Email:";
            this.pnliEmail.TextSize = new System.Drawing.Size(38, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 112);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(929, 390);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 502);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(533, 0);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(13, 12);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(464, 31);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnInserir;
            this.layoutControlItem5.Location = new System.Drawing.Point(464, 502);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(465, 31);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // pnliRg
            // 
            this.pnliRg.AppearanceItemCaption.Options.UseTextOptions = true;
            this.pnliRg.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.pnliRg.Control = this.txtRg;
            this.pnliRg.CustomizationFormText = "RG";
            this.pnliRg.Location = new System.Drawing.Point(0, 52);
            this.pnliRg.MaxSize = new System.Drawing.Size(267, 30);
            this.pnliRg.MinSize = new System.Drawing.Size(131, 30);
            this.pnliRg.Name = "pnliRg";
            this.pnliRg.Size = new System.Drawing.Size(267, 30);
            this.pnliRg.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.pnliRg.Text = "RG:";
            this.pnliRg.TextLocation = DevExpress.Utils.Locations.Left;
            this.pnliRg.TextSize = new System.Drawing.Size(38, 16);
            // 
            // pnliCpf
            // 
            this.pnliCpf.AppearanceItemCaption.Options.UseTextOptions = true;
            this.pnliCpf.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.pnliCpf.Control = this.txtCpf;
            this.pnliCpf.CustomizationFormText = "CPF";
            this.pnliCpf.Location = new System.Drawing.Point(267, 52);
            this.pnliCpf.MaxSize = new System.Drawing.Size(400, 30);
            this.pnliCpf.MinSize = new System.Drawing.Size(131, 30);
            this.pnliCpf.Name = "pnliCpf";
            this.pnliCpf.ShowInCustomizationForm = false;
            this.pnliCpf.Size = new System.Drawing.Size(400, 30);
            this.pnliCpf.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.pnliCpf.Text = "CPF:";
            this.pnliCpf.TextSize = new System.Drawing.Size(38, 16);
            // 
            // pnliIdade
            // 
            this.pnliIdade.AppearanceItemCaption.Options.UseTextOptions = true;
            this.pnliIdade.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.pnliIdade.Control = this.txtIdade;
            this.pnliIdade.CustomizationFormText = "Idade";
            this.pnliIdade.Location = new System.Drawing.Point(667, 52);
            this.pnliIdade.MaxSize = new System.Drawing.Size(80, 30);
            this.pnliIdade.MinSize = new System.Drawing.Size(80, 30);
            this.pnliIdade.Name = "pnliIdade";
            this.pnliIdade.Size = new System.Drawing.Size(80, 30);
            this.pnliIdade.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.pnliIdade.Text = "Idade:";
            this.pnliIdade.TextSize = new System.Drawing.Size(38, 16);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(747, 52);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(91, 30);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // pnliObservacao
            // 
            this.pnliObservacao.Control = this.memoObservacao;
            this.pnliObservacao.Location = new System.Drawing.Point(838, 52);
            this.pnliObservacao.Name = "pnliObservacao";
            this.pnliObservacao.Size = new System.Drawing.Size(91, 30);
            this.pnliObservacao.Text = "Obs";
            this.pnliObservacao.TextSize = new System.Drawing.Size(38, 16);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(345, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(584, 26);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 92);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(929, 20);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // CantorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 578);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CantorFrm";
            this.Text = "CantorFrm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoObservacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCantor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCpf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceApresentacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnliNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnliEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnliRg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnliCpf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnliIdade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnliObservacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtNome;
        private DevExpress.XtraLayout.LayoutControlItem pnliNome;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem;
        private DevExpress.XtraLayout.LayoutControlItem pnliEmail;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource bindingSourceCantor;
        private System.Windows.Forms.BindingSource bindingSourceApresentacao;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colmusica;
        private DevExpress.XtraGrid.Columns.GridColumn colartista;
        private DevExpress.XtraGrid.Columns.GridColumn colcantor;
        private DevExpress.XtraGrid.Columns.GridColumn colcategoria;
        private DevExpress.XtraEditors.SimpleButton btnInserir;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.TextEdit txtCpf;
        private DevExpress.XtraEditors.TextEdit txtRg;
        private DevExpress.XtraLayout.LayoutControlItem pnliRg;
        private DevExpress.XtraLayout.LayoutControlItem pnliCpf;
        private DevExpress.XtraEditors.TextEdit txtIdade;
        private DevExpress.XtraLayout.LayoutControlItem pnliIdade;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.MemoEdit memoObservacao;
        private DevExpress.XtraLayout.LayoutControlItem pnliObservacao;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
    }
}