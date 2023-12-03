using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoshaverAmlak.Models;

namespace MoshaverAmlak
{
    public partial class Main : Form
    {
        private readonly ApplicationDb db;
        public Main()
        {
            InitializeComponent();
            db = new ApplicationDb();
            db.Database.EnsureCreated();
            PopulateDataGridView();
        }
        private void bunifuImageButton1_MouseEnter(object sender, EventArgs e)
        {
            //Change BackColor Exit Button on Mouse Enter
            BtnMainExit.BackColor = Color.Red;
        }

        private void BtnMainExit_MouseLeave(object sender, EventArgs e)
        {
            //Change BackColor Exit Button on Mouse Leave
            BtnMainExit.BackColor = Color.DodgerBlue;
        }

        private void BtnMainMinimize_MouseEnter(object sender, EventArgs e)
        {
            //Change BackColor Minimize Button on Mouse Enter
            BtnMainMinimize.BackColor = Color.Blue;
        }

        private void BtnMainMinimize_MouseLeave(object sender, EventArgs e)
        {
            //Change BackColor Minimize Button on Mouse Leave
            BtnMainMinimize.BackColor = Color.DodgerBlue;

        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {


            //With This Method Take Date / Time From Local PC And Convert to Persian Calander
            DateTime today = DateTime.Now;
            System.Globalization.PersianCalendar PersianCalendar = new System.Globalization.PersianCalendar();
            LableTimeAndDate.Text = PersianCalendar.GetYear(today).ToString("0000/") + PersianCalendar.GetMonth(today).ToString("00/") + PersianCalendar.GetDayOfMonth(today).ToString("00 | ") + PersianCalendar.GetHour(today).ToString("00:") + PersianCalendar.GetMinute(today).ToString("00:") + PersianCalendar.GetSecond(today).ToString("00");
            //Frist Check the Buttons In Menu Are Active Or Not -Then Fill Dock And Visible Panel
            if (BtnNewProperty.Active == true)
            {
                NewPropertyPanel.Dock = DockStyle.Fill;
                NewPropertyPanel.Visible = true;


            }
            else if (BtnNewProperty.Active == false)
            {
                NewPropertyPanel.Dock = DockStyle.None;
                NewPropertyPanel.Visible = false;
            }
            //----------------------------------------------

            if (BtnContractRegistration.Active == true)
            {
                ContractRegistrationPanel.Dock = DockStyle.Fill;
                ContractRegistrationPanel.Visible = true;
            }
            else if (BtnContractRegistration.Active == false)
            {
                ContractRegistrationPanel.Dock = DockStyle.None;
                ContractRegistrationPanel.Visible = false;
            }
            //--------------------------------------------------
            if (BtnSoldedProperty.Active == true)
            {
                SoldedPropertyPanel.Dock = DockStyle.Fill;
                SoldedPropertyPanel.Visible = true;
            }
            else if (BtnSoldedProperty.Active == false)
            {
                SoldedPropertyPanel.Dock = DockStyle.None;
                SoldedPropertyPanel.Visible = false;
            }
            //--------------------------------------------------
            if (BtnSettings.Active == true)
            {
                SettingsPanel.Dock = DockStyle.Fill;
                SettingsPanel.Visible = true;
            }
            else if (BtnSettings.Active == false)
            {
                SettingsPanel.Dock = DockStyle.None;
                SettingsPanel.Visible = false;
            }
            //--------------------------------------------------
            if (BtnSearchMenu.Active == true)
            {
                SearchPanel.Dock = DockStyle.Fill;
                SearchPanel.Visible = true;
            }
            else if (BtnSearchMenu.Active == false)
            {
                SearchPanel.Dock = DockStyle.None;
                SearchPanel.Visible = false;
            }
            //--------------------------------------------------
            if (BtnHelp.Active == true)
            {
                HelpPanel.Dock = DockStyle.Fill;
                HelpPanel.Visible = true;
            }
            else if (BtnHelp.Active == false)
            {
                HelpPanel.Dock = DockStyle.None;
                HelpPanel.Visible = false;
            }
        }

        private void BtnMainExit_Click(object sender, EventArgs e)
        {
            //On Click On Exit Button The Application Was Exit Thread.
            System.Windows.Forms.Application.ExitThread();
        }

        private void BtnMainMinimize_Click(object sender, EventArgs e)
        {
            //Minimize The Appliacation Window
            this.WindowState = FormWindowState.Minimized;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Load Data GridViews...
            PopulateDataGridView();
        }

        private void BtnCancelProperty_Click(object sender, EventArgs e)
        {
            //Clear All input Box(TextBoxs)
            FormClear();
        }
        void FormClear()
        {
            TextBoxSellerName.Text = TextBoxSellerMobile.Text = TextBoxAreaMeter.Text = TextBoxFloorNumber.Text = TextBoxPrice.Text = TextBoxAddress.Text = TextBoxDescription.Text = Slectedid.Text = "";
        }
        void FormClear2()
        {
            ContractPropertyID.Text = TextBoxContractSeller.Text = TextBoxContractArea.Text = TextBoxContractFloor.Text = TextBoxContractPrice.Text = TextBoxContractSellerMobile.Text = TextBoxContractAddress.Text = TextBoxContractDescription.Text = TextBoxContractBuyer.Text = TextBoxContractBuyerMobile.Text = TextBoxContractSearchID.Text = "";
        }

        private void BtnSaveProperty_Click(object sender, EventArgs e)
        {
            //Save Property into DataBase


            try
            {

                int type = 1;
                if (ApartmentRadioButton.Checked == true)
                {
                    type = 1;
                }
                else if (PrivateHouseRadioButton.Checked == true)
                {
                    type = 2;
                }
                else if (PrivateLandRadioButton.Checked == true)
                {
                    type = 3;
                }
                db.Properties.Add(new Property { Seller = TextBoxSellerName.Text.Trim(), SellerMobile = TextBoxSellerMobile.Text.Trim(), Area = TextBoxAreaMeter.Text.Trim(), Floor = TextBoxFloorNumber.Text.Trim(), Price = TextBoxPrice.Text.Trim(), Address = TextBoxAddress.Text.Trim(), Description = TextBoxDescription.Text.Trim(), PropertyType = type });
                db.SaveChanges();

                FormClear();
                PopulateDataGridView();
            }
            catch (Exception ex)
            {
                // Throw Exception 
                MessageBox.Show(ex.Message, "{0}Exception caught.");
            }





        }
        void PopulateDataGridView()
        {
            PropertyDataGridView.DataSource = db.Properties.ToList();
            SoldedDataGridView.DataSource = db.SoldedProperties.ToList();
            DataGridViewSearchProperty.DataSource = db.Properties.ToList();
        }

        private void BtnSearchProperty_Click(object sender, EventArgs e)
        {

        }

        private void PropertyDetailsGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void PropertyDataGridView_DoubleClick(object sender, EventArgs e)
        {

        }

        private void PropertyDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0)
                {
                    //gets a collection that contains all the rows
                    //DataGridViewRow row = this.PropertyDataGridView.Rows[e.RowIndex];
                    var id = PropertyDataGridView.Rows[e.RowIndex].Cells[0].Value;
                    var property = db.Properties.Find(id);
                    Slectedid.Text = property.Id.ToString();
                    TextBoxSellerName.Text = property.Seller;
                    TextBoxAreaMeter.Text = property.Area;
                    TextBoxFloorNumber.Text = property.Floor;
                    TextBoxPrice.Text = property.Price;
                    TextBoxSellerMobile.Text = property.SellerMobile;
                    TextBoxAddress.Text = property.Address;
                    TextBoxDescription.Text = property.Description;
                    int type = property.PropertyType;
                    if (type == 1)
                    {
                        ApartmentRadioButton.Checked = true;
                    }
                    else if (type == 2)
                    {
                        PrivateHouseRadioButton.Checked = true;
                    }
                    else if (type == 3)
                    {
                        PrivateLandRadioButton.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Moshaver Amlak");


            }
        }

