using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostomerComApps
{
    public partial class customerUI : Form
    {
        public customerUI()
        {
            InitializeComponent();
        }
        Queue<Customer> cQueue = new Queue<Customer>();
        
        private int customerIdIndex = 1;
        private void Enqueue_Click(object sender, EventArgs e)
        {
            Customer aCustomer = new Customer();
            aCustomer.customerName = nameBox.Text;
            aCustomer.customerComplain = complainBox.Text;
            aCustomer.customerId = customerIdIndex.ToString();
            cQueue.Enqueue(aCustomer);
            customerIdIndex ++;
            ListViewItem item = new ListViewItem(aCustomer.customerId);
             
            item.SubItems.Add(aCustomer.customerName);
            item.SubItems.Add(aCustomer.customerComplain);
            myListView.Items.Add(item);
            MessageBox.Show(" Complain Number Is" + " " + aCustomer.customerId);
            nameBox.Text = "";
            complainBox.Text = "";



        }

        private void Dequeue_Click(object sender, EventArgs e)
        {
            Customer aCustomer = new Customer();
            aCustomer= cQueue.Dequeue();
            dequeueIdBox.Text = aCustomer.customerId;
            dequeueNameBox.Text = aCustomer.customerName;
            dequeueComplainBox.Text = aCustomer.customerComplain;
            myListView.Items[0].Remove();
        }
    }
}
