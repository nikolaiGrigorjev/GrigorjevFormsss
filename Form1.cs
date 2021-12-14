using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrigorjevFormsss
{
    public partial class Form1 : Form
    {
        TreeView tree;
        Button btn;
        Label lbl;
        PictureBox pctBox;
        CheckBox chkBox, chkBox2, chkBox3,chkBox4;
        ListBox lstBox;
        RadioButton rdBut, rdBut2 , rdBut3, rdBut4;

        public int count = 1;
        public int n = 0;
        public bool t = false;
        public int click = 0;
        public Form1()
        {
            this.Height = 900;
            this.Width = 900;
            this.Text = "NBA Forms";
            Image img = new Bitmap(@"C:\Users\opilane\source\repos\GrigorjevFORM\GrigorjevFormsss\artworks-ukQRhAYBpFcvtoAF-sYbxfw-t500x500.jpg");
            this.BackgroundImage = img;
            tree = new TreeView();
            tree.Dock = DockStyle.Left;
            tree.AfterSelect += Tree_AfterSelect;
            TreeNode tn = new TreeNode("Elemendid");
            tn.Nodes.Add(new TreeNode("Nupp"));
            tn.Nodes.Add(new TreeNode("Silt-label"));
            tn.Nodes.Add(new TreeNode("CheckBox"));
            tn.Nodes.Add(new TreeNode("Radiobutton"));
            tn.Nodes.Add(new TreeNode("TextBox"));
            tn.Nodes.Add(new TreeNode("PictureBox"));
            tn.Nodes.Add(new TreeNode("ListBox"));
            tn.Nodes.Add(new TreeNode("Kaart"));
            tn.Nodes.Add(new TreeNode("MessageBox"));
            tn.Nodes.Add(new TreeNode("DataGridView"));
            tn.Nodes.Add(new TreeNode("MainMenu"));





            //nupp
            btn = new Button();
            btn.Text = "Если хочешь выйти нажми на кнопку";
            btn.Location = new Point(100, 50);
            btn.Height = 150;
            btn.Width = 200;
            btn.Click += Btn_Click;
            btn.MouseHover += Btn_MouseHover;
            btn.MouseLeave += Btn_MouseLeave;
            //pealkiri
            lbl = new Label();
            lbl.Text = "Elementide loomine c# abi";
            lbl.Size = new Size(600, 30);
            lbl.Location = new Point(150, 0);
            lbl.MouseHover += Lbl_MouseHover;
            lbl.MouseLeave += Lbl_MouseLeave;
            //picturebox

            pctBox = new PictureBox();
            pctBox.Size = new Size(300, 170);
            pctBox.Location = new Point(100, 400);
            pctBox.DoubleClick += PctBox_DoubleClick;
            pctBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pctBox.Image = Image.FromFile(@"C:\Users\opilane\source\repos\GrigorjevFORM\GrigorjevFormsss\el-primo-brawl-stars-guide.jpg");


            //RadioButton
            






            //checkBox
            chkBox = new CheckBox();
            chkBox2 = new CheckBox();
            chkBox3 = new CheckBox();
            chkBox4 = new CheckBox();

            chkBox.CheckedChanged += ChkBox_CheckedChanged;

            chkBox2.Left = 130;
            chkBox2.Top = 200;
            chkBox2.Width = 150;
            chkBox2.Height = 50;

            
            chkBox2.Location = new Point(130, 300);

            chkBox.Left = 130;
            chkBox.Top = 200;
            chkBox.Width = 150;
            chkBox.Height = 50;

            chkBox3.Left = 100;
            chkBox3.Top = 250;
            chkBox3.Width = 300;
            chkBox3.Height = 250;

            chkBox4.Left = 100;
            chkBox4.Top = 250;
            chkBox4.Width = 400;
            chkBox4.Height = 450;

           
            


            // Set background and foreground  
            chkBox.BackColor = Color.Orange;
            chkBox.ForeColor = Color.Black;
            chkBox2.BackColor = Color.Purple;
            chkBox2.ForeColor = Color.Black;
            chkBox.Text = "Hello";
            chkBox2.Text = "Tere";
            chkBox2.ForeColor = Color.Red;
            chkBox.Font = new Font("Georgia", 12);
            chkBox3.ForeColor = Color.Green;
            chkBox4.ForeColor = Color.LightBlue;
            chkBox3.Text = "..";
            chkBox4.Text = "...";






            tree.Nodes.Add(tn);
            this.Controls.Add(tree);

            
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            btn.BackColor = Color.Transparent;
        }

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            btn.BackColor = Color.Green;
        }

        private void PctBox_DoubleClick(object sender, EventArgs e)
        {
            string[] images = { "antonov1.jpg", "grib.jpg", "tommy.jpg" };
            string fail = images[click];
            pctBox.Image = Image.FromFile(@"..\..\Images\" + fail);
            click++;
            if (click == 3) { click = 0; }
        }

        

        private void ChkBox_CheckedChanged(object sender, EventArgs e)
        {

            if (t)
            {
                this.Size = new Size(1000, 1000);
                chkBox.Text = "Teeme väiksem";
                t = false;
            }
            else
            {
                this.Size = new Size(700, 500);
                chkBox2.Text = "Hello";
                t = true;
            }
            
        }

        private void Lbl_MouseLeave(object sender, EventArgs e)
        {
            lbl.BackColor = Color.Transparent;
        }

        private void Lbl_MouseHover(object sender, EventArgs e)
        {
            lbl.BackColor = Color.FromArgb(200, 10, 20);
        }



        private void Btn_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text=="Nupp")
            {
                this.Controls.Add(btn);
            }
            else if(e.Node.Text=="Silt-label")
            {
                this.Controls.Add(lbl);
            }
            else if (e.Node.Text == "PictureBox")
            {
                this.Controls.Add(pctBox);
            }
            else if (e.Node.Text == "CheckBox")
            {
                this.Controls.Add(chkBox);
                this.Controls.Add(chkBox2);
            }
            else if (e.Node.Text == "Kaart")
            {
                TabControl tabC = new TabControl();
                tabC.Location = new Point(450, 50);
                tabC.Size = new Size(400, 200);
                
                TabPage tabP1 = new TabPage("Anime");
                WebBrowser wb = new WebBrowser();
                wb.Url = new Uri("https://jut.su/");
                tabP1.Controls.Add(wb);

                TabPage tabP2 = new TabPage("Picture");
                WebBrowser wb2 = new WebBrowser();
                wb2.Url = new Uri("https://www.tthk.ee/");
                tabP2.Controls.Add(wb2);



                
                tabC.Controls.Add(tabP1);
                tabC.Controls.Add(tabP2);
                
                this.Controls.Add(tabC);
            }
            else if (e.Node.Text == "MainMenu")
            {
                MainMenu menu = new MainMenu();
                MenuItem menuFile = new MenuItem("File");
                menuFile.MenuItems.Add("Exit", new EventHandler(menuFile_Exit_Select));
                menu.MenuItems.Add(menuFile);
                this.Menu = menu;

                
            }
            else if (e.Node.Text == "ListBox")
            {
                lstBox = new ListBox();
                lstBox.Items.Add("Rohaline");
                lstBox.Items.Add("Kollane");
                lstBox.Items.Add("Sinine");

                lstBox.Items.Add("Punane");
                lstBox.Location = new Point(400,250);
                lstBox.SelectedIndexChanged += new EventHandler(lstBox_SelectedIndexChanged);
                this.Controls.Add(lstBox);
                
            }
            else if (e.Node.Text == "DataGridView")
            {
                DataSet ds = new DataSet("XML fail.Menüü");
                ds.ReadXml(@"..\..\Images\menu.xml");
                DataGridView dg = new DataGridView();
                dg.Width = 300;
                dg.Height = 150;
                dg.Location = new Point(400, 344);
                dg.AutoGenerateColumns = true;
                dg.DataSource = ds;
                dg.DataMember = "book";
                
                this.Controls.Add(dg);
            }

            else if (e.Node.Text == "Radiobutton")
            {
                rdBut = new RadioButton();
                rdBut.Text = "Red";
                rdBut.Location = new Point(570, 100);

                rdBut2 = new RadioButton();
                rdBut2.Location = new Point(570, 200);
                rdBut2.Text = "Yellow";
               


                rdBut3 = new RadioButton();
                rdBut3.Text = "Delete Fon";
                rdBut3.Location = new Point(570, 300);

                rdBut4 = new RadioButton();
                rdBut4.Text = "Surprize";
                rdBut4.Location = new Point(570, 400);

                this.Controls.Add(rdBut);
                this.Controls.Add(rdBut2);
                this.Controls.Add(rdBut3);
                this.Controls.Add(rdBut4);

                rdBut.CheckedChanged += new EventHandler(rdBut_Checked);
                rdBut2.CheckedChanged += new EventHandler(rdBut_Checked);
                rdBut3.CheckedChanged += new EventHandler(rdBut_Checked);
                rdBut4.CheckedChanged += new EventHandler(rdBut_Checked);



            }
            else if (e.Node.Text == "MessageBox")
            {
                MessageBox.Show("MessageBox", "TERE TERE!!!");
                var answer = MessageBox.Show("Tahad InputBox näha?", "Aken koos nupudega", MessageBoxButtons.YesNo);

                if (answer == DialogResult.Yes)
                {
                    string text = Interaction.InputBox("Sisesta siia mingi teksti", "InputBox", "Mingi teksti");
                    if (MessageBox.Show("Kas tahad tekst saada Tekskastisse?", "Teksti salvesyamine", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        lbl.Text = text;
                        Controls.Add(lbl);
                    }

                    else
                    {
                        MessageBox.Show("Miks....");
                    }


                }
                else
                {
                    MessageBox.Show("Mine ära....");
                }





                
            }   
        }

        private void menuFile_Exit_Select(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void rdBut_Checked(object sender, EventArgs e)
        {
            if (rdBut.Checked)
            {
                this.BackColor = Color.Red;
                rdBut2.ForeColor = Color.Yellow;
                rdBut.ForeColor = Color.Yellow;
            }
            else if (rdBut2.Checked)
            {
                this.BackColor = Color.Yellow;
                rdBut2.ForeColor = Color.Red;
                rdBut.ForeColor = Color.Red;
            }
            else if (rdBut3.Checked)
            {
             
            this.BackColor = Color.White;
                this.BackgroundImage = null;

            }
            else if (rdBut4.Checked == true)
            {
                MessageBox.Show("Surprize)");
                return;

            }







        }
    }
}