        private void BtnDeleteProperty_Click(object sender, EventArgs e)
        {
            try
            {
                if (Slectedid.Text == "")
                {
                    MessageBox.Show("Property not Selected.");
                }
                else
                {

                    int id = int.Parse(Slectedid.Text);
                    var property = db.Properties.Where(p => p.Id == id);
                    db.Properties.RemoveRange(property);
                    db.SaveChanges();
                    PopulateDataGridView();
                    FormClear();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "{0}Exception caught.");
            }


        }

        private void BtnUpdateProperty_Click(object sender, EventArgs e)
        {
            try
            {
                if (Slectedid.Text == "")
                {
                    MessageBox.Show("Property not Selected.");
                }
                else
                {
                    int type = 1;
                    if (ApartmentRadioButton.Checked == true)
                    {
                        type = 1;
                    }
                    else if (PrivateHouseRadioButton.Checked == true)
                    {
                        type = 2;
                    }
                    else if (PrivateLandRadioButton.Checked == true)
                    {
                        type = 3;
                    }
                    var id = PropertyDataGridView.CurrentRow.Cells[0].Value;
                    var property = db.Properties.Find(id);
                    property.Seller = TextBoxSellerName.Text;
                    property.Area = TextBoxAreaMeter.Text;
                    property.Floor = TextBoxFloorNumber.Text;
                    property.Price = TextBoxPrice.Text;
                    property.SellerMobile = TextBoxSellerMobile.Text;
                    property.Address = TextBoxAddress.Text;
                    property.Description = TextBoxDescription.Text;
                    property.PropertyType = type;
                    db.SaveChanges();
                    FormClear();
                    PopulateDataGridView();


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Moshaver Amlak");
            }

        }

        private void BtnContractSearchID_Click(object sender, EventArgs e)
        {
            try
            {
                var property = db.Properties.Find(long.Parse(TextBoxContractSearchID.Text));
                ContractPropertyID.Text = property.Id.ToString();
                TextBoxContractSeller.Text = property.Seller;
                TextBoxContractArea.Text = property.Area;
                TextBoxContractFloor.Text = property.Floor;
                TextBoxContractPrice.Text = property.Price;
                TextBoxContractSellerMobile.Text = property.SellerMobile;
                TextBoxContractAddress.Text = property.Address;
                TextBoxContractDescription.Text = property.Description;
                int type = property.PropertyType;
                if (type == 1)
                {
                    ContractApartmentRadioButton.Checked = true;
                }
                else if (type == 2)
                {
                    ContractPrivateHouseRadioButton.Checked = true;
                }
                else if (type == 3)
                {
                    ContractPrivateLandRadioButton.Checked = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Moshaver Amlak");
            }

        }

        private void BtnContractProceed_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxContractBuyer.Text == "")
                {
                    MessageBox.Show("Enter Buyer Name");
                }
                else if (TextBoxContractBuyerMobile.Text == "")
                {
                    MessageBox.Show("Enter Buyer Mobile Number");
                }
                else
                {
                    int type = 1;
                    if (ContractApartmentRadioButton.Checked == true)
                    {
                        type = 1;
                    }
                    else if (ContractPrivateHouseRadioButton.Checked == true)
                    {
                        type = 2;
                    }
                    else if (ContractPrivateLandRadioButton.Checked == true)
                    {
                        type = 3;
                    }

                    db.SoldedProperties.Add(new SoldedProperty
                    {
                        Seller = TextBoxContractSeller.Text.Trim(),
                        Buyer = TextBoxContractBuyer.Text.Trim(),
                        SellerMobile = TextBoxContractSellerMobile.Text.Trim(),
                        BuyerMobile = TextBoxContractBuyerMobile.Text.Trim(),
                        Area = TextBoxContractArea.Text.Trim(),
                        Floor = TextBoxContractFloor.Text.Trim(),
                        Price = TextBoxContractPrice.Text.Trim(),
                        Address = TextBoxContractAddress.Text.Trim(),
                        Description = TextBoxContractDescription.Text.Trim(),
                        PropertyType = type
                    });

                    int id = int.Parse(ContractPropertyID.Text);
                    var property = db.Properties.Where(p => p.Id == id);
                    db.Properties.RemoveRange(property);

                    db.SaveChanges();
                    PopulateDataGridView();
                    MessageBox.Show("Contract Registerd", "Moshaver Amlak");
                    FormClear2();





                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Moshaver Amlak");
            }


        }

