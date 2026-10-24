using System;
using System.Collections.Generic;

using System.Globalization;


using System.Windows.Forms;

namespace sdf1_c_
{
    public partial class Form1 : Form
    {
        EmployeeServiceBase service = new EmployeeService();

        public Form1()
        {
            InitializeComponent();
        }

        private void RefreshEmployeeLists()
        {
            lstEmployees.Items.Clear();
            cmbEmployees.Items.Clear();

            foreach (Employee emp in service.GetAllEmployees())
            {
                lstEmployees.Items.Add(emp);
                cmbEmployees.Items.Add(emp);
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            int age;

            if (code == "" || firstName == "" || lastName == "" ||
                txtAge.Text.Trim() == "")
            {
                MessageBox.Show("Bütün sahələri doldurun!", "Xəbərdarlıq",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAge.Text.Trim(), out age) || age <= 0 || age > 120)
            {
                MessageBox.Show("Yaş 1 ilə 120 arasında tam ədəd olmalıdır!",
                    "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Employee emp = new Employee();
            emp.Code = code;
            emp.FirstName = firstName;
            emp.LastName = lastName;
            emp.Age = age;

            if (!service.AddEmployee(emp))
            {
                MessageBox.Show("Bu koda malik işçi artıq mövcuddur!",
                    "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("İşçi uğurla əlavə olundu!", "Uğur",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCode.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAge.Clear();
            RefreshEmployeeLists();
            txtCode.Focus();
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {

            Employee selected = cmbEmployees.SelectedItem as Employee;
            if (selected == null)
            {
                MessageBox.Show("Əvvəlcə işçini seçin!", "Xəbərdarlıq",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string title = txtPaymentTitle.Text.Trim();
            if (title == "")
            {
                MessageBox.Show("Ödənişin adını daxil edin!", "Xəbərdarlıq",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double amount;
            string amountText = txtAmount.Text.Trim().Replace(',', '.');
            if (!double.TryParse(amountText, NumberStyles.Float,
                CultureInfo.InvariantCulture, out amount))
            {
                MessageBox.Show("Məbləğ düzgün daxil edilməyib!", "Xəta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!service.AddPayment(selected.Code, title, amount))
            {
                MessageBox.Show("Ödəniş yazılmadı! Məbləğ 0-dan böyük olmalıdır.",
                    "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Ödəniş uğurla yazıldı!", "Uğur",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtPaymentTitle.Clear();
            txtAmount.Clear();
            txtPaymentTitle.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string code = txtSearchCode.Text.Trim();

            if (code == "")
            {
                MessageBox.Show("İşçi kodunu daxil edin!", "Xəbərdarlıq",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lstPayments.Items.Clear();
            Employee emp = service.FindEmployee(code);


            if (emp == null)
            {
                lblInfo.Text = "";
                MessageBox.Show("Bu koda malik işçi tapılmadı!", "Xəbərdarlıq",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            lblInfo.Text = "Kod: " + emp.Code + Environment.NewLine +
                           "Ad: " + emp.FirstName + Environment.NewLine +
                           "Soyad: " + emp.LastName + Environment.NewLine +
                           "Yaş: " + emp.Age;

            List<Payment> payments = service.GetEmployeePayments(code);
            if (payments == null || payments.Count == 0)
            {
                lstPayments.Items.Add("Bu işçinin hələ ödənişi yoxdur.");
            }
            else
            {
                foreach (Payment pay in payments)
                {
                    lstPayments.Items.Add(pay.Title + " - " + pay.Amount);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Proqramdan çıxmaq istəyirsiniz?", "Çıxış təsdiqi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
