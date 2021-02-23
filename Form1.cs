using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Calculator
{   
	public class Calc : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.Button btn_sbros;
		private System.Windows.Forms.Button btnChangesign;
		private System.Windows.Forms.Button btnpoint;
		private System.Windows.Forms.Button btn_ravno;
		private System.Windows.Forms.Button btn_delenie;
		private System.Windows.Forms.Button btn_umnojenie;
		private System.Windows.Forms.Button btn_plus;
		private System.Windows.Forms.Button btn_minus;
        private Button btn_stepen;
        private Button btn_koren;
        private Button btn_obrZnach;
        private Button btn_kvadrat;        
        private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn1;
        private IContainer components;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem standartToolStripMenuItem;
        private ToolStripMenuItem injenerToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem1;
        private ToolTip DeystvieToolTip;

        /// <summary>
        /// Объявляем и инициализируем константы, которые будут
        /// появляться на экране при нажатии соответствующих кнопок.
        /// </summary>
        private const string Odin = "1";
		private const string Dva = "2";
		private const string Tri = "3";
		private const string Chetire = "4";
		private const string Pyat = "5";
		private const string Shest = "6";
		private const string Sem = "7";
		private const string Vosem = "8";
		private const string Devyat = "9";       
        private const string Nul = "0";       

        //Для смещение ЭУ в зависимости от вида калькулятора (40 - ширина кнопки)
        private const int MovR = 40;
        private Button btn_KubKoren;
        private Button btn_Factorial;
        private Button btn_KvUr;
        public TextBox textBox_Factorial;
        private BackgroundWorker backgroundWorker1;

        //Переменные:
        bool standartCalculator = true;
        int factorial;
        bool znachenieFuctoriala;
        
        public Calc()
		{
			InitializeComponent();
			// При запуске приложения на экране будет нуль
			txtOutput.Text = "0";		
		}

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calc));
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btn_sbros = new System.Windows.Forms.Button();
            this.btnChangesign = new System.Windows.Forms.Button();
            this.btnpoint = new System.Windows.Forms.Button();
            this.btn_ravno = new System.Windows.Forms.Button();
            this.btn_delenie = new System.Windows.Forms.Button();
            this.btn_umnojenie = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.injenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_stepen = new System.Windows.Forms.Button();
            this.btn_koren = new System.Windows.Forms.Button();
            this.btn_obrZnach = new System.Windows.Forms.Button();
            this.btn_kvadrat = new System.Windows.Forms.Button();
            this.DeystvieToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_KubKoren = new System.Windows.Forms.Button();
            this.btn_Factorial = new System.Windows.Forms.Button();
            this.btn_KvUr = new System.Windows.Forms.Button();
            this.textBox_Factorial = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.AccessibleName = "Display";
            this.txtOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOutput.Location = new System.Drawing.Point(12, 46);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(288, 30);
            this.txtOutput.TabIndex = 60;
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_sbros
            // 
            this.btn_sbros.AccessibleName = "reset";
            this.btn_sbros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sbros.Location = new System.Drawing.Point(240, 92);
            this.btn_sbros.Name = "btn_sbros";
            this.btn_sbros.Size = new System.Drawing.Size(48, 93);
            this.btn_sbros.TabIndex = 0;
            this.btn_sbros.Text = "C";
            this.DeystvieToolTip.SetToolTip(this.btn_sbros, "Сброс");
            this.btn_sbros.Click += new System.EventHandler(this.btn_sbros_Click);
            // 
            // btnChangesign
            // 
            this.btnChangesign.AccessibleName = "change sign";
            this.btnChangesign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangesign.Location = new System.Drawing.Point(72, 231);
            this.btnChangesign.Name = "btnChangesign";
            this.btnChangesign.Size = new System.Drawing.Size(48, 46);
            this.btnChangesign.TabIndex = 58;
            this.btnChangesign.Text = "+/-";
            this.btnChangesign.Click += new System.EventHandler(this.btnChangesign_Click);
            // 
            // btnpoint
            // 
            this.btnpoint.AccessibleName = "point ";
            this.btnpoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpoint.Location = new System.Drawing.Point(120, 231);
            this.btnpoint.Name = "btnpoint";
            this.btnpoint.Size = new System.Drawing.Size(48, 46);
            this.btnpoint.TabIndex = 57;
            this.btnpoint.Text = ",";
            this.btnpoint.Click += new System.EventHandler(this.btnpoint_Click);
            // 
            // btn_ravno
            // 
            this.btn_ravno.AccessibleDescription = "ravno";
            this.btn_ravno.AccessibleName = "equal";
            this.btn_ravno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ravno.Location = new System.Drawing.Point(240, 185);
            this.btn_ravno.Name = "btn_ravno";
            this.btn_ravno.Size = new System.Drawing.Size(48, 92);
            this.btn_ravno.TabIndex = 56;
            this.btn_ravno.Text = "=";
            this.DeystvieToolTip.SetToolTip(this.btn_ravno, "Результат");
            this.btn_ravno.Click += new System.EventHandler(this.btn_ravno_Click);
            // 
            // btn_delenie
            // 
            this.btn_delenie.AccessibleName = "divide ";
            this.btn_delenie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delenie.Location = new System.Drawing.Point(192, 92);
            this.btn_delenie.Name = "btn_delenie";
            this.btn_delenie.Size = new System.Drawing.Size(48, 46);
            this.btn_delenie.TabIndex = 55;
            this.btn_delenie.Text = "/";
            this.DeystvieToolTip.SetToolTip(this.btn_delenie, "Деление");
            this.btn_delenie.Click += new System.EventHandler(this.btn_delenie_Click);
            // 
            // btn_umnojenie
            // 
            this.btn_umnojenie.AccessibleName = "multiply ";
            this.btn_umnojenie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_umnojenie.Location = new System.Drawing.Point(192, 138);
            this.btn_umnojenie.Name = "btn_umnojenie";
            this.btn_umnojenie.Size = new System.Drawing.Size(48, 47);
            this.btn_umnojenie.TabIndex = 54;
            this.btn_umnojenie.Text = "*";
            this.DeystvieToolTip.SetToolTip(this.btn_umnojenie, "Умножение");
            this.btn_umnojenie.Click += new System.EventHandler(this.btn_umnojenie_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.AccessibleName = "plus ";
            this.btn_plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_plus.Location = new System.Drawing.Point(192, 231);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(48, 46);
            this.btn_plus.TabIndex = 53;
            this.btn_plus.Text = "+";
            this.DeystvieToolTip.SetToolTip(this.btn_plus, "Сложение");
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.AccessibleName = "minus ";
            this.btn_minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minus.Location = new System.Drawing.Point(192, 185);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(48, 46);
            this.btn_minus.TabIndex = 52;
            this.btn_minus.Text = "-";
            this.DeystvieToolTip.SetToolTip(this.btn_minus, "Вычитание");
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn0
            // 
            this.btn0.AccessibleName = "zero";
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.Location = new System.Drawing.Point(24, 231);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(48, 46);
            this.btn0.TabIndex = 51;
            this.btn0.Text = "0";
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.AccessibleName = "nine ";
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.Location = new System.Drawing.Point(120, 92);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(48, 46);
            this.btn9.TabIndex = 50;
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.AccessibleName = "eight ";
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.Location = new System.Drawing.Point(72, 92);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(48, 46);
            this.btn8.TabIndex = 49;
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.AccessibleName = "seven ";
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.Location = new System.Drawing.Point(24, 92);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(48, 46);
            this.btn7.TabIndex = 48;
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.AccessibleName = "six ";
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.Location = new System.Drawing.Point(120, 138);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(48, 47);
            this.btn6.TabIndex = 47;
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.AccessibleName = "five ";
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.Location = new System.Drawing.Point(72, 138);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(48, 47);
            this.btn5.TabIndex = 46;
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.AccessibleName = "four ";
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.Location = new System.Drawing.Point(24, 138);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(48, 47);
            this.btn4.TabIndex = 45;
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.AccessibleName = "three ";
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.Location = new System.Drawing.Point(120, 185);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(48, 46);
            this.btn3.TabIndex = 44;
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.AccessibleName = "two ";
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.Location = new System.Drawing.Point(72, 185);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(48, 46);
            this.btn2.TabIndex = 43;
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.AccessibleName = "one ";
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Location = new System.Drawing.Point(24, 185);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(48, 46);
            this.btn1.TabIndex = 42;
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(307, 28);
            this.menuStrip1.TabIndex = 61;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standartToolStripMenuItem,
            this.injenerToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.viewToolStripMenuItem.Text = "Вид";
            // 
            // standartToolStripMenuItem
            // 
            this.standartToolStripMenuItem.Enabled = false;
            this.standartToolStripMenuItem.Name = "standartToolStripMenuItem";
            this.standartToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.standartToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.standartToolStripMenuItem.Text = "Стандартный";
            this.standartToolStripMenuItem.Click += new System.EventHandler(this.standartToolStripMenuItem_Click);
            // 
            // injenerToolStripMenuItem
            // 
            this.injenerToolStripMenuItem.Name = "injenerToolStripMenuItem";
            this.injenerToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.injenerToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.injenerToolStripMenuItem.Text = "Инженерный";
            this.injenerToolStripMenuItem.Click += new System.EventHandler(this.injenerToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.undoToolStripMenuItem.Text = "Назад";
            // 
            // redoToolStripMenuItem1
            // 
            this.redoToolStripMenuItem1.Name = "redoToolStripMenuItem1";
            this.redoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem1.Size = new System.Drawing.Size(74, 24);
            this.redoToolStripMenuItem1.Text = "Вперёд";
            // 
            // btn_stepen
            // 
            this.btn_stepen.AccessibleName = "divide ";
            this.btn_stepen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stepen.Location = new System.Drawing.Point(240, 92);
            this.btn_stepen.Name = "btn_stepen";
            this.btn_stepen.Size = new System.Drawing.Size(48, 46);
            this.btn_stepen.TabIndex = 62;
            this.btn_stepen.Text = "x^y";
            this.DeystvieToolTip.SetToolTip(this.btn_stepen, "Возведение в степень");
            this.btn_stepen.Visible = false;
            this.btn_stepen.Click += new System.EventHandler(this.btn_stepen_Click);
            // 
            // btn_koren
            // 
            this.btn_koren.AccessibleName = "divide ";
            this.btn_koren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_koren.Location = new System.Drawing.Point(240, 138);
            this.btn_koren.Name = "btn_koren";
            this.btn_koren.Size = new System.Drawing.Size(48, 47);
            this.btn_koren.TabIndex = 63;
            this.btn_koren.Text = "√";
            this.DeystvieToolTip.SetToolTip(this.btn_koren, "Корень квадратный");
            this.btn_koren.Visible = false;
            this.btn_koren.Click += new System.EventHandler(this.btn_koren_Click);
            // 
            // btn_obrZnach
            // 
            this.btn_obrZnach.AccessibleName = "divide ";
            this.btn_obrZnach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_obrZnach.Location = new System.Drawing.Point(240, 185);
            this.btn_obrZnach.Name = "btn_obrZnach";
            this.btn_obrZnach.Size = new System.Drawing.Size(48, 46);
            this.btn_obrZnach.TabIndex = 64;
            this.btn_obrZnach.Text = "1/x";
            this.DeystvieToolTip.SetToolTip(this.btn_obrZnach, "Обратное значение");
            this.btn_obrZnach.Visible = false;
            this.btn_obrZnach.Click += new System.EventHandler(this.btn_obrZnach_Click);
            // 
            // btn_kvadrat
            // 
            this.btn_kvadrat.AccessibleName = "divide ";
            this.btn_kvadrat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kvadrat.Location = new System.Drawing.Point(240, 231);
            this.btn_kvadrat.Name = "btn_kvadrat";
            this.btn_kvadrat.Size = new System.Drawing.Size(48, 46);
            this.btn_kvadrat.TabIndex = 65;
            this.btn_kvadrat.Text = "x^2";
            this.DeystvieToolTip.SetToolTip(this.btn_kvadrat, "Квадрат числа");
            this.btn_kvadrat.Visible = false;
            this.btn_kvadrat.Click += new System.EventHandler(this.btn_kvadrat_Click);
            // 
            // btn_KubKoren
            // 
            this.btn_KubKoren.AccessibleName = "divide ";
            this.btn_KubKoren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KubKoren.Location = new System.Drawing.Point(240, 138);
            this.btn_KubKoren.Name = "btn_KubKoren";
            this.btn_KubKoren.Size = new System.Drawing.Size(48, 47);
            this.btn_KubKoren.TabIndex = 66;
            this.btn_KubKoren.Text = "∛";
            this.DeystvieToolTip.SetToolTip(this.btn_KubKoren, "Корень кубический");
            this.btn_KubKoren.Visible = false;
            this.btn_KubKoren.Click += new System.EventHandler(this.btn_KubKoren_Click);
            // 
            // btn_Factorial
            // 
            this.btn_Factorial.AccessibleName = "divide ";
            this.btn_Factorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Factorial.Location = new System.Drawing.Point(120, 231);
            this.btn_Factorial.Name = "btn_Factorial";
            this.btn_Factorial.Size = new System.Drawing.Size(120, 46);
            this.btn_Factorial.TabIndex = 67;
            this.btn_Factorial.Text = "n!";
            this.DeystvieToolTip.SetToolTip(this.btn_Factorial, "Факториал");
            this.btn_Factorial.Visible = false;
            this.btn_Factorial.Click += new System.EventHandler(this.btn_Factorial_Click);
            // 
            // btn_KvUr
            // 
            this.btn_KvUr.AccessibleName = "divide ";
            this.btn_KvUr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KvUr.Location = new System.Drawing.Point(240, 92);
            this.btn_KvUr.Name = "btn_KvUr";
            this.btn_KvUr.Size = new System.Drawing.Size(48, 46);
            this.btn_KvUr.TabIndex = 68;
            this.btn_KvUr.Text = "KvUr";
            this.DeystvieToolTip.SetToolTip(this.btn_KvUr, "Решение квадратного уравнения");
            this.btn_KvUr.Visible = false;
            this.btn_KvUr.Click += new System.EventHandler(this.btn_KvUr_Click);
            // 
            // textBox_Factorial
            // 
            this.textBox_Factorial.AccessibleName = "Display";
            this.textBox_Factorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox_Factorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Factorial.Location = new System.Drawing.Point(12, 46);
            this.textBox_Factorial.Name = "textBox_Factorial";
            this.textBox_Factorial.ReadOnly = true;
            this.textBox_Factorial.Size = new System.Drawing.Size(288, 30);
            this.textBox_Factorial.TabIndex = 69;
            this.textBox_Factorial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DeystvieToolTip.SetToolTip(this.textBox_Factorial, "Значение факториала");
            this.textBox_Factorial.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Calc
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(307, 296);
            this.Controls.Add(this.textBox_Factorial);
            this.Controls.Add(this.btn_KvUr);
            this.Controls.Add(this.btn_Factorial);
            this.Controls.Add(this.btn_KubKoren);
            this.Controls.Add(this.btn_kvadrat);
            this.Controls.Add(this.btn_obrZnach);
            this.Controls.Add(this.btn_koren);
            this.Controls.Add(this.btn_stepen);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btn_sbros);
            this.Controls.Add(this.btnChangesign);
            this.Controls.Add(this.btnpoint);
            this.Controls.Add(this.btn_ravno);
            this.Controls.Add(this.btn_delenie);
            this.Controls.Add(this.btn_umnojenie);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор (обычный)";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run ( new Calc() );
        }

        /// <summary>
        /// Обработчики событий кнопок для обращения к методу chislonaEkrane класса mehanizmcalkulyatora
        /// и передачи ему одной из констант (odin, dva, tri  и т.д.). Результат, возвращаемый методом,
        /// присваивается свойству Text текстового поля txtOutput.
        /// </summary>

        private void btn1_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(Odin);
        }

        private void btn2_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(Dva);
        }

        private void btn3_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(Tri);
        }

        private void btn4_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(Chetire);
        }

        private void btn5_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(Pyat);
        }

        private void btn6_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(Shest);
        }

        private void btn7_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(Sem);
        }

        private void btn8_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(Vosem);
        }

        private void btn9_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(Devyat);
        }

        private void btn0_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(Nul);
        }
        
        private void btnChangesign_Click(object sender, System.EventArgs e)
		{            
            txtOutput.Text = mehanizmcalkulyatora.ZnakChisla();           
        }

        private void btnpoint_Click(object sender, System.EventArgs e)
		{            
            txtOutput.Text = mehanizmcalkulyatora.ZnakTochki();
        }
			/// <summary>
			/// Обработчики кнопок действия калькулятора передают 
			/// методу DeystvieCalculatora класса mehanizmcalkulyatora переменную перечисления Deystvie.
			/// </summary>
		
		private void btn_delenie_Click(object sender, System.EventArgs e)
		{
            txtOutput.Text = mehanizmcalkulyatora.DeystvieCalculatora (mehanizmcalkulyatora.Deystvie.Delenie);                        
        }

		private void btn_umnojenie_Click(object sender, System.EventArgs e)
		{
            txtOutput.Text = mehanizmcalkulyatora.DeystvieCalculatora (mehanizmcalkulyatora.Deystvie.Umnojenie);
		}

		private void btn_minus_Click(object sender, System.EventArgs e)
		{
            txtOutput.Text = mehanizmcalkulyatora.DeystvieCalculatora (mehanizmcalkulyatora.Deystvie.Vichitanie);
		}

		private void btn_plus_Click(object sender, System.EventArgs e)
		{
            txtOutput.Text = mehanizmcalkulyatora.DeystvieCalculatora (mehanizmcalkulyatora.Deystvie.Slojenie);
		}

        private void btn_stepen_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.DeystvieCalculatora (mehanizmcalkulyatora.Deystvie.VozvedenievStepen);
        }
        
        //Действия, не требующие ввода второго числа
        private void btn_koren_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.DeystvieNadChislom (mehanizmcalkulyatora.Deystvie2.KvadratniyKoren);            
        }

        private void btn_obrZnach_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.DeystvieNadChislom (mehanizmcalkulyatora.Deystvie2.ObratnoeZnachenie);           
        }

        private void btn_kvadrat_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.DeystvieNadChislom (mehanizmcalkulyatora.Deystvie2.KvadratChisla);            
        }

        private void btn_Factorial_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            //txtOutput.Text = mehanizmcalkulyatora.DeystvieNadChislom(mehanizmcalkulyatora.Deystvie2.Factorial);            
        }

        private void btn_KubKoren_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.DeystvieNadChislom(mehanizmcalkulyatora.Deystvie2.KubicheskiyKoren);
        }

        //Окончание вычислений
        private void btn_ravno_Click(object sender, System.EventArgs e)
	    {
		    txtOutput.Text = mehanizmcalkulyatora.ZnakRavno();
			//mehanizmcalkulyatora.Sbros();
		}

		private void btn_sbros_Click(object sender, System.EventArgs e)
		{
			mehanizmcalkulyatora.Sbros();
			txtOutput.Text = "0";
            textBox_Factorial.Text = "";
		}

        //Решение квадратного уравнения
        private void btn_KvUr_Click(object sender, EventArgs e)
        {
            KvadratnoeUravnenie kvadratnoeUravnenie = new KvadratnoeUravnenie();
            kvadratnoeUravnenie.ShowDialog();            
        }

        //Параллельный поток
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int n, i;
            n = Convert.ToInt32(txtOutput.Text);
            factorial = n;

            if (n >= 0)
            {
                for (i = 1; i < n; i++)
                    factorial *= i;

                znachenieFuctoriala = true;
            }
            else
                znachenieFuctoriala = false;
            

            System.Threading.Thread.Sleep(5*1000);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (znachenieFuctoriala)
                textBox_Factorial.Text = Convert.ToString(factorial);
            else
                textBox_Factorial.Text = "Действие невозможно!";
        }

        //Виды калькулятора:
        private void injenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (standartCalculator)
            {
                standartCalculator = false;

                standartToolStripMenuItem.Enabled = true;
                injenerToolStripMenuItem.Enabled = false;

                Text = "Калькулятор (инженерный)";
                //BackColor = Color.Blue;
                
                Width = Width + MovR;
                Height = Height + 2*MovR;
                txtOutput.Width = txtOutput.Width + MovR;
                textBox_Factorial.Width = textBox_Factorial.Width + MovR;

                btn_sbros.Location = new Point(btn_sbros.Location.X + MovR, btn_sbros.Location.Y + 2*MovR);
                btn_ravno.Location = new Point(btn_ravno.Location.X + MovR, btn_ravno.Location.Y + MovR);
                btn_sbros.Size = new Size(MovR, MovR);
                btn_ravno.Size = new Size(MovR, MovR);

                btn_KvUr.Location = new Point(btn_KvUr.Location.X + MovR, btn_KvUr.Location.Y);
                btn_KubKoren.Location = new Point(btn_KubKoren.Location.X + MovR, btn_KubKoren.Location.Y);

                btn_Factorial.Location = new Point(btn_Factorial.Location.X, btn_Factorial.Location.Y + 2 * MovR - 20);
                textBox_Factorial.Location = new Point(textBox_Factorial.Location.X, textBox_Factorial.Location.Y + 6 * MovR + 25);

                btn_koren.Visible = true;
                btn_stepen.Visible = true;
                btn_obrZnach.Visible = true;
                btn_kvadrat.Visible = true;
                btn_KvUr.Visible = true;
                btn_KubKoren.Visible = true;
                btn_Factorial.Visible = true;
                textBox_Factorial.Visible = true;
            }
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!standartCalculator)
            {
                standartCalculator = true;

                standartToolStripMenuItem.Enabled = false;
                injenerToolStripMenuItem.Enabled = true;

                Text = "Калькулятор (обычный)";
                //BackColor = Color.Green;

                Width = Width - MovR;
                Height = Height - 2 * MovR;
                txtOutput.Width = txtOutput.Width - MovR;
                textBox_Factorial.Width = textBox_Factorial.Width - MovR;
                //Size = new Size(Width, Height);
                btn_sbros.Location = new Point(btn_sbros.Location.X - MovR, btn_sbros.Location.Y - 2*MovR);
                btn_ravno.Location = new Point(btn_ravno.Location.X - MovR, btn_ravno.Location.Y - MovR);
                btn_sbros.Size = new Size(MovR, 2*MovR);
                btn_ravno.Size = new Size(MovR, 2*MovR);

                btn_KvUr.Location = new Point(btn_KvUr.Location.X - MovR, btn_KvUr.Location.Y);                
                btn_KubKoren.Location = new Point(btn_KubKoren.Location.X - MovR, btn_KubKoren.Location.Y);

                btn_Factorial.Location = new Point(btn_Factorial.Location.X, btn_Factorial.Location.Y - 2 * MovR + 20);
                textBox_Factorial.Location = new Point(textBox_Factorial.Location.X, textBox_Factorial.Location.Y - 6 * MovR - 25);

                btn_koren.Visible = false;
                btn_stepen.Visible = false;
                btn_obrZnach.Visible = false;
                btn_kvadrat.Visible = false;
                btn_KvUr.Visible = false;
                btn_KubKoren.Visible = false;
                btn_Factorial.Visible = false;
                textBox_Factorial.Visible = false;
            }
        }
    }

    class mehanizmcalkulyatora
	{
	/// <summary>
	///Создаем перечисление Deystvie, для определения одного из 5 действий калькулятора над двумя числами.
	/// </summary>
		public enum Deystvie:int
		{
			NeopredelDeystvie = 0,
			Slojenie = 1,
			Vichitanie = 2,
			Umnojenie = 3,
			Delenie = 4,
            VozvedenievStepen = 5
		}

        /// <summary>
        ///Создаем перечисление Deystvie2, для определения одного из 5 действий калькулятора над числом.
        /// </summary>
        public enum Deystvie2 : int
        {
            NeopredelDeystvie = 0,
            KvadratniyKoren = 1,    
            ObratnoeZnachenie = 2,
            KvadratChisla = 3,
            Factorial = 4,
            KubicheskiyKoren = 5
        }

    /// <summary>
    /// Объявляем и инициализируем переменную, 
    /// которая будет использоваться для смены знака при нажатии клавиши (+/-)
    /// </summary>

    //private static double peremennayaMinus = -1;

    /// <summary>
    /// Объвляем переменные, для работы калькулятора:
    /// resultatVichisleniy - переменная для хранения
    ///  промежуточного результата в механизме калькулятора
    ///  resultatOutput - переменная, значение которой будет сниматься с экрана и выводиться на него.
    ///  tekusheeDeystvieCalculatora - хранение одного из действий калькулятора.
    ///  pervoeChislo - переменная, в которую будет записываться число на экране
    ///   до нажатия на одну из кнопок действия.
    ///  vtoroeChislo - второе число на экране.  (не используется)
    ///  dobavlenieRazryada при добавлении следующего разряда эта переменная примет значение true; (не используется)
    ///  chislosTochkoy при добавлении десятичного разряда (знака точки) эта переменная примет значение true
    /// </summary>

        //private static double resultatVichisleniy = 0;
        private static string resultatOutput = "0";
		private static Deystvie tekusheeDeystvieCalculatora = Deystvie.NeopredelDeystvie;
        private static double pervoeChislo = 0;
		private static double vtoroeChislo;
		//private static bool dobavlenieRazryada;
		private static bool chislosTochkoy = false;
        private static bool chislosTochkoyvKonce = false;
        private static double znachenie = 0;
        private static bool vypolnenieDeystviya = false;
        private static bool result = false;
        private static bool start = true;

        /// <summary>
        /// В конструкторе класса mehanizmcalkulyatora инициализируем переменные 
        /// chislosTochkoy и dobavlenieRazryada - при запуске калькулятора на экране 
        /// нет ни разрядности, ни десятичной части.
        /// </summary>

        //public mehanizmcalkulyatora()
        //{
        //    chislosTochkoy = false;
        //    chislosTochkoyvKonce = false;
        //    dobavlenieRazryada = false;
        //}

        /// <summary>
        /// В этом методе переменная resultatOutput изменяется - при вводе числа ее значение перезаписывается.
        /// </summary>
        public static string chislonaEkrane (string najatayaKlavisha)
		{
            if ((znachenie == 0 && chislosTochkoy == false) || vypolnenieDeystviya || start)
            {                
                chislosTochkoy = false;
                resultatOutput = najatayaKlavisha;

                if (vypolnenieDeystviya)
                {              
                    vypolnenieDeystviya = false;
                    result = true;
                }                
            }
            else
                resultatOutput += najatayaKlavisha;

            start = false;
            chislosTochkoyvKonce = false;
            znachenie = Convert.ToDouble(resultatOutput);           

            return (resultatOutput);
        }

        /// <summary>
        /// Метод, в котором определяется peremenDeystviya - одно значение перечисления Deystvie,
        ///в зависимости от выбора  клавиши +, -, *, / или ^
        /// </summary>
        public static string DeystvieCalculatora(Deystvie peremenDeystviya)
        {               
            if (result)
            {                
                resultatOutput = ZnakRavno();
            }

            pervoeChislo = znachenie;
            tekusheeDeystvieCalculatora = peremenDeystviya;
            vypolnenieDeystviya = true;
            start = false;

            return resultatOutput;
        }

        /// <summary>
        /// При нажатии кнопки +/- число на экране - tekusheeChislo умножается на -1,
        ///  а затем результат снова присваивается переменной resultatOutput.
        /// </summary>

        public static string ZnakChisla()
        {            
            if (znachenie != 0)
            {
                znachenie *= -1;
                
                if (vypolnenieDeystviya)
                    pervoeChislo *= -1;

                if (znachenie < 0)
                    resultatOutput = "-" + resultatOutput;
                else
                    resultatOutput = resultatOutput.Substring(1);

                if (chislosTochkoyvKonce)                
                    resultatOutput += ",";                                   
            }
            
            return (resultatOutput);
        }

        /// <summary>
        /// При нажатии кнопки( , ) переменная resultatOutput приобретает дробную часть.
        /// </summary>


        public static string ZnakTochki()
        {                        
            if (start || vypolnenieDeystviya)
            {
                resultatOutput = "0,";
                znachenie = 0;
                chislosTochkoy = true;
                chislosTochkoyvKonce = true;

                if (vypolnenieDeystviya)
                {
                    vypolnenieDeystviya = false;
                    result = true;
                }               
            }
            else
                if (!chislosTochkoy)
                {
                    resultatOutput += ",";

                    chislosTochkoy = true;
                    chislosTochkoyvKonce = true;
                }         
           
            start = false;

            return (resultatOutput);
        }

        public static string DeystvieNadChislom (Deystvie2 Deystvie)
        {
            bool proverkaOshibok = false;
            int n = Convert.ToInt32 (znachenie);
            int i;

            switch (Deystvie)
            {
                case Deystvie2.NeopredelDeystvie:
                    proverkaOshibok = false;
                    break;
                
                case Deystvie2.KvadratniyKoren:
                    znachenie = Math.Sqrt(znachenie);
                    proverkaOshibok = true;
                    break;

                case Deystvie2.ObratnoeZnachenie:
                    if (znachenie != 0)
                    {
                        znachenie = 1 / znachenie;
                        proverkaOshibok = true;
                    }
                    else                    
                        resultatOutput = "На ноль делить нельзя!";                    
                    break;                  

                case Deystvie2.KvadratChisla:
                    znachenie *= znachenie;
                    proverkaOshibok = true;
                    break;

                case Deystvie2.Factorial:
                    if (n >= 0)
                    {
                        for (i = 1; i < n; i++)
                            znachenie *= i;
                        proverkaOshibok = true;
                    }
                    else
                        resultatOutput = "NaN";
                    break;

                case Deystvie2.KubicheskiyKoren:
                    znachenie = Math.Pow(znachenie, 1.0/3.0);                    
                    proverkaOshibok = true;
                    break;         

                default:
                    proverkaOshibok = false;
                    break;
            }

            chislosTochkoyvKonce = false;
            start = true;

            if (proverkaOshibok)
            {
                resultatOutput = Convert.ToString(znachenie);                           

                if (vypolnenieDeystviya)
                    pervoeChislo = znachenie;                
            }

            if (resultatOutput == "NaN")
            {
                Sbros();
                return ("Действие невозможно!");
            }
            else   
                if (resultatOutput == "На ноль делить нельзя!")
                {
                    Sbros();
                    return ("На ноль делить нельзя!");
                }
                else
                    return (resultatOutput);
        }

        /// <summary>
        /// При нажатии кнопки ZnakRavno обрабатываются значения 
        /// переменнных pervoeChislo и vtoroeChislo, результат присваивается переменной resultatVichisleniy 
        /// которая затем преобразуется в resultatOutput.
        /// </summary>
        public static string ZnakRavno ()
		{
			bool proverkaOshibok = false;
            //int i;

			if (result)
			{
                vtoroeChislo = znachenie;               
                result = false;
                start = true;

                switch (tekusheeDeystvieCalculatora)
				{
					case Deystvie.NeopredelDeystvie:
						proverkaOshibok = false;
						break;

					case Deystvie.Slojenie:
                        znachenie = pervoeChislo + vtoroeChislo;
                        proverkaOshibok = true;
						break;

					case Deystvie.Vichitanie:
						znachenie = pervoeChislo - vtoroeChislo;
						proverkaOshibok = true;
						break;

					case Deystvie.Umnojenie:
                        znachenie = pervoeChislo * vtoroeChislo;
						proverkaOshibok = true;
						break;

					case Deystvie.Delenie:
                        if (vtoroeChislo != 0)
                        {
                            znachenie = pervoeChislo / vtoroeChislo;
                            proverkaOshibok = true;
                        }
                        else                        
                            resultatOutput = "На ноль делить нельзя!";                        
                        break;

                    case Deystvie.VozvedenievStepen:                       
                           znachenie = Math.Pow(pervoeChislo, vtoroeChislo);
                           proverkaOshibok = true;   
                        break;

                    default:
						proverkaOshibok = false;
						break;
				}

				if (proverkaOshibok)
					resultatOutput = System.Convert.ToString (znachenie);

                if (resultatOutput == "NaN")
                {
                    Sbros();
                    return ("Действие невозможно!");
                }
                else
                    if (resultatOutput == "На ноль делить нельзя!")
                    {
                        Sbros();
                        return ("На ноль делить нельзя!");
                    }
                    else
                        return (resultatOutput);
            }

            return (resultatOutput);
		}

	/// <summary>
	/// При нажатии кнопки С (сброс) значения переменных обнуляются.
	/// </summary>
		public static void Sbros ()
		{
			//resultatVichisleniy = 0;
			pervoeChislo = 0;
            vtoroeChislo = 0;
            znachenie = 0;
			resultatOutput = "0";
			tekusheeDeystvieCalculatora = Deystvie.NeopredelDeystvie;
			chislosTochkoy = false;
            chislosTochkoyvKonce = false;
            vypolnenieDeystviya = false;
            result = false;
            start = true;
            //dobavlenieRazryada = false;                   
        }
	}
}