        private void BtnSyncSoldedDataGridView_Click(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void SoldedDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var Id = SoldedDataGridView.Rows[e.RowIndex].Cells[0].Value;
                var SoldedProperty = db.SoldedProperties.Find(Id);
                SoldedId.Text = SoldedProperty.Id.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Moshaver Amlak");
            }


        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            int id = int.Parse(SoldedId.Text);
            var SoldedProperty = db.SoldedProperties.Where(p => p.Id == id);
            db.SoldedProperties.RemoveRange(SoldedProperty);
            db.SaveChanges();
            SoldedId.Text = "";
            PopulateDataGridView();
        }



        private void FarsiCheckBox_Click(object sender, EventArgs e)
        {
            if (FarsiCheckBox.Checked==true)
            {
                bunifuCheckbox2.Checked = false;
            }
            BtnNewProperty.Text = "       لیست املاک";
            BtnContractRegistration.Text = "       ثبت قرار داد";
            BtnSoldedProperty.Text = "       املاک فروخته شده";
            BtnSearchMenu.Text = "       جستجو";
            BtnHelp.Text = "       راهنما";
            BtnSettings.Text = "       تنظیمات";
            BtnAbout.Text = "       درباره ما";
            label2.Text = "نام فروشنده";
            label3.Text = "متراژ";
            label4.Text = "طبقه";
            label5.Text = "قیمت";
            label6.Text = "موبایل فروشنده";
            label7.Text = "شماره ایدی";
            label8.Text = "ادرس";
            label9.Text = "توضیحات";
            PropertyTypeGroupBox.Text = "انتخاب نوع ملک";
            ApartmentRadioButton.Text = "1-اپارتمان";
            PrivateHouseRadioButton.Text = "2-منزل شخصی";
            PrivateLandRadioButton.Text = "3-زمین شخصی";
            PropertyDetailsGroupBox.Text = "مشخصات املاک";
            BtnSaveProperty.Text = "ثبت";
            BtnUpdateProperty.Text = "بروزرسانی";
            BtnDeleteProperty.Text = "حذف";
            BtnCancelProperty.Text = "انصراف";
            //-------------------------------------------------------------
            ContractPropertyDetailGroupBox.Text = "جزئیات ملک";
            label17.Text = "نام فروشنده";
            label16.Text = "متراژ";
            label15.Text = "طبقه";
            label14.Text = "قیمت";
            label13.Text = "موبایل فروشنده";
            label24.Text = "نام خریدار ";
            label23.Text = "موبایل خریدار";
            label12.Text = "شماره ایدی";
            label11.Text = "ادرس";
            label10.Text = "توضیحات";
            ContractGroupBox.Text= "نوع ملک";
            ContractApartmentRadioButton.Text = "1-اپارتمان";
            ContractPrivateHouseRadioButton.Text = "2-منزل شخصی";
            ContractPrivateLandRadioButton.Text = "3-زمین شخصی";
            BtnContractSearchID.Text = "       جستجو";
            BtnContractProceed.Text = "       تایید";
            //------------------------------------------------------------------
            
            RadioButtonArea.Text = "متراژ";
            RadioButtonPrice.Text = "قیمت";
            RadioButtonSeller.Text = "فروشنده";
            groupBox1.Text = "جستجو";
            //-------------------------------------------------------------------
            bunifuFlatButton2.Text = "حذف";
            label25.Text = "ایدی";
            SoldedDetailsGroupBox.Text = "جزئیات فروش";

        }

