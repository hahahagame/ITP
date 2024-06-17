using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.X509;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace ITP4915M
{

    public partial class Dashboard_planner : Form
    {
        string connectionString = DatabaseConfig.ConnectionString;

        string searchDealerQuery = "SELECT * FROM dealer";
        public static Dashboard_planner instance;
        private readonly Staff _staffMember;


        //private SearchDearler frm2;
        public Dashboard_planner(Staff staff)
        {
            InitializeComponent();
            ResizePanel();
     
            instance = this;
            this._staffMember = staff;
            namelbl.Text = "Name : " + staff.Name;
            deptlbl.Text = "Department : " + staff.Department;



        }

        private void ResizePanel()
        {
            // Get the current screen resolution
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            // Determine the panel size based on the screen resolution
            int panelWidth, panelHeight;
            if (screenWidth >= 3840 && screenHeight >= 2160) // 4K resolution
            {
                panelWidth = (int)(panel1.Width * 1.0);
                panelHeight = (int)(panel1.Height * 1.0);
            }
            else if (screenWidth >= 2560 && screenHeight >= 1440) // 2K resolution
            {
                panelWidth = (int)(panel1.Width * 0.6);
                panelHeight = (int)(panel1.Height * 0.6);
            }
            else // 1080p or lower resolution
            {
                panelWidth = (int)(panel1.Width * 0.4);
                panelHeight = (int)(panel1.Height * 0.4);
            }

            // Resize the panel
            panel1.Size = new Size(panelWidth, panelHeight);
        }
        private void button1_Click(object sender, EventArgs e)
        {
  

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreOrdBtn_Click(object sender, EventArgs e)
        {
  




        }

        private void SercOrdBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void VieOrdBtn_Click(object sender, EventArgs e)
        {

        }

        private void SearchDearlerBtn_Click(object sender, EventArgs e)
        {
            Form frm2 = new SearchDearler();
            frm2.ShowDialog();

            //try
            //{
            //    frm2 = new SearchDearler(this);
            //    frm2.MdiParent = this;
            //    frm2.Show();
            //    frm2.Visible = true;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error displaying SearchDearler form: {ex.Message}");
            //    // Log the exception or perform other error handling
            //}

        }


        private void searchItemBtn_Click(object sender, EventArgs e)
        {
            // MySqlConnection conn = new MySqlConnection(connectionString);
            Form frm = new Searchitem();
            frm.ShowDialog();



        }

        private void issueOrderBtn_Click(object sender, EventArgs e)
        {


        }

        private void clearItemBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void clearorderBtn_Click(object sender, EventArgs e)
        {
           
        }


        private void Orderlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }




        private void delOrdBtn_Click(object sender, EventArgs e)
        {

          
        }

        private void updOrdBtn_Click(object sender, EventArgs e)
        {

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new DataMain_Form();
            frm.ShowDialog();
        }

        private void inventoryControlBtn_Click(object sender, EventArgs e)
        {
            Form frm = new UpdateDangerLevel();
            frm.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void inventoryControlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkStocklevelBtn_Click(object sender, EventArgs e)
        {
            Form frm = new CheckStock();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm = new CreateUser();
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}





