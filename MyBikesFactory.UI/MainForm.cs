using MyBikesFactory.Business;
using MyBikesFactory.Business.Enums;
using MyBikesFactory.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBikesFactory.UI
{
    public partial class MainForm : Form
    {
        private List<Bikes> listOfBikes = BikesXmlData.Load();
        private Dictionary<int,int> dictionary = new Dictionary<int,int>();
        public MainForm()
        {
            InitializeComponent();
            RefreshDisplayList();
        }

        private Bikes? FindBikeBySerialNumber(int serialNumber)
        {
            Bikes? BikeFound = null;
            foreach (var bikes in listOfBikes)
            {
                if (bikes.SerialNumber == serialNumber)
                {
                    BikeFound = bikes;
                    break;
                }
            }
            return BikeFound;
        }

        private int GetIndexFromDictionnary()
        {
            int ListBoxIndex = lstBikes.SelectedIndex;
            if (ListBoxIndex < 0)
            {
                return -1;
            }
            return dictionary[ListBoxIndex];
        }

        private void RefreshDisplayList()
        {
            int ListCounter = 0;

            lstBikes.Items.Clear();

            foreach (var bikes in listOfBikes)
            {
                bool include = false;

                if (rbDisplayAll.Checked)
                {
                    include = true;
                }

                else if (rbDisplayMountain.Checked && bikes is MountainBikes)
                {
                    include = true;
                }

                else if (rbDisplayRoad.Checked && bikes is RoadBikes)
                {
                    include = true;
                }

                if (include)
                {
                    
                    lstBikes.Items.Add(bikes.ToString());
                }
                ListCounter++;
            }
        }

        private bool AllFieldsAreOk()
        {
            if (cbBikeType.Text == "")
            {
                MessageBox.Show("Please select a bike type!");
                return false;
            }
            else if (txtSerialNumber.Text == "" || !Validator.ValidateSerialNumber(txtSerialNumber.Text))
            {
                MessageBox.Show("Serial Number is required and should be numeric characters only!");
                return false;
            }
            else if (txtModel.Text == "")
            {
                MessageBox.Show("Please select a model!");
                return false;
            }
            else if (!Validator.ValidateModel(txtModel.Text))
            {
                MessageBox.Show("Model must contain 5 characters (number or letter)!");
                return false;
            }
            else if (txtManufacturingYear.Text == "")
            {
                MessageBox.Show("Please input a manufacturing year!");
                return false;
            }
            else if (!Validator.ValidateManYear(txtManufacturingYear.Text))
            {
                MessageBox.Show("Year must be numeric and 4 numbers only!");
                return false;
            }
            else if (cbColor.Text == "")
            {
                MessageBox.Show("Please select a color!");
                return false;
            }
            else if (cbBikeType.Text == "Road" && cbTireType.Text == "")
            {
                MessageBox.Show("Please select a tire type!");
                return false;
            }
            else if (cbBikeType.Text == "Mountain" && cbSuspensionType.Text == "")
            {
                MessageBox.Show("Please select a suspension type!");
                return false;
            }
            return true;
        }



        private void rbDisplayAll_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDisplayList();
        }

        private void rbDisplayMountain_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDisplayList();
        }

        private void rbDisplayRoad_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDisplayList();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (!AllFieldsAreOk())
            {
                return;
            }

            else if (txtSerialNumber.Text == "")
            {
                if (!Validator.ValidateUniqueSerialNumber(txtSerialNumber.Text, listOfBikes))
                {
                    MessageBox.Show("This serial number is already used!");
                    return;
                }
            }

            int originalSerialNumber = Convert.ToInt32(txtOriginalSerialNumber.Text);
            var bikeToUpdate = FindBikeBySerialNumber(originalSerialNumber);

            if (bikeToUpdate is MountainBikes && cbBikeType.Text == "Road" ||
                bikeToUpdate is RoadBikes && cbBikeType.Text == "Mountain")
            {
                int listIndex = GetIndexFromDictionnary();

                listOfBikes.RemoveAt(listIndex);

                if (cbBikeType.Text == "Road")
                {
                    bikeToUpdate = new RoadBikes();
                }
                else
                {
                    bikeToUpdate = new MountainBikes();
                }
                listOfBikes.Insert(listIndex, bikeToUpdate);
            }

            if (cbBikeType.Text == "Mountain")
            {
                (bikeToUpdate as MountainBikes)!.SuspensionType = (ESuspensionType)cbSuspensionType.SelectedIndex;
            }
            else
            {
                (bikeToUpdate as RoadBikes)!.TireType = (ETireType)cbTireType.SelectedIndex;
            }

            bikeToUpdate.SerialNumber = Convert.ToInt32(txtSerialNumber.Text);
            bikeToUpdate.Model = txtModel.Text;
            bikeToUpdate.ManufacturingYear = Convert.ToInt32(txtManufacturingYear.Text);
            bikeToUpdate.Color = (EColor)cbColor.SelectedIndex;


            RefreshDisplayList();


            MessageBox.Show("The list of bike has been updated");
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (txtSerialNumber.Text == "" || !Validator.ValidateSerialNumber(txtSerialNumber.Text))
            {
                MessageBox.Show("Serial Number is required and should be numeric!");
                return;
            }

            int Id = Convert.ToInt32(txtSerialNumber.Text);
            var BikeFound = FindBikeBySerialNumber(Id);

            if (BikeFound == null)
            {
                MessageBox.Show("Bike not found");
                return;
            }

            string Message = BikeFound.ToString().Replace(",", Environment.NewLine);
            MessageBox.Show(Message);
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            BikesXmlData.Save(listOfBikes);
            MessageBox.Show("Your bike has been saved!");
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!AllFieldsAreOk())
            {
                return;
            }
            else if (!Validator.ValidateUniqueSerialNumber(txtSerialNumber.Text, listOfBikes))
            {
                MessageBox.Show("This serial number is already used. Make use of another one!");
                return;
            }

            Bikes BikeToAdd;

            if (cbBikeType.Text == "Road")
            {
                ETireType TireType = (ETireType)cbTireType.SelectedIndex;
                BikeToAdd = new RoadBikes(TireType);
            }
            else
            {
                ESuspensionType SuspensionType = (ESuspensionType)cbSuspensionType.SelectedIndex;
                BikeToAdd = new MountainBikes(SuspensionType);
            }

            BikeToAdd.SerialNumber = Convert.ToInt32(txtSerialNumber.Text);
            BikeToAdd.Model = txtModel.Text;
            BikeToAdd.ManufacturingYear = Convert.ToInt32(txtManufacturingYear.Text);
            BikeToAdd.Color = (EColor)Enum.Parse(typeof(EColor), cbColor.Text);

            listOfBikes.Add(BikeToAdd);

            cbBikeType.SelectedIndex = -1;
            txtSerialNumber.Text = "";
            txtModel.Text = "";
            txtManufacturingYear.Text = "";
            cbTireType.SelectedIndex = -1;
            cbSuspensionType.SelectedIndex = -1;

            RefreshDisplayList();
            MessageBox.Show("The bike has been added");
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            int Index = GetIndexFromDictionnary();

            if (Index < 0)
            {
                MessageBox.Show("Please select a bike to remove");
                return;
            }

            var Result = MessageBox.Show("Do you really want to remove?",
                                          "Confirmation",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (Result != DialogResult.Yes)
            {
                return;
            }

            listOfBikes.RemoveAt(Index);
            lstBikes.Items.RemoveAt(lstBikes.SelectedIndex);
        }

        private void lstBikes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int ListIndex = GetIndexFromDictionnary();

            if (ListIndex < 0)
            {
                return;
            }

            var bike = listOfBikes[ListIndex];

            if (bike is MountainBikes)
            {
                cbBikeType.SelectedIndex = 0;
                var BikeForMountain = (MountainBikes)bike;
                cbSuspensionType.SelectedIndex = (int)BikeForMountain.SuspensionType;
            }
            else
            {
                cbBikeType.SelectedIndex = 1;
                var BikeForRoad = (RoadBikes)bike;
                cbTireType.SelectedIndex = (int)BikeForRoad.TireType;
            }


            txtSerialNumber.Text = bike.SerialNumber.ToString();
            txtOriginalSerialNumber.Text = txtSerialNumber.Text;
            txtModel.Text = bike.Model;
            txtManufacturingYear.Text = bike.ManufacturingYear.ToString();
            cbColor.SelectedIndex = (int)bike.Color;
        }

        private void cbBikeType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbBikeType.Text == "Mountain")
            {
                cbSuspensionType.Enabled = true;
                cbTireType.Enabled = false;
                cbSuspensionType.SelectedIndex = 0;
                cbTireType.SelectedIndex = -1;
            }
            else if (cbBikeType.Text == "Road")
            {
                cbSuspensionType.Enabled = false;
                cbTireType.Enabled = true;
                cbSuspensionType.SelectedIndex = -1;
                cbTireType.SelectedIndex = 0;
            }
        }
    }
}