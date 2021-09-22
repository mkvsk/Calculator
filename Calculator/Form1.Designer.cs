
namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonZero = new Guna.UI2.WinForms.Guna2TileButton();
            this.buttonDelete = new Guna.UI2.WinForms.Guna2TileButton();
            this.labelExpression = new System.Windows.Forms.Label();
            this.buttonResult = new Guna.UI2.WinForms.Guna2TileButton();
            this.buttonCloseApp = new Guna.UI2.WinForms.Guna2TileButton();
            this.buttonOne = new Guna.UI2.WinForms.Guna2TileButton();
            this.buttonTwo = new Guna.UI2.WinForms.Guna2TileButton();
            this.buttonThree = new Guna.UI2.WinForms.Guna2TileButton();
            this.buttonFour = new Guna.UI2.WinForms.Guna2TileButton();
            this.buttonFive = new Guna.UI2.WinForms.Guna2TileButton();
            this.buttonSix = new Guna.UI2.WinForms.Guna2TileButton();
            this.buttonSeven = new Guna.UI2.WinForms.Guna2TileButton();
            this.buttonEight = new Guna.UI2.WinForms.Guna2TileButton();
            this.buttonNine = new Guna.UI2.WinForms.Guna2TileButton();
            this.buttonNull = new Guna.UI2.WinForms.Guna2TileButton();
            this.buttonDivision = new Guna.UI2.WinForms.Guna2TileButton();
            this.buttonMultiple = new Guna.UI2.WinForms.Guna2TileButton();
            this.buttonSubstract = new Guna.UI2.WinForms.Guna2TileButton();
            this.buttonAddition = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2TileButton2 = new Guna.UI2.WinForms.Guna2TileButton();
            this.buttonPercent = new Guna.UI2.WinForms.Guna2TileButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.buttonPercent);
            this.panel1.Controls.Add(this.guna2TileButton2);
            this.panel1.Controls.Add(this.guna2TileButton1);
            this.panel1.Controls.Add(this.buttonZero);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.labelExpression);
            this.panel1.Controls.Add(this.buttonResult);
            this.panel1.Controls.Add(this.buttonCloseApp);
            this.panel1.Controls.Add(this.buttonOne);
            this.panel1.Controls.Add(this.buttonTwo);
            this.panel1.Controls.Add(this.buttonThree);
            this.panel1.Controls.Add(this.buttonFour);
            this.panel1.Controls.Add(this.buttonFive);
            this.panel1.Controls.Add(this.buttonSix);
            this.panel1.Controls.Add(this.buttonSeven);
            this.panel1.Controls.Add(this.buttonEight);
            this.panel1.Controls.Add(this.buttonNine);
            this.panel1.Controls.Add(this.buttonNull);
            this.panel1.Controls.Add(this.buttonDivision);
            this.panel1.Controls.Add(this.buttonMultiple);
            this.panel1.Controls.Add(this.buttonSubstract);
            this.panel1.Controls.Add(this.buttonAddition);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(-5, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 615);
            this.panel1.TabIndex = 1;
            // 
            // buttonZero
            // 
            this.buttonZero.BackColor = System.Drawing.Color.Transparent;
            this.buttonZero.CheckedState.Parent = this.buttonZero;
            this.buttonZero.CustomImages.Parent = this.buttonZero;
            this.buttonZero.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonZero.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonZero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonZero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonZero.DisabledState.Parent = this.buttonZero;
            this.buttonZero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonZero.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.buttonZero.ForeColor = System.Drawing.Color.White;
            this.buttonZero.HoverState.Parent = this.buttonZero;
            this.buttonZero.Location = new System.Drawing.Point(17, 390);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.ShadowDecoration.Parent = this.buttonZero;
            this.buttonZero.Size = new System.Drawing.Size(60, 60);
            this.buttonZero.TabIndex = 20;
            this.buttonZero.Text = "0";
            this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.CheckedState.Parent = this.buttonDelete;
            this.buttonDelete.CustomImages.Parent = this.buttonDelete;
            this.buttonDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDelete.DisabledState.Parent = this.buttonDelete;
            this.buttonDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(220)))), ((int)(((byte)(165)))));
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.HoverState.Parent = this.buttonDelete;
            this.buttonDelete.Location = new System.Drawing.Point(77, 150);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.ShadowDecoration.Parent = this.buttonDelete;
            this.buttonDelete.Size = new System.Drawing.Size(60, 60);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "⭯";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelExpression
            // 
            this.labelExpression.AutoSize = true;
            this.labelExpression.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExpression.ForeColor = System.Drawing.Color.White;
            this.labelExpression.Location = new System.Drawing.Point(12, 53);
            this.labelExpression.Name = "labelExpression";
            this.labelExpression.Size = new System.Drawing.Size(103, 25);
            this.labelExpression.TabIndex = 23;
            this.labelExpression.Text = "expression";
            // 
            // buttonResult
            // 
            this.buttonResult.CheckedState.Parent = this.buttonResult;
            this.buttonResult.CustomImages.Parent = this.buttonResult;
            this.buttonResult.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonResult.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonResult.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonResult.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonResult.DisabledState.Parent = this.buttonResult;
            this.buttonResult.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(220)))), ((int)(((byte)(165)))));
            this.buttonResult.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.buttonResult.ForeColor = System.Drawing.Color.White;
            this.buttonResult.HoverState.Parent = this.buttonResult;
            this.buttonResult.Location = new System.Drawing.Point(137, 150);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.ShadowDecoration.Parent = this.buttonResult;
            this.buttonResult.Size = new System.Drawing.Size(60, 60);
            this.buttonResult.TabIndex = 2;
            this.buttonResult.Text = "=";
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonCloseApp
            // 
            this.buttonCloseApp.CheckedState.Parent = this.buttonCloseApp;
            this.buttonCloseApp.CustomImages.Parent = this.buttonCloseApp;
            this.buttonCloseApp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCloseApp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCloseApp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCloseApp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCloseApp.DisabledState.Parent = this.buttonCloseApp;
            this.buttonCloseApp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCloseApp.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseApp.ForeColor = System.Drawing.Color.White;
            this.buttonCloseApp.HoverState.Parent = this.buttonCloseApp;
            this.buttonCloseApp.Location = new System.Drawing.Point(239, 3);
            this.buttonCloseApp.Name = "buttonCloseApp";
            this.buttonCloseApp.ShadowDecoration.Parent = this.buttonCloseApp;
            this.buttonCloseApp.Size = new System.Drawing.Size(30, 30);
            this.buttonCloseApp.TabIndex = 24;
            this.buttonCloseApp.Text = "×";
            this.buttonCloseApp.Click += new System.EventHandler(this.buttonCloseApp_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.CheckedState.Parent = this.buttonOne;
            this.buttonOne.CustomImages.Parent = this.buttonOne;
            this.buttonOne.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonOne.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonOne.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonOne.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonOne.DisabledState.Parent = this.buttonOne;
            this.buttonOne.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonOne.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.buttonOne.ForeColor = System.Drawing.Color.White;
            this.buttonOne.HoverState.Parent = this.buttonOne;
            this.buttonOne.Location = new System.Drawing.Point(17, 330);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.ShadowDecoration.Parent = this.buttonOne;
            this.buttonOne.Size = new System.Drawing.Size(60, 60);
            this.buttonOne.TabIndex = 18;
            this.buttonOne.Text = "1";
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.CheckedState.Parent = this.buttonTwo;
            this.buttonTwo.CustomImages.Parent = this.buttonTwo;
            this.buttonTwo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonTwo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonTwo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonTwo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonTwo.DisabledState.Parent = this.buttonTwo;
            this.buttonTwo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonTwo.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.buttonTwo.ForeColor = System.Drawing.Color.White;
            this.buttonTwo.HoverState.Parent = this.buttonTwo;
            this.buttonTwo.Location = new System.Drawing.Point(77, 330);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.ShadowDecoration.Parent = this.buttonTwo;
            this.buttonTwo.Size = new System.Drawing.Size(60, 60);
            this.buttonTwo.TabIndex = 17;
            this.buttonTwo.Text = "2";
            this.buttonTwo.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.CheckedState.Parent = this.buttonThree;
            this.buttonThree.CustomImages.Parent = this.buttonThree;
            this.buttonThree.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonThree.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonThree.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonThree.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonThree.DisabledState.Parent = this.buttonThree;
            this.buttonThree.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonThree.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.buttonThree.ForeColor = System.Drawing.Color.White;
            this.buttonThree.HoverState.Parent = this.buttonThree;
            this.buttonThree.Location = new System.Drawing.Point(137, 330);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.ShadowDecoration.Parent = this.buttonThree;
            this.buttonThree.Size = new System.Drawing.Size(60, 60);
            this.buttonThree.TabIndex = 16;
            this.buttonThree.Text = "3";
            this.buttonThree.Click += new System.EventHandler(this.buttonThree_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.CheckedState.Parent = this.buttonFour;
            this.buttonFour.CustomImages.Parent = this.buttonFour;
            this.buttonFour.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonFour.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonFour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonFour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonFour.DisabledState.Parent = this.buttonFour;
            this.buttonFour.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonFour.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.buttonFour.ForeColor = System.Drawing.Color.White;
            this.buttonFour.HoverState.Parent = this.buttonFour;
            this.buttonFour.Location = new System.Drawing.Point(17, 270);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.ShadowDecoration.Parent = this.buttonFour;
            this.buttonFour.Size = new System.Drawing.Size(60, 60);
            this.buttonFour.TabIndex = 15;
            this.buttonFour.Text = "4";
            this.buttonFour.Click += new System.EventHandler(this.buttonFour_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.CheckedState.Parent = this.buttonFive;
            this.buttonFive.CustomImages.Parent = this.buttonFive;
            this.buttonFive.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonFive.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonFive.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonFive.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonFive.DisabledState.Parent = this.buttonFive;
            this.buttonFive.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonFive.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.buttonFive.ForeColor = System.Drawing.Color.White;
            this.buttonFive.HoverState.Parent = this.buttonFive;
            this.buttonFive.Location = new System.Drawing.Point(77, 270);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.ShadowDecoration.Parent = this.buttonFive;
            this.buttonFive.Size = new System.Drawing.Size(60, 60);
            this.buttonFive.TabIndex = 14;
            this.buttonFive.Text = "5";
            this.buttonFive.Click += new System.EventHandler(this.buttonFive_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.CheckedState.Parent = this.buttonSix;
            this.buttonSix.CustomImages.Parent = this.buttonSix;
            this.buttonSix.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSix.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSix.DisabledState.Parent = this.buttonSix;
            this.buttonSix.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSix.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.buttonSix.ForeColor = System.Drawing.Color.White;
            this.buttonSix.HoverState.Parent = this.buttonSix;
            this.buttonSix.Location = new System.Drawing.Point(137, 270);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.ShadowDecoration.Parent = this.buttonSix;
            this.buttonSix.Size = new System.Drawing.Size(60, 60);
            this.buttonSix.TabIndex = 13;
            this.buttonSix.Text = "6";
            this.buttonSix.Click += new System.EventHandler(this.buttonSix_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.CheckedState.Parent = this.buttonSeven;
            this.buttonSeven.CustomImages.Parent = this.buttonSeven;
            this.buttonSeven.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSeven.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSeven.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSeven.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSeven.DisabledState.Parent = this.buttonSeven;
            this.buttonSeven.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSeven.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.buttonSeven.ForeColor = System.Drawing.Color.White;
            this.buttonSeven.HoverState.Parent = this.buttonSeven;
            this.buttonSeven.Location = new System.Drawing.Point(17, 210);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.ShadowDecoration.Parent = this.buttonSeven;
            this.buttonSeven.Size = new System.Drawing.Size(60, 60);
            this.buttonSeven.TabIndex = 12;
            this.buttonSeven.Text = "7";
            this.buttonSeven.Click += new System.EventHandler(this.buttonSeven_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.CheckedState.Parent = this.buttonEight;
            this.buttonEight.CustomImages.Parent = this.buttonEight;
            this.buttonEight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonEight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonEight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonEight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonEight.DisabledState.Parent = this.buttonEight;
            this.buttonEight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonEight.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.buttonEight.ForeColor = System.Drawing.Color.White;
            this.buttonEight.HoverState.Parent = this.buttonEight;
            this.buttonEight.Location = new System.Drawing.Point(77, 210);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.ShadowDecoration.Parent = this.buttonEight;
            this.buttonEight.Size = new System.Drawing.Size(60, 60);
            this.buttonEight.TabIndex = 11;
            this.buttonEight.Text = "8";
            this.buttonEight.Click += new System.EventHandler(this.buttonEight_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.CheckedState.Parent = this.buttonNine;
            this.buttonNine.CustomImages.Parent = this.buttonNine;
            this.buttonNine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonNine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonNine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonNine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonNine.DisabledState.Parent = this.buttonNine;
            this.buttonNine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonNine.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.buttonNine.ForeColor = System.Drawing.Color.White;
            this.buttonNine.HoverState.Parent = this.buttonNine;
            this.buttonNine.Location = new System.Drawing.Point(137, 210);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.ShadowDecoration.Parent = this.buttonNine;
            this.buttonNine.Size = new System.Drawing.Size(60, 60);
            this.buttonNine.TabIndex = 10;
            this.buttonNine.Text = "9";
            this.buttonNine.Click += new System.EventHandler(this.buttonNine_Click);
            // 
            // buttonNull
            // 
            this.buttonNull.CheckedState.Parent = this.buttonNull;
            this.buttonNull.CustomImages.Parent = this.buttonNull;
            this.buttonNull.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonNull.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonNull.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonNull.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonNull.DisabledState.Parent = this.buttonNull;
            this.buttonNull.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(220)))), ((int)(((byte)(165)))));
            this.buttonNull.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNull.ForeColor = System.Drawing.Color.White;
            this.buttonNull.HoverState.Parent = this.buttonNull;
            this.buttonNull.Location = new System.Drawing.Point(17, 150);
            this.buttonNull.Name = "buttonNull";
            this.buttonNull.ShadowDecoration.Parent = this.buttonNull;
            this.buttonNull.Size = new System.Drawing.Size(60, 60);
            this.buttonNull.TabIndex = 9;
            this.buttonNull.Text = "AC";
            this.buttonNull.Click += new System.EventHandler(this.buttonNull_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.CheckedState.Parent = this.buttonDivision;
            this.buttonDivision.CustomImages.Parent = this.buttonDivision;
            this.buttonDivision.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDivision.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDivision.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDivision.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDivision.DisabledState.Parent = this.buttonDivision;
            this.buttonDivision.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(220)))), ((int)(((byte)(165)))));
            this.buttonDivision.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.buttonDivision.ForeColor = System.Drawing.Color.White;
            this.buttonDivision.HoverState.Parent = this.buttonDivision;
            this.buttonDivision.Location = new System.Drawing.Point(197, 210);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.ShadowDecoration.Parent = this.buttonDivision;
            this.buttonDivision.Size = new System.Drawing.Size(60, 60);
            this.buttonDivision.TabIndex = 6;
            this.buttonDivision.Text = "÷";
            this.buttonDivision.Click += new System.EventHandler(this.buttonDivision_Click);
            // 
            // buttonMultiple
            // 
            this.buttonMultiple.BackColor = System.Drawing.Color.Transparent;
            this.buttonMultiple.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMultiple.BackgroundImage")));
            this.buttonMultiple.CheckedState.Parent = this.buttonMultiple;
            this.buttonMultiple.CustomImages.Parent = this.buttonMultiple;
            this.buttonMultiple.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonMultiple.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonMultiple.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonMultiple.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonMultiple.DisabledState.Parent = this.buttonMultiple;
            this.buttonMultiple.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(220)))), ((int)(((byte)(165)))));
            this.buttonMultiple.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.buttonMultiple.ForeColor = System.Drawing.Color.White;
            this.buttonMultiple.HoverState.Parent = this.buttonMultiple;
            this.buttonMultiple.Location = new System.Drawing.Point(197, 270);
            this.buttonMultiple.Name = "buttonMultiple";
            this.buttonMultiple.ShadowDecoration.Parent = this.buttonMultiple;
            this.buttonMultiple.Size = new System.Drawing.Size(60, 60);
            this.buttonMultiple.TabIndex = 5;
            this.buttonMultiple.Text = "×";
            this.buttonMultiple.Click += new System.EventHandler(this.buttonMultiple_Click);
            // 
            // buttonSubstract
            // 
            this.buttonSubstract.CheckedState.Parent = this.buttonSubstract;
            this.buttonSubstract.CustomImages.Parent = this.buttonSubstract;
            this.buttonSubstract.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSubstract.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSubstract.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSubstract.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSubstract.DisabledState.Parent = this.buttonSubstract;
            this.buttonSubstract.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(220)))), ((int)(((byte)(165)))));
            this.buttonSubstract.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.buttonSubstract.ForeColor = System.Drawing.Color.White;
            this.buttonSubstract.HoverState.Parent = this.buttonSubstract;
            this.buttonSubstract.Location = new System.Drawing.Point(197, 330);
            this.buttonSubstract.Name = "buttonSubstract";
            this.buttonSubstract.ShadowDecoration.Parent = this.buttonSubstract;
            this.buttonSubstract.Size = new System.Drawing.Size(60, 60);
            this.buttonSubstract.TabIndex = 4;
            this.buttonSubstract.Text = "−";
            this.buttonSubstract.Click += new System.EventHandler(this.buttonSubstract_Click);
            // 
            // buttonAddition
            // 
            this.buttonAddition.CheckedState.Parent = this.buttonAddition;
            this.buttonAddition.CustomImages.Parent = this.buttonAddition;
            this.buttonAddition.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAddition.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAddition.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAddition.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAddition.DisabledState.Parent = this.buttonAddition;
            this.buttonAddition.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(220)))), ((int)(((byte)(165)))));
            this.buttonAddition.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.buttonAddition.ForeColor = System.Drawing.Color.White;
            this.buttonAddition.HoverState.Parent = this.buttonAddition;
            this.buttonAddition.Location = new System.Drawing.Point(197, 390);
            this.buttonAddition.Name = "buttonAddition";
            this.buttonAddition.ShadowDecoration.Parent = this.buttonAddition;
            this.buttonAddition.Size = new System.Drawing.Size(60, 60);
            this.buttonAddition.TabIndex = 3;
            this.buttonAddition.Text = "+";
            this.buttonAddition.Click += new System.EventHandler(this.buttonAddition_Click);
            // 
            // guna2TileButton1
            // 
            this.guna2TileButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TileButton1.CheckedState.Parent = this.guna2TileButton1;
            this.guna2TileButton1.CustomImages.Parent = this.guna2TileButton1;
            this.guna2TileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton1.DisabledState.Parent = this.guna2TileButton1;
            this.guna2TileButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2TileButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.guna2TileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton1.HoverState.Parent = this.guna2TileButton1;
            this.guna2TileButton1.Location = new System.Drawing.Point(77, 390);
            this.guna2TileButton1.Name = "guna2TileButton1";
            this.guna2TileButton1.ShadowDecoration.Parent = this.guna2TileButton1;
            this.guna2TileButton1.Size = new System.Drawing.Size(60, 60);
            this.guna2TileButton1.TabIndex = 25;
            this.guna2TileButton1.Text = "∙";
            this.guna2TileButton1.Visible = false;
            // 
            // guna2TileButton2
            // 
            this.guna2TileButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2TileButton2.CheckedState.Parent = this.guna2TileButton2;
            this.guna2TileButton2.CustomImages.Parent = this.guna2TileButton2;
            this.guna2TileButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton2.DisabledState.Parent = this.guna2TileButton2;
            this.guna2TileButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2TileButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.guna2TileButton2.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton2.HoverState.Parent = this.guna2TileButton2;
            this.guna2TileButton2.Location = new System.Drawing.Point(137, 390);
            this.guna2TileButton2.Name = "guna2TileButton2";
            this.guna2TileButton2.ShadowDecoration.Parent = this.guna2TileButton2;
            this.guna2TileButton2.Size = new System.Drawing.Size(60, 60);
            this.guna2TileButton2.TabIndex = 26;
            this.guna2TileButton2.Text = "±";
            this.guna2TileButton2.Visible = false;
            // 
            // buttonPercent
            // 
            this.buttonPercent.CheckedState.Parent = this.buttonPercent;
            this.buttonPercent.CustomImages.Parent = this.buttonPercent;
            this.buttonPercent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonPercent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonPercent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonPercent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonPercent.DisabledState.Parent = this.buttonPercent;
            this.buttonPercent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(220)))), ((int)(((byte)(165)))));
            this.buttonPercent.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.buttonPercent.ForeColor = System.Drawing.Color.White;
            this.buttonPercent.HoverState.Parent = this.buttonPercent;
            this.buttonPercent.Location = new System.Drawing.Point(197, 150);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.ShadowDecoration.Parent = this.buttonPercent;
            this.buttonPercent.Size = new System.Drawing.Size(60, 60);
            this.buttonPercent.TabIndex = 27;
            this.buttonPercent.Text = "%";
            this.buttonPercent.Visible = false;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 456);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TileButton buttonResult;
        private Guna.UI2.WinForms.Guna2TileButton buttonZero;
        private Guna.UI2.WinForms.Guna2TileButton buttonOne;
        private Guna.UI2.WinForms.Guna2TileButton buttonTwo;
        private Guna.UI2.WinForms.Guna2TileButton buttonThree;
        private Guna.UI2.WinForms.Guna2TileButton buttonFour;
        private Guna.UI2.WinForms.Guna2TileButton buttonFive;
        private Guna.UI2.WinForms.Guna2TileButton buttonSix;
        private Guna.UI2.WinForms.Guna2TileButton buttonSeven;
        private Guna.UI2.WinForms.Guna2TileButton buttonEight;
        private Guna.UI2.WinForms.Guna2TileButton buttonNine;
        private Guna.UI2.WinForms.Guna2TileButton buttonNull;
        private Guna.UI2.WinForms.Guna2TileButton buttonDelete;
        private Guna.UI2.WinForms.Guna2TileButton buttonDivision;
        private Guna.UI2.WinForms.Guna2TileButton buttonMultiple;
        private Guna.UI2.WinForms.Guna2TileButton buttonSubstract;
        private Guna.UI2.WinForms.Guna2TileButton buttonAddition;
        private System.Windows.Forms.Label labelExpression;
        private Guna.UI2.WinForms.Guna2TileButton buttonCloseApp;
        private Guna.UI2.WinForms.Guna2TileButton buttonPercent;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton2;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
    }
}

