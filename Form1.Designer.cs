namespace InfinitePrecisionCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtDisplay;

        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;

        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;

        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();

            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();

            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();

            this.btnDot = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            this.btnEqual = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // txtDisplay

            this.txtDisplay.Font =
                new System.Drawing.Font("Segoe UI", 18F);

            this.txtDisplay.Location =
                new System.Drawing.Point(12, 12);

            this.txtDisplay.Multiline = true;

            this.txtDisplay.Size =
                new System.Drawing.Size(350, 50);

            this.txtDisplay.TextAlign =
                System.Windows.Forms.HorizontalAlignment.Right;

            // Розміри кнопок

            int w = 80;
            int h = 60;

            // Ряд 1

            CreateButton(btn7, "7", 12, 80, w, h);
            CreateButton(btn8, "8", 102, 80, w, h);
            CreateButton(btn9, "9", 192, 80, w, h);
            CreateButton(btnDivide, "/", 282, 80, w, h);

            // Ряд 2

            CreateButton(btn4, "4", 12, 150, w, h);
            CreateButton(btn5, "5", 102, 150, w, h);
            CreateButton(btn6, "6", 192, 150, w, h);
            CreateButton(btnMultiply, "*", 282, 150, w, h);

            // Ряд 3

            CreateButton(btn1, "1", 12, 220, w, h);
            CreateButton(btn2, "2", 102, 220, w, h);
            CreateButton(btn3, "3", 192, 220, w, h);
            CreateButton(btnMinus, "-", 282, 220, w, h);

            // Ряд 4

            CreateButton(btn0, "0", 12, 290, w, h);
            CreateButton(btnDot, ".", 102, 290, w, h);
            CreateButton(btnEqual, "=", 192, 290, w, h);
            CreateButton(btnPlus, "+", 282, 290, w, h);

            // Ряд 5

            CreateButton(btnOpen, "(", 12, 360, w, h);
            CreateButton(btnClose, ")", 102, 360, w, h);
            CreateButton(btnClear, "C", 192, 360, w, h);
            CreateButton(btnDelete, "←", 282, 360, w, h);

            // Події цифр

            btn0.Click += NumberClick;
            btn1.Click += NumberClick;
            btn2.Click += NumberClick;
            btn3.Click += NumberClick;
            btn4.Click += NumberClick;
            btn5.Click += NumberClick;
            btn6.Click += NumberClick;
            btn7.Click += NumberClick;
            btn8.Click += NumberClick;
            btn9.Click += NumberClick;

            // Події операторів

            btnPlus.Click += OperatorClick;
            btnMinus.Click += OperatorClick;
            btnMultiply.Click += OperatorClick;
            btnDivide.Click += OperatorClick;
            btnDot.Click += OperatorClick;
            btnOpen.Click += OperatorClick;
            btnClose.Click += OperatorClick;

            // Інші кнопки

            btnEqual.Click += btnEqual_Click;
            btnClear.Click += btnClear_Click;
            btnDelete.Click += btnDelete_Click;

            // Form

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(375, 440);

            this.Controls.Add(this.txtDisplay);

            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);

            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);

            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnClose);

            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);

            this.Name = "Form1";

            this.Text = "Калькулятор";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void CreateButton(
            System.Windows.Forms.Button btn,
            string text,
            int x,
            int y,
            int w,
            int h)
        {
            btn.Text = text;

            btn.Font =
                new System.Drawing.Font("Segoe UI", 14F);

            btn.Location =
                new System.Drawing.Point(x, y);

            btn.Size =
                new System.Drawing.Size(w, h);
        }
    }
}
