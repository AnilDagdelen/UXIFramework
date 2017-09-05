using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muhasebex
{
    public class UXMainClass
    { 
        public void UXInit(Form F)
        {
            foreach (Control item in F.Controls)
            {
                item.BackColor = System.Drawing.Color.Green;
            }

            F.BackColor = Color.BurlyWood;
            foreach (Control item in F.Controls)
            {
                item.BackColor = Color.BurlyWood;
            }
            TabControl TC = (TabControl)F.Controls[2];
            TabPage tabPage3 = new System.Windows.Forms.TabPage(); 


            Button button5 = new System.Windows.Forms.Button();
            Button button6 = new System.Windows.Forms.Button();
            Button button7 = new System.Windows.Forms.Button();
            Button button8 = new System.Windows.Forms.Button();
            Button btnFotografEkle = new System.Windows.Forms.Button();
            Button btnEkle = new System.Windows.Forms.Button();
            button5.Location = new System.Drawing.Point(170, 363); 
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(46, 34);
            button5.TabIndex = 50;
            button5.UseVisualStyleBackColor = true;

            button6.Location = new System.Drawing.Point(118, 363); 
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(46, 34);
            button6.TabIndex = 51;
            button6.UseVisualStyleBackColor = true;



            button7.Location = new System.Drawing.Point(66, 363); 
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(46, 34);
            button7.TabIndex = 52;
            button7.UseVisualStyleBackColor = true;



            button8.Location = new System.Drawing.Point(14, 363); 
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(46, 34);
            button8.TabIndex = 53;
            button8.UseVisualStyleBackColor = true;



            btnFotografEkle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            btnFotografEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnFotografEkle.Location = new System.Drawing.Point(371, 363);
            btnFotografEkle.Name = "btnFotografEkle";
            btnFotografEkle.Size = new System.Drawing.Size(160, 34);
            btnFotografEkle.TabIndex = 22;
            btnFotografEkle.Text = "Fotoğraf Ekle";
            btnFotografEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnFotografEkle.UseVisualStyleBackColor = true; 



            btnEkle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnEkle.Location = new System.Drawing.Point(537, 363);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new System.Drawing.Size(130, 34);
            btnEkle.TabIndex = 21;
            btnEkle.Text = "Ekle";
            btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnEkle.UseVisualStyleBackColor = true;
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(button6);
            tabPage3.Controls.Add(button7);
            tabPage3.Controls.Add(button8);
            tabPage3.Controls.Add(btnFotografEkle);
            tabPage3.Controls.Add(btnEkle);
            tabPage3.Location = new System.Drawing.Point(4, 25);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(675, 403);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Fotoğraflar";
            TabControl tabControl1 = (TabControl)F.Controls[2];
            tabControl1.TabPages.Add(tabPage3);
            foreach (TabPage tp in TC.TabPages)
            {
                tp.BackColor = Color.Coral;
                foreach (Control c in tp.Controls)
                {
                    tp.BackColor = Color.Coral;
                }
            }
            foreach (Control item in TC.TabPages[0].Controls)
            {
                item.BackColor = Color.DarkRed;
                item.Font = new Font(FontFamily.GenericMonospace, 15);
            }
            GroupBox gb = (GroupBox)F.Controls[2].Controls[1].Controls[4];
            gb.Dock = DockStyle.Right;
            
            foreach (CheckBox item in F.Controls[2].Controls[1].Controls[4].Controls)
            {
                item.CheckAlign = ContentAlignment.MiddleRight;
                item.TextAlign = ContentAlignment.MiddleRight;
            }
        }
    }
}