        private void TextBoxSearchProperty_TextChange(object sender, EventArgs e)
        {
            if (RadioButtonPrice.Checked==true)
            {
                DataGridViewSearchProperty.DataSource = db.Properties.Where(p => p.Price.Contains(TextBoxSearchProperty.Text)).ToList();
            }
            else if (RadioButtonArea.Checked==true)
            {
                DataGridViewSearchProperty.DataSource = db.Properties.Where(p => p.Area.Contains(TextBoxSearchProperty.Text)).ToList();
            }
            else if (RadioButtonSeller.Checked == true)
            {
                DataGridViewSearchProperty.DataSource = db.Properties.Where(p => p.Seller.Contains(TextBoxSearchProperty.Text)).ToList();
            }
        }



        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox2.Checked == true)
            {
                 FarsiCheckBox.Checked= false;
            }
            BtnNewProperty.Text = "       Property List";
            BtnContractRegistration.Text = "       Contract Registration";
            BtnSoldedProperty.Text = "       Solded Property";
            BtnSearchMenu.Text = "       Search";
            BtnHelp.Text = "       Help";
            BtnSettings.Text = "       Settings";
            BtnAbout.Text = "       About";
            label2.Text = "Seller";
            label3.Text = "Area";
            label4.Text = "Floor";
            label5.Text = "Price";
            label6.Text = "Seller Mobile Number";
            label7.Text = "Selected ID";
            label8.Text = "Address";
            label9.Text = "Description";
            PropertyTypeGroupBox.Text = "Choice Property Type";
            ApartmentRadioButton.Text = "1-Apartment";
            PrivateHouseRadioButton.Text = "2-Private House";
            PrivateLandRadioButton.Text = "3-Private Land";
            PropertyDetailsGroupBox.Text = "Property Details";
            BtnSaveProperty.Text = "Save";
            BtnUpdateProperty.Text = "Update";
            BtnDeleteProperty.Text = "Delete";
            BtnCancelProperty.Text = "Cancel";
            //-------------------------------------------------------------
            ContractPropertyDetailGroupBox.Text = "Property Details";
            label17.Text = "Seller";
            label16.Text = "Area";
            label15.Text = "Floor";
            label14.Text = "Price";
            label13.Text = "Seller Mobile Number";
            label24.Text = "Buyer Name *";
            label23.Text = "Buyer Mobile Number *";
            label12.Text = "Property ID";
            label11.Text = "Address";
            label10.Text = "Description";
            ContractGroupBox.Text = "Property Type";
            ContractApartmentRadioButton.Text = "1-Apartment";
            ContractPrivateHouseRadioButton.Text = "2-Private House";
            ContractPrivateLandRadioButton.Text = "3-Private Land";
            BtnContractSearchID.Text = "       Search";
            BtnContractProceed.Text = "       Proceed";
            //------------------------------------------------------------------

            RadioButtonArea.Text = "Area";
            RadioButtonPrice.Text = "Price";
            RadioButtonSeller.Text = "Seller";
            groupBox1.Text = "Search";
            //-------------------------------------------------------------------
            bunifuFlatButton2.Text = "Delete";
            label25.Text = "ID";
            SoldedDetailsGroupBox.Text = "Solded Details";
        }


        private void BtnAbout_Click(object sender, EventArgs e)
        {
            var About = new AboutForm();
            About.Show();
        }
    }
}
