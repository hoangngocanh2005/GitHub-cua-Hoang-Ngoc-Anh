using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.DataFormats;

namespace Water_Bill
{
    public partial class Form2 : Form
    {
        private int selectedIndex = -1; // Stores the index of the selected item

        public Form2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Do not allow user input
            tbConsumed.Enabled = false;
            tbPrice.Enabled = false;
            tbBill.Enabled = false;
            tbTotalBill.Enabled = false;

            // ListView configuration
            lvBills.View = View.Details;
            lvBills.Columns.Add("Customer Name", 165);
            lvBills.Columns.Add("Customer Type", 255);
            lvBills.Columns.Add("Customer Phone", 115);
            lvBills.Columns.Add("Old Water Index", 120);
            lvBills.Columns.Add("New Water Index", 120);
            lvBills.Columns.Add("Water Consumption (m³)", 170);
            lvBills.Columns.Add("Price (VNĐ)", 170);
            lvBills.Columns.Add("Bill + ENV (10%)", 190);
            lvBills.Columns.Add("Total Bill + VAT (10%)", 190);

            // Add event for selecting item in ListView
            lvBills.SelectedIndexChanged += new EventHandler(LvBills_SelectedIndexChanged);
        }

        private void LvBills_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBills.SelectedItems.Count > 0)
            {
                ListViewItem item = lvBills.SelectedItems[0];
                selectedIndex = item.Index;

                // Display value in input control
                tbCusName.Text = item.SubItems[0].Text;
                cbbCusType.Text = item.SubItems[1].Text;
                tbPhone.Text = item.SubItems[2].Text;
                tbOldWater.Text = item.SubItems[3].Text;
                tbNewWater.Text = item.SubItems[4].Text;
                tbConsumed.Text = item.SubItems[5].Text;
                tbPrice.Text = item.SubItems[6].Text;
                tbBill.Text = item.SubItems[7].Text;
                tbTotalBill.Text = item.SubItems[8].Text;
            }
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            int lastMonth;
            int thisMonth;

            if (string.IsNullOrWhiteSpace(tbOldWater.Text))
            {
                MessageBox.Show("Please enter the last month's water number.", "Notice",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbNewWater.Text))
            {
                MessageBox.Show("Please enter this month's water number.", "Notice",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check and get the value of the previous month's water number
            if (!int.TryParse(tbOldWater.Text, out lastMonth))
            {
                MessageBox.Show("Invalid input for last month's water number.", "Notice",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check and get the value of this month's water number
            if (!int.TryParse(tbNewWater.Text, out thisMonth))
            {
                MessageBox.Show("Invalid input for this month's water number.", "Notice",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If the water level last month is equal to the water level this month, a message is displayed.
            if (thisMonth == lastMonth)
            {
                MessageBox.Show("This month's water number is the same as last month's. No water consumption recorded.", "Notice",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If the amount of water this month is less than the amount of water last month, please re-enter.
            if (thisMonth < lastMonth)
            {
                MessageBox.Show("This month's water number must be greater than or equal to last month's.", "Notice",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Calculate water consumption
            int waterConsumption = thisMonth - lastMonth;

            // Show results in Consumed
            tbConsumed.Text = waterConsumption.ToString();

            double price = Calculate(waterConsumption, cbbCusType.SelectedIndex);
            tbPrice.Text = price.ToString();

            double bill = GetBill(price);
            tbBill.Text = bill.ToString();

            double totalBill = TotalBill(bill);
            tbTotalBill.Text = totalBill.ToString();
        }

        private double Calculate(int waterConsumption, int customerType)
        {
            double price = 0;
            switch (customerType)
            {
                case 0:
                    if (waterConsumption <= 10)
                    {
                        price = waterConsumption * 5.972;
                    }
                    else if (waterConsumption > 10 && waterConsumption <= 20)
                    {
                        price = ((waterConsumption - 10) * 7.052) + 10 * 5.972;
                    }
                    else if (waterConsumption > 20 && waterConsumption <= 30)
                    {
                        price = ((waterConsumption - 20) * 8.699) + 10 * 7.052 + 10 * 5.972;
                    }
                    else
                    {
                        price = ((waterConsumption - 30) * 15.929) + 10 * 8.699 + 10 * 7.052 + 10 * 5.972;
                    }
                    break;
                case 1:
                    price = waterConsumption * 9.955;
                    break;
                case 2:
                    price = waterConsumption * 11.615;
                    break;
                case 3:
                    price = waterConsumption * 22.068;
                    break;
            }
            return price;
        }

        private double GetBill(double price)
        {
            double env = 0.1; // 10% environmental fee
            return price * (1 + env);
        }

        private double TotalBill(double bill)
        {
            double VAT = 0.1; // 10% VAT
            return bill * (1 + VAT);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string CusName = tbCusName.Text;
            string CusType = cbbCusType.Text;
            string Phone = tbPhone.Text;
            string OldWater = tbOldWater.Text;
            string NewWater = tbNewWater.Text;
            string Consumed = tbConsumed.Text;
            string Price = tbPrice.Text;
            string Bill = tbBill.Text;
            string TotalBill = tbTotalBill.Text;

            // Create ListViewItem
            ListViewItem item = new ListViewItem();
            item.Text = CusName;
            item.SubItems.Add(CusType);
            item.SubItems.Add(Phone);
            item.SubItems.Add(OldWater);
            item.SubItems.Add(NewWater);
            item.SubItems.Add(Consumed);
            item.SubItems.Add(Price);
            item.SubItems.Add(Bill);
            item.SubItems.Add(TotalBill);

            // Add ListViewItem to ListView
            lvBills.Items.Add(item);

            tbCusName.Clear();
            cbbCusType.SelectedIndex = -1;
            tbPhone.Clear();
            tbOldWater.Clear();
            tbNewWater.Clear();
            tbConsumed.Clear();
            tbPrice.Clear();
            tbBill.Clear();
            tbTotalBill.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvBills.SelectedItems != null)
            {
                // Show confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure you want to edit this item?", "Confirm Edit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                {
                    return; // User selects "No" will stop editing
                }

                int lastMonth;
                int thisMonth;

                // Check and get the value of the previous month's water
                if (!int.TryParse(tbOldWater.Text, out lastMonth))
                {
                    MessageBox.Show("Invalid input for last month's water number.", "Noitice",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check and get the value of this month's water number
                if (!int.TryParse(tbNewWater.Text, out thisMonth))
                {
                    MessageBox.Show("Invalid input for this month's water number.", "Noitice",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if this month's water count is less than last month's water count
                if (thisMonth < lastMonth)
                {
                    MessageBox.Show("This month's water number must be greater than or equal to last month's.", "Noitice",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calculate m³ of water consumption and bills
                int waterConsumption = thisMonth - lastMonth;
                double price = Calculate(waterConsumption, cbbCusType.SelectedIndex);
                double bill = GetBill(price);
                double totalBill = TotalBill(bill);

                // Edit items in ListView
                ListViewItem item = lvBills.Items[selectedIndex];
                item.SubItems[0].Text = tbCusName.Text;
                item.SubItems[1].Text = cbbCusType.Text;
                item.SubItems[2].Text = tbPhone.Text;
                item.SubItems[3].Text = tbOldWater.Text;
                item.SubItems[4].Text = tbNewWater.Text;
                item.SubItems[5].Text = waterConsumption.ToString();
                item.SubItems[6].Text = price.ToString();
                item.SubItems[7].Text = bill.ToString();
                item.SubItems[8].Text = totalBill.ToString();

                // Reset selectedIndex
                selectedIndex = -1;

                // Clear input controls after edit
                tbCusName.Clear();
                tbPhone.Clear();
                tbOldWater.Clear();
                tbNewWater.Clear();
                tbConsumed.Clear();
                tbPrice.Clear();
                tbBill.Clear();
                tbTotalBill.Clear();
                cbbCusType.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Please select an item to edit.", "Noitice",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvBills_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this delete ?", "Confirm Delete",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return; // User selecting "No" will stop the delete
            }

            if (selectedIndex != -1)
            {
                // Delete selected item
                lvBills.Items.RemoveAt(selectedIndex);
                selectedIndex = -1;

                // Clear input controls
                tbCusName.Clear();
                cbbCusType.SelectedIndex = -1;
                tbPhone.Clear();
                tbOldWater.Clear();
                tbNewWater.Clear();
                tbConsumed.Clear();
                tbPrice.Clear();
                tbBill.Clear();
                tbTotalBill.Clear();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            rtbPrintWaterBill.Text = "Customer name: " + tbCusName.Text + "\n"
                + "Customer type: " + cbbCusType.Text + "\n"
                + "Number of water consumed: " + tbConsumed.Text + " (m3)" + "\n"
                + "Price (VNĐ): " + tbPrice.Text + " VNĐ" + "\n"
                + "Bill + ENV (10%): " + tbBill.Text + " VNĐ" + "\n"
                + "Total Bill + VAT (10%): " + tbTotalBill.Text + " VNĐ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit ?", "Confirm Exit",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return; // User selecting "No" will stop the exit
            }

            Application.Exit();
        }

        private void btnCalculator_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.LightGreen;
        }
        private void btnCalculator_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = SystemColors.Control;
        }
        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.LightGreen;
        }
        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = SystemColors.Control;
        }
        private void btnEdit_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.LightGreen;
        }
        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = SystemColors.Control;
        }
        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.LightGreen;
        }
        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = SystemColors.Control;
        }
        private void btnPrint_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.LightGreen;
        }
        private void btnPrint_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = SystemColors.Control;
        }
        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.LightGreen;
        }
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = SystemColors.Control;
        }
    }
}
